using MyCustomWindowsService.Utilities;
using System;
using System.ServiceProcess;

namespace MyCustomWindowsService
{
    public partial class CustomService : ServiceBase
    {
        public CustomService()
        {
            InitializeComponent();
            // TODO: Inside constructor you can initialize some cars or process needed by service
        }

        public void TestStartupAndStop(string[] args)
        {
            this.OnStart(args);
            Console.WriteLine("Press any key to end interactive service execution...");
            Console.ReadLine();
            this.OnStop();
        }

        protected override void OnStart(string[] args)
        {
            //this method is responsible of the execution of the service processes

            // We can write events at event log 
            this.WriteEventLog("MyCustomService", "Test de Mensajes");

            

        }

        protected override void OnContinue()
        {
            base.OnContinue();
            // This method launches when service is continued after paused action
        }

        protected override void OnPause()
        {
            base.OnPause();
            // This method launches when service is paused
        }

        protected override void OnStop()
        {
            // Here, you put some actions before the service is stopped
        }
    }
}
