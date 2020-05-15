using Plc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() : base()
        {
            // Dealy on cyclic read/write 
            Entry.Plc.Connector.ReadWriteCycleDelay = 75;
            Entry.Plc.Connector.BuildAndStart();
        }
    }
}
