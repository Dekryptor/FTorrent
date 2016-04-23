using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTorrent
{
    class Switcher : WindowsFormsApplicationBase
    {
        public Switcher()
        {
            this.IsSingleInstance = true;
            this.StartupNextInstance += Switcher_StartupNextInstance;
        }

        private void Switcher_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            Args.args = e.CommandLine.ToArray();
        }

        protected override void OnCreateMainForm()
        {
            string[] args = Environment.GetCommandLineArgs();
            MainForm = new mainForm(args);
        }
    }
}
