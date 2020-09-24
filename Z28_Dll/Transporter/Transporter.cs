using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Z28_Dll.Transporter
{
    public class Transporter
    {
        public void transportFiles(string sourceFileName, string pathTo, bool removeSourceFile)
        {
            if (removeSourceFile)
            {
                File.Copy(sourceFileName, pathTo);
                File.Delete(sourceFileName);
            }
            else
            {
                File.Copy(sourceFileName, pathTo);
            }
        }
        public void transportFiles(string[] sourceFileName, string pathTo, bool removeSourceFile)
        {
            foreach (string el in sourceFileName)
            {
                this.transportFiles(el, pathTo, removeSourceFile);
            }
        }

        //КОНСТРУКТОРЫ
        public Transporter() { }
    }
}
