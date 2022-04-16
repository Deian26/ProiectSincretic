using Main;
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
    //structura care memoreaza tara curenta si vecinii sai
    public struct Tara
    {
        private string tara;
        private List<string> vecini;

        public void setTara(string tara)
        {
            this.tara= tara;
        }
        public void setVecini(List<string> vecini)
        {
            this.vecini= vecini;
        }

        public string getTara()
        {
            return this.tara;
        }
        public List<string> getVecini()
        {
            return this.vecini;
        }

    };


    public partial class Generare_harta_tastatura : Form
    {

        //variabile
        string language, //limba
               theme, //tema aplicatie
               languages_filename, //cale fisier traduceri
               themes_filename, //cale fisier themes
               err_filename; //cale fisier mesaje de eroare
        bool ERR1 = false; //flag de eroare global - textBox nume tara
        bool ERR2 = false; //flag de eroare global - textBox denumire culoare
        List<string> tari = new List<string>();//lista tarilor din care se poate face selectia la generarea hartii
        List<string> culori = new List<string>();//lista culorilor din care se poate face selectia la generarea hartii
        List<Tara> tara = new List<Tara>();

        List<Utilitary.err> err_message = new List<Utilitary.err>(); //mesaje de eroare
        List<Utilitary.language> language_texts = new List<Utilitary.language>(); //text afisat (in functie de limba aleasa)


        int NrCulori = 0;
        string Culoare ="";
        int NrTari = 0;
        string Tara = "";
        bool afisare = false;
        //comment

        Color default_background_colour =Color.White;
        Color err_background_colour=Color.PaleVioletRed;
        
        //load/close form
        private void Generare_harta_tastatura_Load(object sender, EventArgs e)
        {
            //variabile
            Utilitary ut = new Utilitary();
            //locatie form
            this.Location = new Point(150, 150);
            //resetare flags
            ERR1 = false;
            ERR2 = false;
            this.FormClosing += Generare_harta_tastatura_FormClosing;
            this.FormClosed += Generare_harta_tastatura_FormClosed;
            checkBox_AfisareHarta_B1.Checked = true;

            tari.Add("Romania");
            tari.Add("Republica Moldova");

            comboBox_Tari_B1.Items.AddRange(tari.ToArray());
            comboBox_Culori_B1.Items.AddRange(culori.ToArray());

            //aplicare preferinte
            //traduceri
            ut.LoadTranslations(language,languages_filename,language_texts);
            ut.RewriteTexts(language_texts, this);

            //theme
            ut.ChangeTheme(theme, themes_filename, this);
            ut.LoadErrorMessages(err_filename, err_message);
            //#TO IMPLEMENT#
            //dev: to implement the toolTip for the list of countries (listBox_ListaTari_B1)

        }

        private void Generare_harta_tastatura_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Visible = false;
        }

        private void Generare_harta_tastatura_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            //resetare flags
            ERR1 = false;
            ERR2 = false;

            //revenire la culorile de fundal prestabilite (default)
            textBox_NrTari_B1.BackColor = default_background_colour;
            textBox_NrCulori_B1.BackColor = default_background_colour;
            listBox_ListaTari_B1.BackColor = default_background_colour;

            //resetare text controls
            textBox_NrTari_B1.Text ="";
            textBox_NrCulori_B1.Text = "";
            listBox_ListaTari_B1.Text = "";

            //stergere elemente listBox tari
            listBox_ListaTari_B1.Items.Clear();
            //stergere elemente listBox culori
            listBox_ListaCulori_B1.Items.Clear();

            //resetare lista tari
            tari.Clear();
            comboBox_Tari_B1.Items.Clear();
            //resetare lista culori
            culori.Clear();
            comboBox_Culori_B1.Items.Clear();
        }


        //functii utilitare

        //dev: obsolete function; to be deleted
        private bool ValidCountryName(string name)
        {
            if (name == "") return false;
            if (name.ElementAt(0) < 'A' || name.ElementAt(0) > 'Z') return false;

            return true;
        }


        //constructori
        public Generare_harta_tastatura(string language, string theme, string languages_filename , string themes_filename, string err_filename)
        {
            //optiuni
            this.language = language;
            this.theme = theme;
            this.languages_filename = languages_filename;
            this.themes_filename = themes_filename;
            this.err_filename = err_filename;



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
                //dev: EB1_1: Not a number
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
                //dev: EB1_1: Not a number
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

            //#TO IMPLEMENT#
            //dev: to add colours from listBox_ListaCulori_B1 to List<string> culori
            //culori.AddRange(listBox_ListaCulori_B1.Items.ToString());
            
            
            this.Visible = false;
            this.Close(); //inchidere form ; dev: to delete or change to transition to next form ('afisare harta' probably)
        
            
        
        }

        //true -> harta este salvata in memorie si afisata dupa generare; false -> harta este doar salvata in memorie dupa afisare
        private void checkBox_AfisareHarta_CheckedChanged(object sender, EventArgs e)
        {
            afisare = true;
        }

        //iesire
        private void button_Iesire_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close(); //intoarcere la meniul principal
        }

        //selectare tara
        private void comboBox_Tari_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tara_curenta;

            if (!listBox_ListaTari_B1.Items.Contains(comboBox_Tari_B1.SelectedItem.ToString()))
            {
                listBox_ListaTari_B1.Items.Add(comboBox_Tari_B1.SelectedItem.ToString());
                tara_curenta = listBox_ListaTari_B1.Items[listBox_ListaTari_B1.Items.Count - 1].ToString();
                Ad_vecini ad = new Ad_vecini(tari, tara_curenta,language, languages_filename, themes_filename,err_filename);

                ad.ShowDialog();
                tara.Add(ad.setVecini());
                ad.Dispose();
            }
        }

        //adaugare culoare
        private void button_AdaugareCuloare_B1_Click(object sender, EventArgs e)
        {
            colorDialog_B1.AllowFullOpen=true;
            colorDialog_B1.ShowDialog();
            listBox_ListaCulori_B1.Items.Add(colorDialog_B1.Color);
        }

        private void listBox_ListaTari_B1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //selectare culoare
        private void comboBox_Culori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!listBox_ListaCulori_B1.Items.Contains(comboBox_Culori_B1.SelectedItem.ToString()))
                listBox_ListaCulori_B1.Items.Add(comboBox_Culori_B1.SelectedItem.ToString());
        }

    }
}
