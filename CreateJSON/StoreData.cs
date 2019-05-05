//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
//using Newtonsoft.Json.Linq;

namespace CreateJSON
{
    class StoreData
    {

        static string nome;
        static string job;
        //static int actionTime;
        static string description;
        static List<char> role = new List<char>();
        static string[] actionTime = new string[2];
        static List<string> material = new List<string>();

        //Method to collect the information for a new JSON file.
        public static void CreationJSON()
        {
            //Var bool da usare per gli eventuali check
            bool checkInput = true;

            Console.Write("---Inserisci il nome del tuo fantasticissimo oggetto: ");
            nome = Console.ReadLine();
            while (Tool.CheckIsNotNumber(nome))
            {
                nome = Console.ReadLine();
            }
            Console.Write("---Inserisci qui il suo lavoro: ");
            job = Console.ReadLine();
            while (Tool.CheckIsNotNumber(job))
            {
                job = Console.ReadLine();
            }
            Console.Write("---Inserisci qui il suo tempo: ");
            string x = Console.ReadLine();
            while (Tool.CheckIsANumber(x))
            {
                x = Console.ReadLine();
            }

            //actionTime = Convert.ToInt16(x);
            actionTime[0] = x;
            Console.Write("Scegli anche l'unità di misura:");
            Tool.GetTimeType();
            x = Console.ReadLine();
            while (Tool.CheckIsANumber(x))
            {
                x = Console.ReadLine();
            }
            actionTime[1] = Tool.time[Convert.ToInt16(x)];

            Console.WriteLine("---Inserisci qua sotto la sua descrizione, dopo di che premi INVIO");
            description = Tool.ReadLine();

            Console.WriteLine("---Inserisci i numeri delle classi che lo possono usare");
            for (int i = 0; i < Tool.role.Length; i++)
            {
                Console.WriteLine("--- ." + i + " -> " + Tool.role[i]);
            }
            string str = Console.ReadLine();
            //while(Tool.CheckIsANumber(str)){
            while (checkInput)
            {
                checkInput = Tool.CheckIsANumber(str);
                char[] c = str.ToCharArray();
                foreach (char ch in c)
                {
                    role.Add(ch);
                }
            }

            Console.WriteLine("Qauli materiali usa l'incantesimo?");
            Console.WriteLine("Inserisci un ingrediente per riga, digita ENTER per chiudere la riga o '!' in una riga a parte per chiudere la lista");
            // Recipe list
            x = Tool.ReadLine();
            while (x != "!"){
                material.Add(x);
            }


            //char[] comodo = role.ToArray();
            //for (int i = 0; i < comodo.Length; i++) {
            //				Console.WriteLine(comodo[i]);
            //}
            //Creare il nuovo oggetto che sarà il nuovo JSON
            Impiegato obj = new Impiegato();
            obj.nome = nome;
            obj.job = job;
            //obj.actionTime = actionTime;
            obj.actionTime = actionTime;
            obj.descr = description;
            obj.role = role.ToArray();


            StoreJSON(obj);
            //Console.Clear();
            Program.MenuStart();
        }

        //Method to create new JSON file.
        public static void StoreJSON(Impiegato obj)
        {
            //obj.role.InsertRange(0, role);
            //List<MyType> copy = new List<MyType>(original);

            foreach (char ch in obj.role)
            {
                Console.WriteLine(ch);
            }

            //Convertiamo l'oggetto creato in JSON
            string JSONresult = JsonConvert.SerializeObject(obj);

            //Creamo la stringa in cui salvare e il nome del file usando il nome del PG.
            //string path = @"C:\Users\MarcoDiBlasi\Desktop\C# Let's Start\CreateJSON(Console)\JSON\" + obj.nome + ".json";

            string path = Tool.path;
            path = path.Replace(@"CreateJSON.exe", "");
            path = path + obj.nome + ".json";

            //Controlliamo che il file esiste, in caso contrario non sovrascriviamo
            if (File.Exists(path))
            {
                //Eiste un file con lo stesso nome e path, eliminiamo prima di salvare
                File.Delete(path);

                //Procedura per salvare JSON in path indicato
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }

            Program.MenuStart();
        }
    }

}
