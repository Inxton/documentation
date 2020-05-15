using Plc;

namespace WpfApp
{
    public class MainWindowModel
    {
        public MainWindowModel()
        {         
             MAIN = Entry.Plc.MAIN;
        }

        public MAIN MAIN { get; set; }
    }
}