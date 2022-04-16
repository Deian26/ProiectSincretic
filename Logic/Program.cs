using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectSincretic_1B_alpha_2._0
{
    
    internal class Program
    {
        public class Logic
        {
            static int index;
            static string[] cuv;
            public struct CUL
            {
                public string Nume;
                public List<string> Tari;
            }
            public struct Tara
            {
                public string Nume;
                public List<string> Vecini;
            }
            static bool verif(int i, List<CUL> Culori, List<string> Vecini)
            {//Algoritm verificare daca vecinii unei tari se regaseste in lista de tari a unei culori
                foreach (string j in Culori[i].Tari)
                    foreach (string v in Vecini)
                        if (j.Equals(v))//verifica daca o tara din lista de tari a unei culori se regaseste in vectorul de vecinii a tari actuale
                            return true;
                return false;
            }
            static void setNewColor(List<CUL> Culori, string[] cul, Tara Tara)
            {//Introducerea unei culori in lista de culori

                CUL c = new CUL();
                c.Tari = new List<string>();
                c.Nume = cul[index];
                c.Tari.Add(Tara.Nume);
                Culori.Add(c);
                index++;//index retine ultima pozitie din vectorul de culori pentru a stii ce culoare urmeaza sa fie introdusa in lista
            }
            static void setTara(List<CUL> Culori, Tara tara, string[] cul)
            {//Adaugarea unei tari in lista de tari a unei culori
                int k = Culori.Count;
                int i;
                if (k == 0)//Daca nu exista itemi in lista de culori se initializeaza
                    setNewColor(Culori, cul, tara);
                else
                {
                    for (i = 0; i < k; i++)
                        if (verif(i, Culori, tara.Vecini) == false)//verificare daca nu exista vecini in lista de tari a unei culori
                        {
                            Culori[i].Tari.Add(tara.Nume);//adaugare in lista de tari a culorii
                            break;
                        }
                    if (i == k)
                        setNewColor(Culori, cul, tara);//daca a ajuns la capatul listei de culori si nu a gasit un item pentru care vecinii tari nu se regasesc in lista de tari a culorii, se introduce o noua culoare in lista
                }

            }
            static void citireDate()
            {
                index = 0;
                List<CUL> Culori = new List<CUL>();
                List<Tara> Tari = new List<Tara>();

                string[] cul;//citire culori din fisier
                foreach (var tara in Tari)
                {
                    setTara(Culori, tara, cul);
                }
                for (int i = 0; i < Culori.Count; i++)
                {
                    Console.WriteLine(Culori[i].Nume.ToString());
                    foreach (var t in Culori[i].Tari)
                        Console.WriteLine(t.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            Logic l = new Logic();
            l.citireDate();
        }
    }
}
