using System;
using System.ServiceProcess;

namespace MyCustomWindowsService
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main(string[] args)
        {
            //sc.exe create CustomService start=auto binPath="<Path to File>\service.exe" DisplayName="My Custom Service"
            //sc.exe delete CustomService
            if (Environment.UserInteractive)
            {
                CustomService customService = new CustomService();
                customService.TestStartupAndStop(args);
            }
            else
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new CustomService()
                };
                ServiceBase.Run(ServicesToRun);
            }
            
        }
    }
}
