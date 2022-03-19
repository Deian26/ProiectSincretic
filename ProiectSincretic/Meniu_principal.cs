namespace ProiectSincretic
{
    public partial class Meniu_principal : Form
    {
        //variabile

        //optiuni
        int language = 0, // 0 - RO, 1 - EN
            theme = 0; //0 - light, 1 - dark
        //timp
        //pentru timer_TimpExecutieAplicatie si toolStripStatusLabel_Timp
        int h = 0,
            min = 0,
            sec = 0;
        //versiuni
        string stringPreviousVersions = " ~\n"; //adaugare versiuni: public Meniu_principal()
        string stringCurrentVersion = " V0.1 CCO\n";
        string[] strVersions_Title1 = { "Versiuni anterioare:\n", "Previous versions:\n" };
        string[] strVersions_Title2 = { "Versiune curentã:\n", "Current version:\n" };
        //contact
        string stringContact = "E-mail:\nE-mail1\ndeian.trif@student.upt.ro\n";
        //forms
        Generare_harta_tastatura B1;

        //tratare evenimente
        //constructori
        public Meniu_principal()
        {
            InitializeComponent();

            //initializare procese de fundal si setari
            //timer executie aplicatie
            timer_TimpExecutieAplicatie.Start();
            timer_TimpExecutieAplicatie.Interval = 1000; //ms
            //limba

            //theme

            //forms (initializare prin constructori)
            B1 = new Generare_harta_tastatura(language, theme);
            //adaugare form event handlers
            B1.FormClosing += B1_FormClosing;

        }
        //evenimente (handlers)
        private void B1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //dev: to change here when form 'afisare harta' is implemented
            /* if(!AfisareHarta.Visible) */ this.Show(); 
        }

        //evenimente - controls
        //actiuni asociate butonului de afisare a versiunilor aplicatiei ()
        private void button_Versiuni_Click(object sender, EventArgs e)
        {
            MessageBox.Show(strVersions_Title1[language]+stringPreviousVersions+strVersions_Title2[language]+stringCurrentVersion);
        }
        
        //actiuni asociate butonului de activare a modului Dezvoltator ()
        private void button_Dev_Click(object sender, EventArgs e)
        {

        }

        //actiuni asociate butonului de afisare a algoritmului ()
        private void button_Algoritm_Click(object sender, EventArgs e)
        {

        }

        //actiuni asociate butonului de contact ()
        private void button_Contact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringContact);
        }

        //actiuni asociate butonului de generare harta noua de la tastatura (B1)
        private void button_GenerareHartaTastatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            B1.ShowDialog();

        }

        //actiuni asociate butonului de tema aplicatie ()
        private void button_Theme_Click(object sender, EventArgs e)
        {

        }

        //actiuni asociate butonului de iesire ()
        private void button_Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
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