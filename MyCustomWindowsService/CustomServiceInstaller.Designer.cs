namespace MyCustomWindowsService
{
    partial class CustomServiceInstaller
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            this.ServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            // 
            // ServiceInstaller
            // 
            this.ServiceInstaller.Description = "My Custom Service launches some amazing actions";
            this.ServiceInstaller.DisplayName = "My Custom Service";
            this.ServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ServiceProcessInstaller
            // 
            this.ServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ServiceProcessInstaller.Password = null;
            this.ServiceProcessInstaller.Username = null;
            // 
            // CustomServiceInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ServiceInstaller,
            this.ServiceProcessInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceInstaller ServiceInstaller;
        private System.ServiceProcess.ServiceProcessInstaller ServiceProcessInstaller;
    }
}