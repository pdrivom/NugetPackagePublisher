using Nuget_GUI.Controls;

namespace Nuget_GUI
{
    partial class UI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Header = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAPIKey = new System.Windows.Forms.TextBox();
            this.btnAPIKey = new Nuget_GUI.Controls.EditButton();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnSave = new Nuget_GUI.Controls.EditButton();
            this.btnPublish = new Nuget_GUI.Controls.FeedbackButton();
            this.lbxPackages = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddPackages = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.rtOutput = new System.Windows.Forms.RichTextBox();
            this.MainLayout.SuspendLayout();
            this.Header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.Header, 0, 0);
            this.MainLayout.Controls.Add(this.btnPublish, 0, 3);
            this.MainLayout.Controls.Add(this.lbxPackages, 0, 1);
            this.MainLayout.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.MainLayout.Controls.Add(this.rtOutput, 0, 4);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 5;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.MainLayout.Size = new System.Drawing.Size(582, 553);
            this.MainLayout.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.ColumnCount = 3;
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.Header.Controls.Add(this.label1, 0, 1);
            this.Header.Controls.Add(this.tbAPIKey, 0, 1);
            this.Header.Controls.Add(this.btnAPIKey, 0, 1);
            this.Header.Controls.Add(this.tbServer, 1, 0);
            this.Header.Controls.Add(this.lblServer, 0, 0);
            this.Header.Controls.Add(this.btnSave, 2, 0);
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Name = "Header";
            this.Header.RowCount = 2;
            this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Header.Size = new System.Drawing.Size(576, 84);
            this.Header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "API Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAPIKey
            // 
            this.tbAPIKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAPIKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAPIKey.Location = new System.Drawing.Point(95, 45);
            this.tbAPIKey.Name = "tbAPIKey";
            this.tbAPIKey.Size = new System.Drawing.Size(397, 34);
            this.tbAPIKey.TabIndex = 4;
            // 
            // btnAPIKey
            // 
            this.btnAPIKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAPIKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAPIKey.Location = new System.Drawing.Point(498, 45);
            this.btnAPIKey.Name = "btnAPIKey";
            this.btnAPIKey.Size = new System.Drawing.Size(75, 36);
            this.btnAPIKey.TabIndex = 3;
            this.btnAPIKey.Text = "Save";
            this.btnAPIKey.UseVisualStyleBackColor = true;
            this.btnAPIKey.Click += new System.EventHandler(this.btnAPIKey_Click);
            // 
            // tbServer
            // 
            this.tbServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbServer.Location = new System.Drawing.Point(95, 3);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(397, 34);
            this.tbServer.TabIndex = 0;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServer.Location = new System.Drawing.Point(3, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(86, 42);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(498, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPublish
            // 
            this.btnPublish.BackColor = System.Drawing.SystemColors.Control;
            this.btnPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPublish.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPublish.Location = new System.Drawing.Point(3, 342);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(576, 58);
            this.btnPublish.TabIndex = 2;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = false;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // lbxPackages
            // 
            this.lbxPackages.BackColor = System.Drawing.SystemColors.Control;
            this.lbxPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxPackages.FormattingEnabled = true;
            this.lbxPackages.ItemHeight = 20;
            this.lbxPackages.Location = new System.Drawing.Point(3, 93);
            this.lbxPackages.Name = "lbxPackages";
            this.lbxPackages.Size = new System.Drawing.Size(576, 203);
            this.lbxPackages.TabIndex = 3;
            this.lbxPackages.SelectedIndexChanged += new System.EventHandler(this.lbxPackages_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnAddPackages, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemove, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 302);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 34);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnAddPackages
            // 
            this.btnAddPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPackages.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPackages.Location = new System.Drawing.Point(3, 3);
            this.btnAddPackages.Name = "btnAddPackages";
            this.btnAddPackages.Size = new System.Drawing.Size(282, 28);
            this.btnAddPackages.TabIndex = 2;
            this.btnAddPackages.Text = "Add Package";
            this.btnAddPackages.UseVisualStyleBackColor = true;
            this.btnAddPackages.Click += new System.EventHandler(this.btnAddPackages_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(291, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(282, 28);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Package";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // rtOutput
            // 
            this.rtOutput.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtOutput.ForeColor = System.Drawing.SystemColors.Menu;
            this.rtOutput.Location = new System.Drawing.Point(3, 406);
            this.rtOutput.Name = "rtOutput";
            this.rtOutput.ReadOnly = true;
            this.rtOutput.Size = new System.Drawing.Size(576, 144);
            this.rtOutput.TabIndex = 6;
            this.rtOutput.Text = "";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.Text = "Nuget GUI";
            this.MainLayout.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainLayout;
        private TableLayoutPanel Header;
        private TextBox tbServer;
        private Label lblServer;
        private EditButton btnSave;
        private FeedbackButton btnPublish;
        private ListBox lbxPackages;
        private Label label1;
        private TextBox tbAPIKey;
        private EditButton btnAPIKey;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAddPackages;
        private Button btnRemove;
        private RichTextBox rtOutput;
    }
}