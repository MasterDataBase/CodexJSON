using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateJSON
{
    class ModifyData
    {

        public static void ModifyJSON(Impiegato obj)
        {

            Console.WriteLine("Quale componente vuoi modificare?");
            Console.WriteLine("Digita il nome del campo per selezionarlo: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Hai deciso di cambiare il nome");
                    ChangeName(obj);
                    break;
                case "2":
                    Console.WriteLine("Hai deciso di cambiare il job");
                    ChangeJob(obj);
                    break;
                case "3":
                    Console.WriteLine("Hai deciso di cambiare l'actionTime");
                    ChangeActionTime(obj);
                    break;
                case "4":
                    Console.WriteLine("Hai deciso di cambiare la descrizione");
                    ChangeDescription(obj);
                    break;
                case "5":
                    Console.WriteLine("Hai deciso di cambiare i ruoli");
                    ChangeRole(obj);
                    break;
                default:
                    break;
            }
        }

        private static void ChangeRole(Impiegato obj)
        {
            bool checkInput = true;
            List<char> role = new List<char>();

            Console.WriteLine("Ruoli attuali: ");
            foreach (char ch in obj.role)
            {
                int i = Convert.ToInt16(Char.GetNumericValue(ch));
                Console.Write("\t\t" + Tool.role[i] + ", \n");
            }
            Console.WriteLine("Inserisci tutti i ruoli che possono avere accesso");
            Array.Clear(obj.role, 0, obj.role.Length);
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

            obj.role = role.ToArray();
            obj.GetValueAll();
            StoreData.StoreJSON(obj);
        }

        private static void ChangeDescription(Impiegato obj)
        {
            Console.WriteLine("Descrizione attuale: \t" + obj.descr);
            Console.WriteLine("Inserisci la nuova descrizone");
            obj.descr = Tool.ReadLine();
            obj.GetValueAll();
            StoreData.StoreJSON(obj);
        }

        private static void ChangeActionTime(Impiegato obj)
        {
            Console.WriteLine("ActionTime attuale: \t" + obj.actionTime);
            Console.WriteLine("Inserisci il nuovo ActionTime");
            string x = Console.ReadLine();
            while (Tool.CheckIsANumber(x))
            {
                x = Console.ReadLine();
            }
            //obj.actionTime = Convert.ToInt16(x);
            obj.actionTime[1] = x;
            obj.GetValueAll();
            StoreData.StoreJSON(obj);
        }

        private static void ChangeJob(Impiegato obj)
        {
            Console.WriteLine("Job attuale: \t" + obj.job);
            Console.WriteLine("Inserisci il nuovo Job");
            string x = Console.ReadLine();
            while (Tool.CheckIsNotNumber(x))
            {
                x = Console.ReadLine();
            }
            obj.job = x;
            obj.GetValueAll();
            StoreData.StoreJSON(obj);
        }

        private static void ChangeName(Impiegato obj)
        {
            Console.WriteLine("Nome attuale: \t" + obj.nome);
            Console.WriteLine("Inserisci il nuovo nome");
            string x = Console.ReadLine();
            while (Tool.CheckIsNotNumber(x))
            {
                x = Console.ReadLine();
            }
            obj.nome = x;
            obj.GetValueAll();
            StoreData.StoreJSON(obj);
        }
    }
}
