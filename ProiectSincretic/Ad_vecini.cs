using ProiectSincretic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;

namespace Main
{
    public partial class Ad_vecini : Form
    {
        //variabile
        List<string> vecini = new List<string>();
        string tara_curenta,
            languages_filename, themes_filename, err_filename,language;
        List<Utility.language> language_texts = new List<Utility.language>();
        List<Utility.err> err_message = new List<Utility.err>();
        bool ok = false;

        //constructori
        //salvare in lista comboBox-ului comboBox_ListaVecini a tarilor care pot fi selectate drept vecini pentru tara curenta
        public Ad_vecini(List<string> vecini_, string tara_curenta,string language, string languages_filename, string themes_filename, string err_filename, Point location)
        {
            //locatie form
            this.Location = location;

            InitializeComponent();
            this.tara_curenta = tara_curenta;
            this.languages_filename = languages_filename;
            this.language = language;
            this.themes_filename = themes_filename;
            this.err_filename = err_filename;

            foreach(string vec in vecini_)
                if(!vec.Equals(tara_curenta)) vecini.Add(vec);

            comboBox_ListaVecini.Items.AddRange(vecini.ToArray());
        }

        //functii utilitare
        //salveaza datele despre o tara si vecinii sai intr-o instanta a clasei 'Vecini'
        public Utility.Tara setData()
        {
            if (ok == true)
            {
                Utility.Tara aux = new Utility.Tara();
                List<string> vec = new List<string>();

                aux.setTara(this.tara_curenta);

                for(int i=0;i<listBox_ListaVecini.Items.Count;i++)
                    vec.Add(listBox_ListaVecini.Items[i].ToString());

                aux.setVecini(vec);

                return aux;
            }
            else return new Utility.Tara();
        }


        //event handlers
        private void Ad_vecini_Load(object sender, EventArgs e)
        {
            Utility ut = new Utility();
            ok = false;
            //locatie form
            this.Location = new Point(150, 150);
            //setare preferinte
            ut.LoadTranslations(language, languages_filename, language_texts);
            ut.RewriteTexts(language_texts, this);
            ut.LoadErrorMessages(err_filename, err_message);
        }

        //selectare vecini si memorarea acestora in listBox_ListaVecini pentru afisare
        private void comboBox_ListaVecini_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!listBox_ListaVecini.Items.Contains(comboBox_ListaVecini.SelectedItem.ToString())) 
                listBox_ListaVecini.Items.Add(comboBox_ListaVecini.SelectedItem.ToString());
        }

        //ascundere form
        private void button_OK_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Hide();
        }

        private void listBox_ListaVecini_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
