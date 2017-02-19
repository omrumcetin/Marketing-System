using System;
using System.Diagnostics;
using System.IO;

namespace SM
{
    class traceLogger
    {
        public traceLogger()
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "LOGS"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "LOGS");
            }
        }

        public void enterRecord(string record)
        {
            TextWriterTraceListener myListener = new TextWriterTraceListener(AppDomain.CurrentDomain.BaseDirectory + "LOGS\\" + DateTime.Now.ToString("yyyyMMdd") + ".log", "MyListener");
            myListener.Write(DateTime.Now + " -> ");
            myListener.WriteLine(record);
            myListener.Flush();
        }
    }
}
