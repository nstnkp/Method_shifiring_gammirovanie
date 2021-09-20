using System;
using System.Collections;
namespace ке
{
	public class EmptyClass
	{

		public int chislo;
		public string alp = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
		public char[] mass;
		public int counter = -1;
		public char[] mass2;
		public int[] mass3;
		public int[] mass4;
		public string slovo  { get; set; }
		public int[] massi;
		public string zasifr = "";
		public string des = "";
		public int[] mass67 = new int[6] { 13, 69, 76, 77, 92,25 };
		public char[] massive;

		public void Proverka()
		{
			if (slovo.Length % 2 == 0) { alp = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; }
			if (slovo.Length % 2 != 0) { alp = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя"; }
			if (slovo.Length % 2 != 0) { slovo += " "; mass4 = new int[slovo.Length];}


		}
		public void Gamma()
		{
			

			mass4 = new int[slovo.Length];
			string str="";
					mass = slovo.ToCharArray();
			for (int i = 0; i < mass.Length; i++)
			{	str += mass[i];
				if (str.Length == 2)
				{
					counter++;
					mass3 = new int[2];
					mass2 = str.ToCharArray();
					for (int j = 0; j < mass2.Length; j++)
					{
						mass3[j] = alp.IndexOf(mass2[j]);

					}


					for (int p = 0; p < 1; p++)
					{
						int res = 0;
						Math.DivRem(mass3[1] + massi[counter], alp.Length, out res);
						res = res ^ mass3[0];

						Remove(ref mass2);
						str = new string(mass2) + alp[res%alp.Length];
						counter++;

						mass2 = str.ToCharArray();
						for (int l = 0; l < mass2.Length; l++)
						{
							mass3[l] = alp.IndexOf(mass2[l]);
						}
						 res = 0;
						Math.DivRem(mass3[1] + massi[counter], alp.Length, out res);
						res = res ^ mass3[0];

						Remove(ref mass2);
						str = new string(mass2) + alp[res%alp.Length];
					}
					zasifr += str;
					str = str.Remove(0, 2);

							

				}
				}
			Console.WriteLine(zasifr);					
			Console.ReadKey();
			counter = -1;
			}




		public void Res()
		{
			mass = zasifr.ToCharArray();
			string str = "";
			for (int i = 0; i < mass.Length; i++)
			{
				str += mass[i];
				if (str.Length == 2)
				{
					counter++;
					mass3 = new int[2];
					mass2 = str.ToCharArray();
					for (int j = 0; j < mass2.Length; j++)
					{
						mass3[j] = alp.IndexOf(mass2[j]);

					}
					for (int p = 0; p < 1; p++)
					{
						int res = 0;
						counter = counter + 1;
						Math.DivRem( mass3[0] + massi[counter], alp.Length-1, out res);
						//int v = mass3[0] + massi[counter+1];
						//res=res% alp.Length;
						res = mass3[1]^res;
							//mass4[counter] = res;
						Remove2(ref mass2,1);
						str =alp[res % alp.Length]+ new string(mass2)  ;


						mass2 = str.ToCharArray();
						for (int l = 0; l < mass2.Length; l++)
						{
							mass3[l] = alp.IndexOf(mass2[l]);
						}
						res = 0;
						counter = counter - 1;
						Math.DivRem(mass3[0] + massi[counter], alp.Length, out res);
						res = mass3[1]^res;
						//mass4[counter] = res;
						Remove2(ref mass2,1);
						str = new string(mass2) + alp[res % alp.Length];
						counter++;
						massive = str.ToCharArray();
						Excahge(ref massive);
						str = new string(massive);
					}
					des += str;
					str = str.Remove(0, 2);
				}

			
			}


			Console.WriteLine(des);


		}	















		public void Remove( ref char[] array)
		{
			char[] newArray = new char[array.Length - 1];
			for (int i = 0; i < 0; i++)
			{
				newArray[i] = array[i];
			}
			for (int i = 1; i < array.Length; i++)
			{
				newArray[i - 1] = array[i];

			}
			array = newArray;
		}




		public void Remove2(ref char[] array,int index)
		{
			char[] newArray = new char[array.Length - 1];
			for (int i = 0; i < index; i++)
			{
				newArray[i] = array[i];
			}

			array = newArray;
		}



		public void Excahge(ref char[] arr)
		{
			for (int i = 0; i < arr.Length - 1; i += 2)
			{
				char temp = arr[i];
				arr[i] = arr[i + 1];
				arr[i + 1] = temp;
			}
		}



	






















		public void  PSevra()
		{
			
			Random rand = new Random();
			double first_chislo;
			first_chislo = 14;

			Console.WriteLine(first_chislo);

			int cikl = slovo.Length+1;
			massi = new int[cikl];
			int razmer = Convert.ToString(first_chislo).Length;
			for (int i = 0; i < cikl; i++)
			{



				first_chislo = Math.Pow(first_chislo, 2);

				if (first_chislo.ToString().Length % 2 != first_chislo.ToString().Length % 2)
				{
					first_chislo *= 10;
				}
				if (razmer != first_chislo.ToString().Length)
				{
					first_chislo = Convert.ToDouble(first_chislo.ToString().Substring(first_chislo.ToString().Length / 2 - first_chislo.ToString().Length / 4, razmer));
				}


				massi[i] = Convert.ToInt32(first_chislo);


			}
	
		}
	}
	}
