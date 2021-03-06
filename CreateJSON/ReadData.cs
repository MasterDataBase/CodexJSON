﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CreateJSON
{
    class ReadData
    {
        static int comodoInt;
        //static string path = @"C:\Users\MarcoDiBlasi\Desktop\C# Let's Start\CreateJSON(Console)\JSON\";
        public static string path = Tool.path + @"\FolderJSON";

        public static void GetAllJSON()
        {
            try
            {
                // Console.WriteLine("From ReadData: " + path);

                string[] fileEntries = Directory.GetFiles(path);
                for (int i = 0; i < fileEntries.Length; i++)
                {
                    fileEntries[i] = fileEntries[i].Replace(path, "");
                    fileEntries[i] = fileEntries[i].Replace(".json", "");
                    //Console.WriteLine(fileEntries[i]);
                    Console.WriteLine("." + i + "\t" + fileEntries[i]);
                }

                Console.WriteLine("Digita il numero dell'incantesimi che vuoi consultare: ");
                string x = Console.ReadLine();
                while (Tool.CheckIsANumber(x))
                {
                    x = Console.ReadLine();
                }
                comodoInt = Convert.ToInt16(x);
                OpenJSON(fileEntries[comodoInt]);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.ReadLine();
            }
        }

        public static void OpenJSON(string inc)
        {
            Console.WriteLine("L'inc scelto è...: " + inc);
            string targetJSON = path + inc + ".json";

            //Inizializzare qui per portare avanti
            string result = string.Empty;
            Impiegato obj;

            //Function for read JSON file
            //using (StreamReader r = new StreamReader(targetJSON))
            //{
            //				var json = r.ReadToEnd();
            //				var jobj = JObject.Parse(json);
            //				//foreach (var item in jobj.Properties())
            //				//{
            //				//				item.Value = item.Value.ToString().Replace("v1", "v2");
            //				//}
            //				result = jobj.ToString();
            //				Console.WriteLine(result);
            //}
            //File.WriteAllText(targetJSON, result);
            using (StreamReader r = new StreamReader(targetJSON))
            {
                var json = r.ReadToEnd();
                obj = JsonConvert.DeserializeObject<Impiegato>(json);
                obj.GetValueAll();
            }

            Program.MenuModify(obj);
        }
    }
}

