using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CreateJSON
{

    class Tool
    {
        //Store value
        public static string[] role = { "Wiz", "Sacred", "Paladin", "Mage" };
        public static string[] time = { "Round", "Hour", "Minute" };

        public static string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        //public static string path = System.Reflection.Assembly.GetEntryAssembly().Location;

        //Da usare per controllare che la stringa non contenga numeri
        public static bool CheckIsNotNumber(string exam)
        {
            string tString = exam;
            if (tString.Trim() == "") return true;
            for (int i = 0; i < tString.Length; i++)
            {
                if (char.IsNumber(tString[i]))
                {
                    Console.WriteLine("Please enter a valid string");
                    exam = string.Empty;
                    return true;
                }
            }
            return false;
        }

        //Da usare per controllare che la stringa non contega lettere
        public static bool CheckIsANumber(string exam)
        {
            string tString = Convert.ToString(exam);
            if (tString.Trim() == "") return true;
            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                    Console.WriteLine("Please enter a valid number");
                    return true;
                }
            }
            return false;
        }

        //Necessario per leggere da Console più char dei 2048 massimi
        public static string ReadLine()
        {
            Console.WriteLine("Eccoci");
            int READLINE_BUFFER_SIZE = 8019;
            Stream inputStream = Console.OpenStandardInput(READLINE_BUFFER_SIZE);
            byte[] bytes = new byte[READLINE_BUFFER_SIZE];
            int outputLength = inputStream.Read(bytes, 0, READLINE_BUFFER_SIZE);
            char[] chars = Encoding.UTF7.GetChars(bytes, 0, outputLength);
            return new string(chars);
        }

        internal static void ChangePoint()
        {
            throw new NotImplementedException();
        }

        public static char[] SplitChar(string exam)
        {
            char[] response;
            response = exam.ToCharArray();
            return response;
        }

        //Continuare cambiando il punto di mount dei file JSON
        public static void FolderCheckStartUp()
        {
            //path = path.Replace(@"CreateJSON.exe", "");
            Console.WriteLine(path);
            //Codice preso da ReadData.GetAllJSON
            //string[] fileEntries = Directory.GetFiles(path);
            //for (int i = 0; i < fileEntries.Length; i++)
            //{
            //				fileEntries[i] = fileEntries[i].Replace(path, "");
            //				fileEntries[i] = fileEntries[i].Replace(".json", "");
            //				//Console.WriteLine(fileEntries[i]);
            //				Console.WriteLine("." + i + "\t" + fileEntries[i]);
            //}
            string[] fileFolder = Directory.GetDirectories(path);
            if (fileFolder.Length != 0)
            {
                foreach (string str in fileFolder)
                {
                    //Console.WriteLine(str);
                    //Console.WriteLine(path + @"\FolderJSON");
                    if (str == (path + @"\FolderJSON"))
                    {
                        //Console.WriteLine("Folder found!");
                    }
                    else
                    {
                        //Console.WriteLine("No directory found!");
                        //Console.WriteLine("Creation directory on going");
                        Directory.CreateDirectory(path + @"\FolderJSON");
                    }
                }
            }
            else
            {
                //Console.WriteLine("No directory found!");
                //Console.WriteLine("Creation directory on going");
                Directory.CreateDirectory(path + @"\FolderJSON");
            }
            //Program.MenuStart();
        }

        public static void GetTimeType()
        {
            for (int i = 0; i < time.Length; i++)
            {
                Console.Write(i + ". - " + time[i]);
            }

            //foreach (string str in time){
            //				Console.Write(str + "\n");
            //}
        }

        //public static class 
        //{
        //public string nome { get; set; }
        //public string job { get; set; }
        //public int actionTime { get; set; }
        //public string descr { get; set; }
        //public List<string> role { get; set; }
        //}
    }
}
