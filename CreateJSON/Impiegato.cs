using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateJSON
{

				class Impiegato
				{
								public string							nome;
								public string							job;
								public string[]					actionTime;
								public string							descr;
								//public  List<char> role = new List<char>();
								public char[]							role;
								public string[]							material;


								public void GetValueAll(){
												Console.WriteLine(".1 -> Nome:" + this.nome);
												Console.WriteLine(".2 -> Job: " + this.job);
												//Console.WriteLine(".3 -> Action time: " + this.actionTime);
												Console.WriteLine(".3 -> Action time: " + actionTime[0] + " " + actionTime[1]);
												Console.WriteLine(".4 ->Descrizione: ");
												Console.Write("\t" + this.descr);
												Console.Write(".5 -> Ruoli: ");

												//Convert id pos role[] to value role[]
												if (role.Length == 0){
																Console.WriteLine("Empty");
												}else{
																foreach (char ch in role)
																{
																				int i = Convert.ToInt16(Char.GetNumericValue(ch));
																				Console.Write(Tool.role[i] + ", ");
																}
												}
												Console.WriteLine("\n");
								}


				}
}
