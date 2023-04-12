using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace MyCustomWindowsService
{
    [RunInstaller(true)]
    public partial class CustomServiceInstaller : System.Configuration.Install.Installer
    {
        public CustomServiceInstaller()
        {
            InitializeComponent();
        }
    }
}
