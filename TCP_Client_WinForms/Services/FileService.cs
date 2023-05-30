using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Client_WinForms.Services
{
    public class FileService
    {
        string filePath = "";
        ZipArhiver arhiver = null;
        SettingsJson settingsJson = null;

        public FileService(string _filePath, string _engine, int _count)
        {
            filePath = _filePath;
            arhiver = new ZipArhiver();
            settingsJson = new SettingsJson(_engine, _count);
        }

        public FileInfo GetArhive()
        {
            var folderPath = filePath.Substring(0, filePath.LastIndexOf('\\'));

            string subpath = @"program\prearchive";
            DirectoryInfo dirInfo = new DirectoryInfo(folderPath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            dirInfo.CreateSubdirectory(subpath);

            string namePath1 = @".\start";//имя папки для архивации

            string namePath = @".\archives\";//имя папки для архивации
            string nameZip = @".\result.zip";//имя которое будет присвоено zip
            //string nameReArchPath = @".\extract";//имя для зарархивированной папки

            FileInfo fileInf = new FileInfo(filePath);
            
            var newFolder = dirInfo + "\\" + subpath;
            FileInfo fileInf1 = new FileInfo(newFolder + "\\Source.blend");

            if (fileInf.Exists && !fileInf1.Exists)
            {
                fileInf.CopyTo(newFolder + "\\Source.blend");
                //File.Copy(filePath, newFolder + "\\Source.blend");
            }

            var finalName = folderPath + namePath + nameZip;

            var dateNow = DateTime.Now;

            //ZipFile.CreateFromDirectory(newFolder, nameZip + "_" + dateNow.Year + "_" + dateNow.Month + "_" + dateNow.Day + "_"  "_" + ".zip");//создать архив zip папки... с именем...

            FileInfo archivefile = new FileInfo(nameZip);
            if (!archivefile.Exists)
            {
                ZipFile.CreateFromDirectory(newFolder, nameZip); //создать архив zip папки... с именем...
                archivefile = new FileInfo(nameZip);
            }
            
            return archivefile;

            //ZipFile.ExtractToDirectory(nameZip, nameReArchPath);//извлечь архив zip с таким именем... в такую-то папку...
        }
    }

    public class ZipArhiver
    {
        public static void Arhive()
        {

        }
    }

    public class SettingsJson
    {
        public string RenderEngine = "";
        public int RaysCount = 0;

        public SettingsJson(string _engine, int _raysCount)
        {
            RenderEngine = _engine;
            RaysCount = _raysCount;
        }
    }
}
