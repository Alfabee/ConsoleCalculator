using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Logger : ILogger
    {
        private readonly string logFile = "log.txt";

        public void Log(string message)
        {
            File.AppendAllText(logFile, $"{DateTime.Now}: {message}\n");
        }
    }
}
