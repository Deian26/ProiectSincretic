using System.Xml;
using Main;

namespace ProiectSincretic
{

    //clase & structuri


    public partial class Meniu_principal : Form
    {
        //variabile

        //optiuni
        string language = "RO",
            theme = "DEFAULT";
        //timp
        //pentru timer_TimpExecutieAplicatie si toolStripStatusLabel_Timp
        int h = 0,
            min = 0,
            sec = 0;


        //#TO IMPLEMENT .XML FILE DATA EXTRACTION FOR VARIOUS INFORMATION#
        //versiuni
        string stringVersions_Title1 = "Versiune curentã:\n";
        string stringVersions_Title2 = "Versiuni anterioare:\n";
        
        //dezvoltare (roadmap)
        string stringDevelopment_Title1 = "Dezvoltare - ROADMAP\n";

        //algoritm
        string stringAlgorithm_Title1 = "Algoritmul utilizat\n";

        //contact
        string stringContact_Title1 = "Contact\n";

        //lista informatii software
        List<string> SoftwareInfo = new List<string>();
        
        //forms
        Generare_harta_tastatura B1;
        Harti_recente B3;

        //date extrase din fisierele auxiliare
        List<Utilitary.err> err_message = new List<Utilitary.err>(); //mesaje de eroare
        List<Utilitary.language> language_texts = new List<Utilitary.language>(); //text afisat (in functie de limba aleasa)
        List<string> language_list = new List<string>(); //lista prescurtarilor numelor traducerilor (RO, EN etc.)
        List<string> theme_list = new List<string>(); //lista prescurtarilor numelor temelor de aplicatie

        //filepaths
        string err_filename = "..//..//..//Fisiere//Errors.xml";//cale fisier mesaje de eroare
        string languages_filename = "..//..//..//Fisiere//Languages.xml";//cale fisier traduceri
        string SoftwareInfo_filename = "..//..//..//Fisiere//SoftwareInfo.xml";//cale fisier SoftwareInfo.xml
        string themes_filename = "..//..//..//Fisiere//Themes.xml";//cale fisier Themes.xml
        

        //load form
        private void Meniu_principal_Load(object sender, EventArgs e)
        {
            Utilitary ut = new Utilitary();

            //locatie form
            this.Location = new Point(150, 150);

            //incarcare date din fisiere auxiliare
            //Software Info
            ut.LoadSoftwareInfo(SoftwareInfo_filename, SoftwareInfo);

            //mesaje de eroare
            ut.LoadErrorMessages(err_filename,err_message);

            //limba
            if(comboBox_Language.Items.Count==0) ut.LoadLanguageList(languages_filename,language_list, comboBox_Language);
            comboBox_Language.SelectedItem = comboBox_Language.Items[0];
            ut.LoadTranslations(language,languages_filename, language_texts);
            ut.RewriteTexts(language_texts, this);

            //theme
            if (comboBox_Theme.Items.Count == 0) ut.LoadThemeList(themes_filename, theme_list, comboBox_Theme);
            ut.ChangeTheme(theme, themes_filename, this);
            comboBox_Theme.SelectedItem = comboBox_Theme.Items[0];

            //forms (initializare prin constructori)
            B1 = new Generare_harta_tastatura(language, theme, languages_filename, themes_filename, err_filename);
            B3 = new Harti_recente(language, theme, languages_filename, themes_filename, err_filename);

            //adaugare form event handlers
            B1.FormClosing += B1_FormClosing;
            B1.FormClosed += B1_FormClosed;

            B3.FormClosing += B3_FormClosing;
        }

        //tratare evenimente
        //constructori
        public Meniu_principal()
        {
            InitializeComponent();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            //initializare procese de fundal si setari
            //timer executie aplicatie
            timer_TimpExecutieAplicatie.Start();
            timer_TimpExecutieAplicatie.Interval = 1000; //ms

        }

        private void B1_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //dev: to change here when form 'afisare harta' is implemented
            /* if(!AfisareHarta.Visible) */
            this.Show();
        }

        //evenimente (handlers)

        private void B3_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //dev: to change here when form 'afisare harta' is implemented
            /* if(!AfisareHarta.Visible) */ this.Show();

        }
        
        private void B1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //dev: to change here when form 'afisare harta' is implemented
            /* if(!AfisareHarta.Visible)*/
            
            this.Show(); 
        }

        //evenimente - controls
        //actiuni asociate butonului de afisare a versiunilor aplicatiei ()
        private void button_Versiuni_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringVersions_Title1 + SoftwareInfo[0]+stringVersions_Title2+ SoftwareInfo[1]);
        }
        
        //actiuni asociate butonului de activare a modului Dezvoltator ()
        private void button_Dev_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringDevelopment_Title1+ SoftwareInfo[2]);
        }

        //actiuni asociate butonului de afisare a algoritmului ()
        private void button_Algoritm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringAlgorithm_Title1 + SoftwareInfo[3]);
        }

        //actiuni asociate butonului de contact ()
        private void button_Contact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SoftwareInfo[4]);
        }

        //incarcarea unei harti generate recent
        private void button_IncarcareHartaRecenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            B3.ShowDialog();
        }

        private void comboBox_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            language = language_list[comboBox_Language.SelectedIndex];
            this.OnLoad(null);
        }

        private void comboBox_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            theme = theme_list[comboBox_Theme.SelectedIndex];
            this.OnLoad(null);
        }

        private void button_GenerareHartaDinFisier_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        //actiuni asociate butonului de generare harta noua de la tastatura (B1)
        private void button_GenerareHartaTastatura_Click(object sender, EventArgs e)
        {
            this.Hide();

            //B1.Location = new Point(M0_x,M0_y); //dev: to implement
            B1.ShowDialog();

        }


        //actiuni asociate butonului de iesire ()
        private void button_Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*modifica variabilele corespunzatoare timpului petrecut in aplicatie (ore,min,sec) si 
        actualizeaza afisajul din bara de stare
            */
        private void timer_TimpExecutieAplicatie_Tick(object sender, EventArgs e)
        {
            string H, Min, Sec;
            
            sec++;

            if (sec >= 60)
            {
                min++;
                sec = 0;
            }
            if (min >= 60)
            {
                min = 0;
                h++;
            }
            H=h.ToString();
            if (h < 10) H = "0" + H;

            Min = min.ToString();
            if (min < 10) Min = "0" + Min;

            Sec = sec.ToString();
            if (sec < 10) Sec = "0" + Sec;

            toolStripStatusLabel_Timp.Text =H+":"+Min+":"+Sec;
        }


    }
}