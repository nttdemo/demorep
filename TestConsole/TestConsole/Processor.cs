using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using TestConsole.Common;

namespace TestConsole
{
    public class Processor
    {
        public Processor()
        {

        }

        internal ITestLog Log { get; set; }

        static void Main(string[] args)
        {
            var program = new Processor();
            program.InitLogger();
            
        }

        internal  void InitLogger()
        {
            this.Log = Utility.InitLog();
            Utility.SetLogPath(string.Empty);
            Log.Info("App Started");
        }

    }
}
