using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace CreateJSON
{
				
				class Program
				{
								//static string nome;
								//static string job;
								//static int actionTime;
								//static string description;
								//static List<char> role = new List<char>();

								public static void Main(string[] args)
								{
												Console.Title = "Loading...";
												Tool.FolderCheckStartUp();
												MenuStart();
												//StoreData.StoreJSON();
								}

								public static void MenuStart()
								{
												//Console.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));
												Console.Title = "Codex v0.3";
												Console.WriteLine("------   Welcome to the Codex   ------");
												Console.WriteLine("---     Scegli cosa vuoi fare      ---");
												Console.WriteLine("---   1)Crea un nuovo Incantesimo  ---");
												Console.WriteLine("---   2) Leggere un incantesimo    ---");
												//Console.WriteLine("---  4)Cambia posto dove salvare   ---");
												Console.WriteLine("---   3)    Fuggire da qui         ---");
												Console.WriteLine("--------------------------------------");
												while (true)
												{
																switch (Console.ReadLine())
																{
																				case "1":
																								StoreData.CreationJSON();
																								break;
																				case "2":
																								ReadData.GetAllJSON();
																								break;
																				case "3":
																								Environment.Exit(0);
																								break;
																				//case "4":
																				//				Tool.ChangePoint();
																				//				break;
																				default:
																								break;
																}
												}
								}

								public static void MenuModify(Impiegato obj){
												Console.WriteLine("Vuoi modificare l'item o tornare indietro?");
												Console.WriteLine("1 per tornare modificare l'item / 2 per tornare al menu principale");
												while(true){
																switch(Console.ReadLine()){
																				case "1":
																								ModifyData.ModifyJSON(obj);
																								break;
																				case "2":
																								Console.Clear();
																								Program.MenuStart();
																								break;
																				default:
																								break;
																}
												}
								}
								//				static void CreationJSON(){
								//								//Var bool da usare per gli eventuali check
								//								bool checkInput = true;

								//								Console.Write("---Inserisci il nome del tuo fantasticissimo oggetto: ");
								//								nome = Console.ReadLine();
								//								while (Tool.CheckIsNotNumber(nome))
								//								{
								//												nome = Console.ReadLine();
								//								}
								//								Console.Write("---Inserisci qui il suo lavoro: ");
								//								job = Console.ReadLine();
								//								while (Tool.CheckIsNotNumber(job))
								//								{
								//												job = Console.ReadLine();
								//								}
								//								Console.Write("---Inserisci qui il suo tempo: ");
								//								string x = Console.ReadLine();
								//								while (Tool.CheckIsANumber(x))
								//								{
								//												x = Console.ReadLine();
								//								}
								//								actionTime = Convert.ToInt16(x);
								//								Console.WriteLine("---Inserisci qua sotto la sua descrizione, dopo di che premi INVIO");
								//								description = Tool.ReadLine();

								//								Console.WriteLine("---Inserisci i numeri delle classi che lo possono usare");
								//								for(int i = 0; i < Tool.role.Length; i++){
								//												Console.WriteLine("--- ." + i + " -> " + Tool.role[i]);
								//								}
								//								string str = Console.ReadLine();
								//								//while(Tool.CheckIsANumber(str)){
								//								while(checkInput){
								//												checkInput = Tool.CheckIsANumber(str);
								//												char[] c = str.ToCharArray();
								//												foreach(char ch in c){
								//																role.Add(ch);
								//												}
								//								}
								//								//char[] comodo = role.ToArray();
								//								//for (int i = 0; i < comodo.Length; i++) {
								//								//				Console.WriteLine(comodo[i]);
								//								//}

								//								StoreJSON();
								//								//Console.Clear();
								//								Menu();
								//				}

								//				static void StoreJSON(){
								//								//Creare il nuovo oggetto che sarà il nuovo JSON
								//								Impiegato obj = new Impiegato();
								//								obj.nome								 = nome;
								//								obj.job									 = job;
								//								obj.actionTime		 = actionTime;
								//								obj.descr							 = description;
								//								obj.role = role.ToArray();
								//								//obj.role.InsertRange(0, role);
								//								//List<MyType> copy = new List<MyType>(original);

								//								foreach(char ch in obj.role){
								//												Console.WriteLine(ch);
								//								}

								//								//Convertiamo l'oggetto creato in JSON
								//								string JSONresult = JsonConvert.SerializeObject(obj);

								//								//Creamo la stringa in cui salvare e il nome del file usando il nome del PG.
								//								string path = @"C:\Users\MarcoDiBlasi\Desktop\C# Let's Start\CreateJSON(Console)\JSON\" + obj.nome + ".json";

								//								//Controlliamo che il file esiste, in caso contrario non sovrascriviamo
								//								if (File.Exists(path))
								//								{
								//												//Eiste un file con lo stesso nome e path, eliminiamo prima di salvare
								//												File.Delete(path);

								//												//Procedura per salvare JSON in path indicato
								//												using (var tw = new StreamWriter(path, true))
								//												{
								//																tw.WriteLine(JSONresult.ToString());
								//																tw.Close();
								//												}
								//								}
								//								else if (!File.Exists(path))
								//								{
								//												using (var tw = new StreamWriter(path, true))
								//												{
								//																tw.WriteLine(JSONresult.ToString());
								//																tw.Close();
								//												}
								//								}
								//				}
								//}
				}
}
