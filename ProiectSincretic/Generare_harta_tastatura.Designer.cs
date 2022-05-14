namespace ProiectSincretic
{
    partial class Generare_harta_tastatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Titlu = new System.Windows.Forms.Label();
            this.label_NrTari_B1 = new System.Windows.Forms.Label();
            this.groupBox_IntroducereDate_B1 = new System.Windows.Forms.GroupBox();
            this.label_Note_B1 = new System.Windows.Forms.Label();
            this.textBox_NrCulori_B1 = new System.Windows.Forms.TextBox();
            this.label_NrCulori_B1 = new System.Windows.Forms.Label();
            this.textBox_NrTari_B1 = new System.Windows.Forms.TextBox();
            this.listBox_ListaTari_B1 = new System.Windows.Forms.ListBox();
            this.button_GenerareHarta_B1 = new System.Windows.Forms.Button();
            this.groupBox_DateOptionale_B1 = new System.Windows.Forms.GroupBox();
            this.label_AdaugareCuloare_B1 = new System.Windows.Forms.Label();
            this.button_AdaugareCuloare_B1 = new System.Windows.Forms.Button();
            this.comboBox_Culori_B1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Tari_B1 = new System.Windows.Forms.ComboBox();
            this.label_Culoare_B1 = new System.Windows.Forms.Label();
            this.label_Tara_B1 = new System.Windows.Forms.Label();
            this.listBox_ListaCulori_B1 = new System.Windows.Forms.ListBox();
            this.label_ListaTariListBox_B1 = new System.Windows.Forms.Label();
            this.label_ListaCuloriListBox_B1 = new System.Windows.Forms.Label();
            this.button_Iesire = new System.Windows.Forms.Button();
            this.checkBox_AfisareHarta_B1 = new System.Windows.Forms.CheckBox();
            this.colorDialog_B1 = new System.Windows.Forms.ColorDialog();
            this.toolTip_Tara_ListaVecini_B1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_GenerareHartaTastatura = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox_IntroducereDate_B1.SuspendLayout();
            this.groupBox_DateOptionale_B1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GenerareHartaTastatura)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Titlu.Location = new System.Drawing.Point(206, 8);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(300, 33);
            this.label_Titlu.TabIndex = 0;
            this.label_Titlu.Text = "Generare hartă nouă";
            // 
            // label_NrTari_B1
            // 
            this.label_NrTari_B1.AutoSize = true;
            this.label_NrTari_B1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NrTari_B1.Location = new System.Drawing.Point(5, 32);
            this.label_NrTari_B1.Name = "label_NrTari_B1";
            this.label_NrTari_B1.Size = new System.Drawing.Size(175, 23);
            this.label_NrTari_B1.TabIndex = 1;
            this.label_NrTari_B1.Text = "Număr de țări*:";
            // 
            // groupBox_IntroducereDate_B1
            // 
            this.groupBox_IntroducereDate_B1.Controls.Add(this.label_Note_B1);
            this.groupBox_IntroducereDate_B1.Controls.Add(this.textBox_NrCulori_B1);
            this.groupBox_IntroducereDate_B1.Controls.Add(this.label_NrCulori_B1);
            this.groupBox_IntroducereDate_B1.Controls.Add(this.textBox_NrTari_B1);
            this.groupBox_IntroducereDate_B1.Controls.Add(this.label_NrTari_B1);
            this.groupBox_IntroducereDate_B1.Location = new System.Drawing.Point(12, 40);
            this.groupBox_IntroducereDate_B1.Name = "groupBox_IntroducereDate_B1";
            this.groupBox_IntroducereDate_B1.Size = new System.Drawing.Size(339, 160);
            this.groupBox_IntroducereDate_B1.TabIndex = 2;
            this.groupBox_IntroducereDate_B1.TabStop = false;
            this.groupBox_IntroducereDate_B1.Text = "Introducere date";
            // 
            // label_Note_B1
            // 
            this.label_Note_B1.AutoSize = true;
            this.label_Note_B1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Note_B1.Location = new System.Drawing.Point(5, 125);
            this.label_Note_B1.Name = "label_Note_B1";
            this.label_Note_B1.Size = new System.Drawing.Size(175, 23);
            this.label_Note_B1.TabIndex = 7;
            this.label_Note_B1.Text = "* - obligatoriu";
            // 
            // textBox_NrCulori_B1
            // 
            this.textBox_NrCulori_B1.Enabled = false;
            this.textBox_NrCulori_B1.Location = new System.Drawing.Point(207, 66);
            this.textBox_NrCulori_B1.Name = "textBox_NrCulori_B1";
            this.textBox_NrCulori_B1.Size = new System.Drawing.Size(125, 25);
            this.textBox_NrCulori_B1.TabIndex = 6;
            this.textBox_NrCulori_B1.TextChanged += new System.EventHandler(this.textBox_NrCulori_B1_TextChanged);
            // 
            // label_NrCulori_B1
            // 
            this.label_NrCulori_B1.AutoSize = true;
            this.label_NrCulori_B1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NrCulori_B1.Location = new System.Drawing.Point(5, 66);
            this.label_NrCulori_B1.Name = "label_NrCulori_B1";
            this.label_NrCulori_B1.Size = new System.Drawing.Size(197, 23);
            this.label_NrCulori_B1.TabIndex = 5;
            this.label_NrCulori_B1.Text = "Număr de culori*:";
            // 
            // textBox_NrTari_B1
            // 
            this.textBox_NrTari_B1.Location = new System.Drawing.Point(208, 32);
            this.textBox_NrTari_B1.Name = "textBox_NrTari_B1";
            this.textBox_NrTari_B1.Size = new System.Drawing.Size(125, 25);
            this.textBox_NrTari_B1.TabIndex = 2;
            this.textBox_NrTari_B1.TextChanged += new System.EventHandler(this.textBox_NrTari_B1_TextChanged);
            // 
            // listBox_ListaTari_B1
            // 
            this.listBox_ListaTari_B1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_ListaTari_B1.FormattingEnabled = true;
            this.listBox_ListaTari_B1.ItemHeight = 18;
            this.listBox_ListaTari_B1.Location = new System.Drawing.Point(12, 242);
            this.listBox_ListaTari_B1.Name = "listBox_ListaTari_B1";
            this.listBox_ListaTari_B1.Size = new System.Drawing.Size(332, 76);
            this.listBox_ListaTari_B1.TabIndex = 3;
            this.listBox_ListaTari_B1.SelectedIndexChanged += new System.EventHandler(this.listBox_ListaTari_B1_SelectedIndexChanged);
            // 
            // button_GenerareHarta_B1
            // 
            this.button_GenerareHarta_B1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_GenerareHarta_B1.Location = new System.Drawing.Point(309, 368);
            this.button_GenerareHarta_B1.Name = "button_GenerareHarta_B1";
            this.button_GenerareHarta_B1.Size = new System.Drawing.Size(94, 30);
            this.button_GenerareHarta_B1.TabIndex = 4;
            this.button_GenerareHarta_B1.Text = "Generare";
            this.button_GenerareHarta_B1.UseVisualStyleBackColor = true;
            this.button_GenerareHarta_B1.Click += new System.EventHandler(this.button_GenerareHarta_Click);
            // 
            // groupBox_DateOptionale_B1
            // 
            this.groupBox_DateOptionale_B1.Controls.Add(this.label_AdaugareCuloare_B1);
            this.groupBox_DateOptionale_B1.Controls.Add(this.button_AdaugareCuloare_B1);
            this.groupBox_DateOptionale_B1.Controls.Add(this.comboBox_Culori_B1);
            this.groupBox_DateOptionale_B1.Controls.Add(this.comboBox_Tari_B1);
            this.groupBox_DateOptionale_B1.Controls.Add(this.label_Culoare_B1);
            this.groupBox_DateOptionale_B1.Controls.Add(this.label_Tara_B1);
            this.groupBox_DateOptionale_B1.Location = new System.Drawing.Point(369, 40);
            this.groupBox_DateOptionale_B1.Name = "groupBox_DateOptionale_B1";
            this.groupBox_DateOptionale_B1.Size = new System.Drawing.Size(324, 160);
            this.groupBox_DateOptionale_B1.TabIndex = 9;
            this.groupBox_DateOptionale_B1.TabStop = false;
            this.groupBox_DateOptionale_B1.Text = "Date țări";
            // 
            // label_AdaugareCuloare_B1
            // 
            this.label_AdaugareCuloare_B1.AutoSize = true;
            this.label_AdaugareCuloare_B1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_AdaugareCuloare_B1.Location = new System.Drawing.Point(6, 126);
            this.label_AdaugareCuloare_B1.Name = "label_AdaugareCuloare_B1";
            this.label_AdaugareCuloare_B1.Size = new System.Drawing.Size(153, 23);
            this.label_AdaugareCuloare_B1.TabIndex = 12;
            this.label_AdaugareCuloare_B1.Text = "Culoare nouă:";
            // 
            // button_AdaugareCuloare_B1
            // 
            this.button_AdaugareCuloare_B1.Location = new System.Drawing.Point(165, 124);
            this.button_AdaugareCuloare_B1.Name = "button_AdaugareCuloare_B1";
            this.button_AdaugareCuloare_B1.Size = new System.Drawing.Size(151, 30);
            this.button_AdaugareCuloare_B1.TabIndex = 11;
            this.button_AdaugareCuloare_B1.Text = "Selectare";
            this.button_AdaugareCuloare_B1.UseVisualStyleBackColor = true;
            this.button_AdaugareCuloare_B1.Click += new System.EventHandler(this.button_AdaugareCuloare_B1_Click);
            // 
            // comboBox_Culori_B1
            // 
            this.comboBox_Culori_B1.FormattingEnabled = true;
            this.comboBox_Culori_B1.Location = new System.Drawing.Point(167, 66);
            this.comboBox_Culori_B1.Name = "comboBox_Culori_B1";
            this.comboBox_Culori_B1.Size = new System.Drawing.Size(151, 26);
            this.comboBox_Culori_B1.TabIndex = 10;
            this.comboBox_Culori_B1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Culori_SelectedIndexChanged);
            // 
            // comboBox_Tari_B1
            // 
            this.comboBox_Tari_B1.FormattingEnabled = true;
            this.comboBox_Tari_B1.Location = new System.Drawing.Point(167, 35);
            this.comboBox_Tari_B1.Name = "comboBox_Tari_B1";
            this.comboBox_Tari_B1.Size = new System.Drawing.Size(151, 26);
            this.comboBox_Tari_B1.TabIndex = 9;
            this.comboBox_Tari_B1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tari_SelectedIndexChanged);
            // 
            // label_Culoare_B1
            // 
            this.label_Culoare_B1.AutoSize = true;
            this.label_Culoare_B1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Culoare_B1.Location = new System.Drawing.Point(6, 68);
            this.label_Culoare_B1.Name = "label_Culoare_B1";
            this.label_Culoare_B1.Size = new System.Drawing.Size(98, 23);
            this.label_Culoare_B1.TabIndex = 8;
            this.label_Culoare_B1.Text = "Culoare:";
            // 
            // label_Tara_B1
            // 
            this.label_Tara_B1.AutoSize = true;
            this.label_Tara_B1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Tara_B1.Location = new System.Drawing.Point(6, 34);
            this.label_Tara_B1.Name = "label_Tara_B1";
            this.label_Tara_B1.Size = new System.Drawing.Size(65, 23);
            this.label_Tara_B1.TabIndex = 7;
            this.label_Tara_B1.Text = "Țară:";
            // 
            // listBox_ListaCulori_B1
            // 
            this.listBox_ListaCulori_B1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_ListaCulori_B1.FormattingEnabled = true;
            this.listBox_ListaCulori_B1.ItemHeight = 18;
            this.listBox_ListaCulori_B1.Location = new System.Drawing.Point(369, 242);
            this.listBox_ListaCulori_B1.Name = "listBox_ListaCulori_B1";
            this.listBox_ListaCulori_B1.Size = new System.Drawing.Size(332, 76);
            this.listBox_ListaCulori_B1.TabIndex = 10;
            // 
            // label_ListaTariListBox_B1
            // 
            this.label_ListaTariListBox_B1.AutoSize = true;
            this.label_ListaTariListBox_B1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ListaTariListBox_B1.Location = new System.Drawing.Point(12, 219);
            this.label_ListaTariListBox_B1.Name = "label_ListaTariListBox_B1";
            this.label_ListaTariListBox_B1.Size = new System.Drawing.Size(219, 23);
            this.label_ListaTariListBox_B1.TabIndex = 11;
            this.label_ListaTariListBox_B1.Text = "Lista țărilor alese";
            // 
            // label_ListaCuloriListBox_B1
            // 
            this.label_ListaCuloriListBox_B1.AutoSize = true;
            this.label_ListaCuloriListBox_B1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ListaCuloriListBox_B1.Location = new System.Drawing.Point(369, 219);
            this.label_ListaCuloriListBox_B1.Name = "label_ListaCuloriListBox_B1";
            this.label_ListaCuloriListBox_B1.Size = new System.Drawing.Size(241, 23);
            this.label_ListaCuloriListBox_B1.TabIndex = 12;
            this.label_ListaCuloriListBox_B1.Text = "Lista culorilor alese";
            // 
            // button_Iesire
            // 
            this.button_Iesire.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_Iesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Iesire.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Iesire.Location = new System.Drawing.Point(12, 8);
            this.button_Iesire.Name = "button_Iesire";
            this.button_Iesire.Size = new System.Drawing.Size(94, 30);
            this.button_Iesire.TabIndex = 13;
            this.button_Iesire.Text = "Înapoi";
            this.button_Iesire.UseVisualStyleBackColor = false;
            this.button_Iesire.Click += new System.EventHandler(this.button_Iesire_Click);
            // 
            // checkBox_AfisareHarta_B1
            // 
            this.checkBox_AfisareHarta_B1.AutoSize = true;
            this.checkBox_AfisareHarta_B1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_AfisareHarta_B1.Location = new System.Drawing.Point(17, 368);
            this.checkBox_AfisareHarta_B1.Name = "checkBox_AfisareHarta_B1";
            this.checkBox_AfisareHarta_B1.Size = new System.Drawing.Size(134, 22);
            this.checkBox_AfisareHarta_B1.TabIndex = 14;
            this.checkBox_AfisareHarta_B1.Text = "Afișare hartă";
            this.checkBox_AfisareHarta_B1.UseVisualStyleBackColor = true;
            this.checkBox_AfisareHarta_B1.CheckedChanged += new System.EventHandler(this.checkBox_AfisareHarta_CheckedChanged);
            // 
            // errorProvider_GenerareHartaTastatura
            // 
            this.errorProvider_GenerareHartaTastatura.ContainerControl = this;
            // 
            // Generare_harta_tastatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 405);
            this.Controls.Add(this.checkBox_AfisareHarta_B1);
            this.Controls.Add(this.button_Iesire);
            this.Controls.Add(this.label_ListaCuloriListBox_B1);
            this.Controls.Add(this.label_ListaTariListBox_B1);
            this.Controls.Add(this.listBox_ListaCulori_B1);
            this.Controls.Add(this.groupBox_DateOptionale_B1);
            this.Controls.Add(this.button_GenerareHarta_B1);
            this.Controls.Add(this.listBox_ListaTari_B1);
            this.Controls.Add(this.groupBox_IntroducereDate_B1);
            this.Controls.Add(this.label_Titlu);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Generare_harta_tastatura";
            this.Text = "Generare hartă";
            this.Load += new System.EventHandler(this.Generare_harta_tastatura_Load);
            this.groupBox_IntroducereDate_B1.ResumeLayout(false);
            this.groupBox_IntroducereDate_B1.PerformLayout();
            this.groupBox_DateOptionale_B1.ResumeLayout(false);
            this.groupBox_DateOptionale_B1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_GenerareHartaTastatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Titlu;
        private Label label_NrTari_B1;
        private GroupBox groupBox_IntroducereDate_B1;
        private TextBox textBox_NrCulori_B1;
        private Label label_NrCulori_B1;
        private TextBox textBox_NrTari_B1;
        private ListBox listBox_ListaTari_B1;
        private Button button_GenerareHarta_B1;
        private GroupBox groupBox_DateOptionale_B1;
        private ListBox listBox_ListaCulori_B1;
        private Label label_ListaTariListBox_B1;
        private Label label_ListaCuloriListBox_B1;
        private Button button_Iesire;
        private CheckBox checkBox_AfisareHarta_B1;
        private ComboBox comboBox_Culori_B1;
        private ComboBox comboBox_Tari_B1;
        private Label label_Culoare_B1;
        private Label label_Tara_B1;
        private ColorDialog colorDialog_B1;
        private Label label_AdaugareCuloare_B1;
        private Button button_AdaugareCuloare_B1;
        private ToolTip toolTip_Tara_ListaVecini_B1;
        private Label label_Note_B1;
        private ErrorProvider errorProvider_GenerareHartaTastatura;
    }
}