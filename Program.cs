using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net.Mime;
using System.IO;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
//using Image = System.Drawing.Image;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь");
            string puth=Console.ReadLine();
            List<string> fileNames = new List<string>();
            string[] result = Directory.GetFiles(puth, "*png");
            fileNames.AddRange(result);
            string[] fileNames2 = Directory.GetFiles(puth, "*.jpg");
            fileNames.AddRange(fileNames2);
            foreach (string file in fileNames)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("Введите изображение");
            string image= Console.ReadLine();
            string puthresult = puth + "\\" + image;
            Console.WriteLine(puthresult);
            FileInfo fileinfo = new FileInfo(puthresult);
            long fileSize = fileinfo.Length;
            Console.WriteLine("Размер файла - "+fileSize);
            FileInfo fileinf = new FileInfo(puthresult);
            string newpath = Directory.GetCurrentDirectory();
            string newpath1 = Path.GetDirectoryName(newpath);
           
            string newpath2 = Path.GetDirectoryName(newpath1);
            string newpath3 = Path.GetDirectoryName(newpath2);
            Console.WriteLine(newpath3);
            Directory.CreateDirectory(newpath3+"\\Image");
            FileInfo fileInf= new FileInfo(puthresult);
            string resultresult = newpath3 + "\\Image" + "\\"+image;
            if(fileInf.Exists)
            {
                fileInf.CopyTo(resultresult);
            }
        }
        
    }
}
