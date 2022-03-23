using Nuget_GUI.Models;
using CliWrap;
using CliWrap.EventStream;
using System.Text;

namespace Nuget_GUI
{
    public partial class UI : Form
    {
        private Configuration Configuration { get; }
        private string NugetExe => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "packages\\nuget.exe");
        private string PackagesFolder  => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "packages"); 
        private bool PublishFailed { get; set; }

        public UI()
        {
            InitializeComponent();
            Configuration = Configuration.Load();
            InitializeUI();
            CopyNugetExe();
        }
        private void InitializeUI()
        {
            btnAPIKey.Tag = true;
            btnSave.Tag = true;
            if (!string.IsNullOrEmpty(Configuration.ApiKey))
            {
                tbAPIKey.Enabled = false;
                btnAPIKey.ToEditMode();
            }
            if (!string.IsNullOrEmpty(Configuration.Server))
            {
                tbServer.Enabled = false;
                btnSave.ToEditMode();
            }
            tbAPIKey.Text = Configuration.ApiKey;
            tbServer.Text = Configuration.Server;
            btnPublish.Enabled = false;
            btnRemove.Enabled = false;
            Configuration.Packages.ToList().ForEach(p => lbxPackages.Items.Add(FileOfPath(p)));
        }
        private void CopyNugetExe()
        {
            if (!Directory.Exists(PackagesFolder)) Directory.CreateDirectory(PackagesFolder);
            if (!File.Exists(NugetExe))
            {
                File.WriteAllBytes(NugetExe, Properties.Resources.nuget);
            }
        }
        private string CopyPackage(string source)
        {
            var destination = Path.Combine(PackagesFolder, Path.GetFileName(source));
            if (!Directory.Exists(destination)) File.Delete(destination);
            File.Copy(source, destination);
            return destination;
        }
        private bool ValidateServer(string server)
        {
            return server.Contains("http://") || server.Contains("https://");
        }
        private void AddPackage(string path)
        {
            if (!Configuration.Packages.Contains(path))
            {
                var newpath = CopyPackage(path);
                Configuration.Packages.Add(newpath);
                lbxPackages.Items.Add(FileOfPath(path));
                Configuration.Save();
            }
            else
            {
                lbxPackages.SelectedItem = FileOfPath(path);
            }
        }
        private string FileOfPath(string path)
        {
            return Path.GetFileName(path);
        }
        private string PathOfFile(string file)
        {
            lbxPackages.Items.Remove(FileOfPath(file));
            return Configuration.Packages.First(p => p.Contains(file));
        }
        private void RemovePackage(string package)
        {
            if (package != null)
            {
                var path = PathOfFile(package);
                if (File.Exists(path)) File.Delete(path);
                Configuration.Packages.Remove(path);
                Configuration.Save();
                if (lbxPackages.Items.Count == 0)
                {
                    btnRemove.Enabled = false;
                    btnPublish.Enabled = false;
                }
            }
        }
        private async void RunCmd(string package, string server, string apiKey)
        {
            PublishFailed = false;
            var stdOutBuffer = new StringBuilder();
            var stdErrBuffer = new StringBuilder();
            var cmd = Cli.Wrap(NugetExe).WithValidation(CommandResultValidation.None).WithWorkingDirectory(PackagesFolder).WithArguments(args => args
                .Add("push")
                .Add(package)
                .Add("-Source")
                .Add(server)
                .Add("-ApiKey")
                .Add(apiKey));

            await foreach (var cmdEvent in cmd.ListenAsync())
            {
                switch (cmdEvent)
                {
                    case StartedCommandEvent started:
                        AppendTextOnRichTextbox($"Running Publish Command [{started.ProcessId}]", Color.White);
                        rtOutput.AppendText(Environment.NewLine);
                        break;
                    case StandardOutputCommandEvent stdOut:
                        AppendTextOnRichTextbox(stdOut.Text, Color.White);
                        break;
                    case StandardErrorCommandEvent stdErr:
                        PublishFailed = true;
                        AppendTextOnRichTextbox(stdErr.Text, Color.Red);
                        break;
                    case ExitedCommandEvent exited:
                        rtOutput.AppendText(Environment.NewLine);
                        AppendTextOnRichTextbox($"Publish Finisehd [{exited.ExitCode}]", Color.White);
                        break;
                }
            }
            if (PublishFailed) btnPublish.SetNOK();
            else btnPublish.SetOK();
        }
        public void AppendTextOnRichTextbox(string text,Color color)
        {
            rtOutput.SelectionStart = rtOutput.TextLength;
            rtOutput.SelectionLength = 0;

            rtOutput.SelectionColor = color;
            rtOutput.AppendText(text);
            rtOutput.SelectionColor = rtOutput.ForeColor;
            rtOutput.AppendText(Environment.NewLine);

            rtOutput.SelectionStart = rtOutput.Text.Length;
            rtOutput.ScrollToCaret();
        }
        private void btnPublish_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbxPackages.SelectedItem != null)
                {
                    btnPublish.Enabled = false;
                    RunCmd(lbxPackages.SelectedItem.ToString(), Configuration.Server, Configuration.ApiKey);
                }
            }
            catch (Exception ex)
            {
                AppendTextOnRichTextbox(ex.Message,Color.Red);
            }
        }
        private void btnAddPackages_Click(object sender, EventArgs e)
        {
            AddPackageDialog();
        }
        private void AddPackageDialog()
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "Nuget Package Files |*.nupkg";
            if (res.ShowDialog() == DialogResult.OK)
            {
                AddPackage(res.FileName);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxPackages.SelectedItem != null)
            {
                RemovePackage(lbxPackages.SelectedItem.ToString());
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Edit)
            {
                tbServer.Enabled = true;
                btnSave.ToSaveMode();
            }
            else
            {
                if (ValidateServer(tbServer.Text))
                {
                    Configuration.Server = tbServer.Text;
                    tbServer.Enabled = false;
                    btnSave.ToEditMode();
                    Configuration.Save();
                }
            }
        }
        private void btnAPIKey_Click(object sender, EventArgs e)
        {
            if (btnAPIKey.Edit)
            {
                tbAPIKey.Enabled = true;
                btnAPIKey.ToSaveMode();
            }
            else
            {
                if (!string.IsNullOrEmpty(tbAPIKey.Text))
                {
                    Configuration.ApiKey = tbAPIKey.Text;
                    tbAPIKey.Enabled = false;
                    btnAPIKey.ToEditMode();
                    Configuration.Save();
                }
            }
        }
        private void lbxPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            if(!Configuration.IsEmpty) btnPublish.Enabled = true;
        }
        private void Update_Click(object sender, EventArgs e)
        {
            RemovePackage(lbxPackages.SelectedItem.ToString());
            AddPackageDialog();
        }
    }
}