using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Paint
{
    public class Logger
    {
        public void Log(Exception ex)
        {
            string path = @"Errors.txt";

            if(File.Exists(path))
            {
                using (StreamWriter log = File.AppendText(path))
                {
                    log.WriteLine("Error logged:");
                    log.WriteLine(ex.GetType());
                    log.WriteLine(ex.Message);
                    log.WriteLine(ex.StackTrace);
                    log.WriteLine();
                }

            }
            else
            {
                using (StreamWriter log = File.CreateText(path))
                {
                    log.WriteLine(ex.GetType());
                    log.WriteLine(ex.StackTrace);
                    log.WriteLine();
                }
            }
        }
    }
}
