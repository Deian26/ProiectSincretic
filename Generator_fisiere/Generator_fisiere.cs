namespace Generator_fisiere
{
    public partial class Generator_fisiere : Form
    {
        public Generator_fisiere()
        {
            InitializeComponent();
        }
        /*Parametru 'fisier' :
         * 0 - eroare / neinitializat
         * 1 - actualizare lista tari
         * 2 - actualizare lista culori
         * 3 - actualizare lista themes
         * 4 - actualizare lista traduceri
         */

        //variabile
        Actualizare_fisier A = new Actualizare_fisier();
        //functii utilitare

        //event handlers
        private void Generator_fisiere_Load(object sender, EventArgs e)
        {
            A.FormClosed += A_FormClosed;
            A.FormClosing += A_FormClosing;
        }

        private void A_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Actualizare_lista_tari_Click(object sender, EventArgs e)
        {
            this.Hide();
            A.ShowDialog();
        }

        private void A_FormClosing(object? sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}