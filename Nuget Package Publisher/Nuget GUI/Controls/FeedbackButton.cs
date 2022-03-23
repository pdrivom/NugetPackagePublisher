using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuget_GUI.Controls
{
    public  class FeedbackButton:Button
    {
        public void SetOK()
        {
            Task.Factory.StartNew(() =>
            {
                this.BackColor = Color.LightGreen;
                Thread.Sleep(1000);
                Default();
            });
        }
        public void SetNOK()
        {
            Task.Factory.StartNew(() =>
            {
                this.BackColor = Color.IndianRed;
                Thread.Sleep(1000);
                Default();
            });
        }
        private void Default()
        {
            this.BeginInvoke((Action)(() =>
            {
                this.BackColor = SystemColors.Control;
                this.Enabled = true;
            }));
        }
    }
}
