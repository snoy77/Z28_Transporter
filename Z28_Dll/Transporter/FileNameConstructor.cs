using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z28_Dll.Transporter
{
    public class FileNameConstructor
    {
        public string replaceFileNameInPath(string sourceFileName, string newFileName, bool addSourceFormat)
        {
            //МЕТОД ЗАМЕНЯЕТ ТОЛЬКО ИМЯ ФАЙЛА В СТРОКЕ ПУТИ

            //Третий аргумент, addSourceFormat, если false: не добавляет к newFileName формат исходного файла. 
            //                                  При true: учитывает формат файла, и добавляет его

            if (addSourceFormat)
            {
                newFileName += Path.GetExtension(sourceFileName);//Добавление формата файла
            }

            int indexofSlesh = sourceFileName.LastIndexOf('\\'); //Узнаю индекс последнего слеша
            string pathToDirectory = sourceFileName.Substring(0, indexofSlesh+1); //путь до директории с слешем на конце

            string newPathFile = pathToDirectory + newFileName; //Подставляю новое имя файла к пути до директории

            return newPathFile;
        }

        public FileNameConstructor() { }
    }
}
