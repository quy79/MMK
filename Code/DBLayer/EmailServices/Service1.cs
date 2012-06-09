using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace EmailServices
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //base.OnStart(args);

            do
            {
                EmailSystem.SendEmails();

                Thread.Sleep(30000);
            } while (true);
        }

        protected override void OnStop()
        {
            DBManager.CloseConnection();

            //base.Stop();
        }
    }
}
