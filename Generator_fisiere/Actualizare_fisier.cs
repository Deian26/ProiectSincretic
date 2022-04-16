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

namespace Generator_fisiere
{
    //#TO IMPLEMENT#
    //dev: implement classes/structures for serialization/deserialization of .xml files

    public partial class Actualizare_fisier : Form
    {
        public Actualizare_fisier() //fisier = tipul fisierului care trebuie actualizat (traduceri, themes etc.)
        {
            InitializeComponent();
        }

        //variabile
        List<string> language_labels = new List<string>();


        string file_path = "ProiectSincretic//Fisiere//";
        string filename = "";
        //functii utilitare

        //actualizeaza datele despre tari
        private void Actualizare_tari()
        {
            filename ="States.xml";
            XmlDocument xml = new XmlDocument();
            xml.Load(file_path+filename);
            
        }

        //actualizeaza datele despre culori
        private void Actualizare_culori()
        {
            filename = "Colours.xml";
            XmlDocument xml = new XmlDocument();
            xml.Load(file_path + filename);
        }

        //actualizeaza datele despre themes
        private void Actualizare_themes()
        {
            filename = "Themes.xml";
            XmlDocument xml = new XmlDocument();
            xml.Load(file_path + filename);
        }

        //actualizeaza datele despre traduceri
        private void Actualizare_traduceri()
        {
            filename = "Languages.xml";
            XmlDocument xml = new XmlDocument();
            xml.Load(file_path + filename);

        }

        //apeleaza functiile specifice de actualizare a fisierelor
        public void SetareFisier(int fisier)
        {
            //dev: implement error handling

            switch (fisier)
            {
                case 1:
                    this.Actualizare_tari();
                    break;
                case 2:
                    this.Actualizare_culori();
                    break;
                case 3:
                    this.Actualizare_themes();
                    break;
                case 4:
                    this.Actualizare_traduceri();
                    break;

                case 0: //flag error
                    break;
                default://flag error
                    break;
            }


        }

        //event handlers
        private void Actualizare_fisier_Load(object sender, EventArgs e)
        {
            textBox_StatusSalvareFisier_A.Visible = false;
        }

        private void button_Iesire_A_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
