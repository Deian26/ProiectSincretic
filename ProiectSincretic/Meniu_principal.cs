namespace ProiectSincretic
{
    public partial class Meniu_principal : Form
    {
        //variabile
        //timp
        //pentru timer_TimpExecutieAplicatie si toolStripStatusLabel_Timp
        int ore=0, 
            min=0,
            sec=0;
        //versiuni
        string stringVersiuni = "V0.1 CCO\n"; //adaugare versiuni: public Meniu_principal()
        //contact
        string stringContact = "E-mail:\nE-mail1\ndeian.trif@student.upt.ro\n";

        public Meniu_principal()
        {
            InitializeComponent();

            //initializare procese de fundal
            //timer executie aplicatie
            timer_TimpExecutieAplicatie.Start();
            timer_TimpExecutieAplicatie.Interval = 1000; //ms

        }

        private void button_Versiuni_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Dev_Click(object sender, EventArgs e)
        {

        }

        private void button_Algoritm_Click(object sender, EventArgs e)
        {

        }

        private void button_Contact_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringContact);
        }

        private void button_GenerareHartaTastatura_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_Theme_Click(object sender, EventArgs e)
        {

        }

        private void button_Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_TimpExecutieAplicatie_Tick(object sender, EventArgs e)
        {
            string Ore, Min, Sec;
            
            sec++;

            if (sec >= 60)
            {
                min++;
                sec = 0;
            }
            if (min >= 60)
            {
                min = 0;
                ore++;
            }
            Ore=ore.ToString();
            if (ore < 10) Ore = "0" + Ore;

            Min = min.ToString();
            if (min < 10) Min = "0" + Min;

            Sec = sec.ToString();
            if (sec < 10) Sec = "0" + Sec;

            toolStripStatusLabel_Timp.Text =Ore+":"+Min+":"+Sec;
        }
    }
}