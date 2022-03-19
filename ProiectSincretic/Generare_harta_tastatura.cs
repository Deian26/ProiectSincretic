using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProiectSincretic
{
    public partial class Generare_harta_tastatura : Form
    {
        //variabile
        int language; //limba
        int theme; //tema aplicatie
        List<string[]>[] err_message; //mesaje de eroare
        string err_filename = "..//..//..//Fisiere//MesajeEroare_ro.xml";//nume fisier mesaje de eroare
        bool ERR1 = false; //flag de eroare global - textBox nume tara
        bool ERR2 = false; //flag de eroare global - textBox denumire culoare
        string[] tari = new string[197];//lista tarilor din care se poate face selectia la generarea hartii
        string[] culori = new string[10];//lista culorilor din care se poate face selectia la generarea hartii

        int NrCulori = 0;
        string Culoare ="";
        int NrTari = 0;
        string Tara = "";

        Color default_background_colour =Color.White;
        Color err_background_colour=Color.PaleVioletRed;

        //load/close form
        private void Generare_harta_tastatura_Load(object sender, EventArgs e)
        {
            ERR1 = false;
            ERR2 = false;
            this.FormClosing += Generare_harta_tastatura_FormClosing;
        }

        private void Generare_harta_tastatura_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //resetare flags
            ERR1 = false;
            ERR2 = false;

            //revenire la culorile de fundal prestabilite (default)
            textBox_NrTari_B1.BackColor = default_background_colour;
            textBox_NumeTari_B1.BackColor = default_background_colour;
            textBox_NrCulori_B1.BackColor = default_background_colour;
            textBox_Culori_B1.BackColor = default_background_colour;
            listBox_ListaTari_B1.BackColor = default_background_colour;

            //resetare text controls
            textBox_NrTari_B1.Text ="";
            textBox_NumeTari_B1.Text = "";
            textBox_NrCulori_B1.Text = "";
            textBox_Culori_B1.Text = "";
            listBox_ListaTari_B1.Text = "";

            //stergere elemente listBox tari
            listBox_ListaTari_B1.Items.Clear();
        }


        //functii utilitare
        //incarca mesajele de eroare in lista err_message, in functie de limba
        private void IncarcareMesajeEroare(List<string[]>[] err_message, string err_filename)
        {
            //#TO IMPLEMENT#

            //List<string> buf;

            //XmlDocument fin = new XmlDocument();
            //fin.Load(err_filename);
            //foreach(XmlNode node in fin.DocumentElement.ChildNodes[2].ChildNodes[1])


            //buf = System.IO.File.ReadLines(err_filename).ToList<string>();

        }

        private bool ValidCountryName(string name)
        {
            if (name == "") return false;
            if (name.ElementAt(0) < 'A' || name.ElementAt(0) > 'Z') return false;

            return true;
        }


        //constructori
        public Generare_harta_tastatura(int limba, int theme)
        {
            //optiuni
            this.language = language;
            this.theme = theme;

            //mesaje de eroare
            IncarcareMesajeEroare(err_message, err_filename);


            //apeluri functii
            InitializeComponent();
        }


        //evenimente (handlers)

        //evenimente - controls
        //preluarea numarului de tari
        private void textBox_NrTari_B1_TextChanged(object sender, EventArgs e)
        {
            bool err = false;

            err = !int.TryParse(textBox_NrTari_B1.Text, out NrTari);
            if (err)
            {
                NrTari = 0;
                //dev: display error message
                //MessageBox.Show("");
                if (textBox_NrTari_B1.Text != "") textBox_NrTari_B1.BackColor = err_background_colour;
            }
            else
            {
                textBox_NrTari_B1.BackColor = default_background_colour;
            }

        }

        //preluarea numelor tarilor (optional)
        private void textBox_NumeTari_TextChanged(object sender, EventArgs e)
        {

        }

        //preluarea numarului de culori
        private void textBox_NrCulori_B1_TextChanged(object sender, EventArgs e)
        {
            bool err = false;

            err = !int.TryParse(textBox_NrCulori_B1.Text, out NrCulori);
            if (err)
            {
                NrCulori = 0;
                //dev: display error message
                //MessageBox.Show("");
                if (textBox_NrCulori_B1.Text != "") textBox_NrCulori_B1.BackColor = err_background_colour;
            }
            else
            {
                textBox_NrCulori_B1.BackColor = default_background_colour;
            }
        }

        //preluarea numelor culorilor (optional)
        private void textBox_Culori_B1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_GenerareHarta_Click(object sender, EventArgs e)
        {
            //#TO CHANGE WHEN NEXT FORM IS READY TO BE IMPLEMENTED#

            /*dev: constructor call to next form to be implemented here*/   //transmitere date catre algoritmul de generare a hartii
            
            this.Close(); //inchidere form ; dev: to delete or change to transition to next form ('afisare harta' probably)
        }

        //adaugare tara in listBox
        private void button_AdaugareTara_B1_Click(object sender, EventArgs e)
        {
            tari[0] = "Romania";

            ERR1 = false;
            if (ValidCountryName(textBox_NumeTari_B1.Text) == false)
            {
                ERR1 = true;
                textBox_NumeTari_B1.BackColor = err_background_colour;
            }

            if (!tari.Contains(textBox_NumeTari_B1.Text) && textBox_NumeTari_B1.Text != "")
            {
                ERR1 = true;
                textBox_NumeTari_B1.BackColor = err_background_colour;
            }
            else
            {
                Tara = textBox_NumeTari_B1.Text;
                textBox_NumeTari_B1.BackColor = default_background_colour;
                if(Tara!="") listBox_ListaTari_B1.Items.Add(Tara);
            }
        }

        //adaugare culoare in listBox
        private void button_AdaugareCuloare_B1_Click(object sender, EventArgs e)
        {
            if (ValidCountryName(textBox_NumeTari_B1.Text) == false)
            {
                ERR2 = true;
                textBox_Culori_B1.BackColor = err_background_colour;
            }

            if (!culori.Contains(textBox_NumeTari_B1.Text) && textBox_NumeTari_B1.Text != "")
            {
                ERR2 = true;
            }
            else
            {
                Culoare = textBox_Culori_B1.Text;
                textBox_Culori_B1.BackColor = default_background_colour;
                if(Culoare!="") listBox_ListaCulori_B1.Items.Add(Culoare);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); //intoarcere la meniul principal

        }
    }
}
