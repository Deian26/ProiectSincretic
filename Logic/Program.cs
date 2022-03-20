using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
//Alpha version
namespace Logic
{
    
    internal class Program
    {
        static int index;
        static string[] cuv;
        static string Tara;
        public struct CUL
        {
            public string Nume;
            public List <string> Tari;
        }
        static bool verif(int i, List<CUL>Culori, List<string>Vecini)
        {//Algoritm verificare daca vecinii unei tari se regaseste in lista de tari a unei culori
            foreach(string j in Culori[i].Tari)
                foreach(string v in Vecini)
                    if(j.Equals(v))//verifica daca o tara din lista de tari a unei culori se regaseste in vectorul de vecinii a tari actuale
                        return true;
            return false;
        }
        static void setNewColor(List<CUL>Culori, string[] cul, string Tara)
        {//Introducerea unei culori in lista de culori

            CUL c=new CUL();
            c.Tari=new List<string>();
            c.Nume = cul[index];
            c.Tari.Add(Tara);
            Culori.Add(c);
            index++;//index retine ultima pozitie din vectorul de culori pentru a stii ce culoare urmeaza sa fie introdusa in lista
        } 
        static void setTara(List<CUL>Culori, List<string>Vecini, string Tara, string[] cul)
        {//Adaugarea unei tari in lista de tari a unei culori
            int k=Culori.Count;
            int i;
            if(k==0)//Daca nu exista itemi in lista de culori se initializeaza
                setNewColor(Culori, cul, Tara);
            else
            {
            for(i=0;i<k;i++)
                if(verif(i, Culori, Vecini)==false)//verificare daca nu exista vecini in lista de tari a unei culori
                    {
                        Culori[i].Tari.Add(Tara);//adaugare in lista de tari a culorii
                        break;
                    }
                if(i==k)
                 setNewColor(Culori, cul, Tara);//daca a ajuns la capatul listei de culori si nu a gasit un item pentru care vecinii tari nu se regasesc in lista de tari a culorii, se introduce o noua culoare in lista
            }

        }
       static void citireDate()
        {
            index=0;
            List<CUL>Culori=new List<CUL>();
            List<string>Vecini=new List<string>();

            string[] cul=System.IO.File.ReadAllLines(@"C:\Users\alini\Source\Repos\Deian26\ProiectSincretic\Logic\Culori.txt");//citire culori din fisier
            string[] Tari=System.IO.File.ReadAllLines(@"C:\Users\alini\Source\Repos\Deian26\ProiectSincretic\Logic\Tara.txt");//citire tari+vecini din fisier
            foreach(string tara in Tari)
            {
                string[] cuv = tara.Split(' ');
                Tara=cuv[0];
                for(int i=1;i<cuv.Length;i++)
                    Vecini.Add(cuv[i]);
                setTara(Culori, Vecini, Tara, cul);
                Vecini.Clear();

            }
            for(int i=0;i<Culori.Count;i++)
            {
                Console.WriteLine(Culori[i].Nume.ToString());
                foreach(var t in Culori[i].Tari)
                    Console.WriteLine(t.ToString());

                
            }
        }
        static void Main(string[] args)
        {
           citireDate();
        }
    }
}