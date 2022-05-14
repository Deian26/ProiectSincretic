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
using Main;

namespace ProiectSincretic
{
    public partial class Harti_recente : Form
    {
        string savefile_path = "..//..//..//Fisiere//RecentMaps.xml";
        string language, theme, languages_filename, themes_filename,err_filename;
        List<Utility.err> err_messages = new List<Utility.err>();
        List<Utility.language> language_texts= new List<Utility.language>();
        bool ERR = false;
        public Harti_recente(string language, string theme, string languages_filename, string themes_filename, string err_filename, Point location)
        {
            //locatie form
            this.Location = location;

            this.language = language;
            this.theme = theme;
            this.languages_filename = languages_filename;
            this.themes_filename = themes_filename;
            this.err_filename = err_filename;

            InitializeComponent();
        }

        private void Harti_recente_Load(object sender, EventArgs e)
        {
            Utility ut = new Utility();
            this.FormClosing += Harti_recente_FormClosing;
            //locatie form
            this.Location = new Point(150, 150);

            //incarcare harti din memorie
            XmlDocument xml = new XmlDocument();
            xml.Load(savefile_path);

            //setare preferinte
            //traduceri
            ut.LoadTranslations(language,languages_filename,language_texts);
            ut.RewriteTexts(language_texts,this);
            //theme
            ut.ChangeTheme(theme,themes_filename,this);
            //#TO IMPLEMENT#
            //foreach(XmlNode node in xml.DocumentElement.ChildNodes)
                //dev: populate map struct vector and add elements as comboBox items for comboBox_HartiRecente_B2
        }
        
        private void button_Iesire_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close(); //intoarcere la meniul principal
        }

        private void Harti_recente_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //#TO IMPLEMENT#
            //dev: add call to form 'afisare harta' when that form is done
            
            //resetare variabile
            ERR = false;
        }

        //selectare harta
        private void comboBox_HartiRecente_B3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //incarcare harta selectata
        private void button_IncarcareHarta_B3_Click(object sender, EventArgs e)
        {
            //#TO IMPLEMENT#
            //dev: load map
            this.Close();
        }
    }
}
