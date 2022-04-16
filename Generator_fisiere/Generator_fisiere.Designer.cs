namespace Generator_fisiere
{
    partial class Generator_fisiere
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Titlu = new System.Windows.Forms.Label();
            this.label_Desc = new System.Windows.Forms.Label();
            this.groupBox_Date = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Actualizare_lista_culori = new System.Windows.Forms.Button();
            this.button_Actualizare_lista_tari = new System.Windows.Forms.Button();
            this.groupBox_Preferinte = new System.Windows.Forms.GroupBox();
            this.button_Actualizare_lista_traduceri = new System.Windows.Forms.Button();
            this.button_Actualizare_lista_themes = new System.Windows.Forms.Button();
            this.button_Iesire = new System.Windows.Forms.Button();
            this.statusStrip_Bara_de_stare = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Bara_de_stare_Text = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Bara_de_stare_Ultima_actualizare = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Generare_fisiere = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_Preferinte.SuspendLayout();
            this.statusStrip_Bara_de_stare.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Titlu.Location = new System.Drawing.Point(173, 9);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(315, 33);
            this.label_Titlu.TabIndex = 0;
            this.label_Titlu.Text = "Generator de fișiere";
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Desc.Location = new System.Drawing.Point(28, 70);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(560, 36);
            this.label_Desc.TabIndex = 1;
            this.label_Desc.Text = "    Această aplicație are rolul de a genera/actualiza fișiere pentru \r\naplicația " +
    "de generare a hărții.";
            // 
            // groupBox_Date
            // 
            this.groupBox_Date.Location = new System.Drawing.Point(12, 139);
            this.groupBox_Date.Name = "groupBox_Date";
            this.groupBox_Date.Size = new System.Drawing.Size(250, 125);
            this.groupBox_Date.TabIndex = 2;
            this.groupBox_Date.TabStop = false;
            this.groupBox_Date.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Actualizare_lista_culori);
            this.groupBox1.Controls.Add(this.button_Actualizare_lista_tari);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date";
            // 
            // button_Actualizare_lista_culori
            // 
            this.button_Actualizare_lista_culori.Location = new System.Drawing.Point(26, 59);
            this.button_Actualizare_lista_culori.Name = "button_Actualizare_lista_culori";
            this.button_Actualizare_lista_culori.Size = new System.Drawing.Size(224, 29);
            this.button_Actualizare_lista_culori.TabIndex = 1;
            this.button_Actualizare_lista_culori.Text = "Actualizare listă culori";
            this.button_Actualizare_lista_culori.UseVisualStyleBackColor = true;
            // 
            // button_Actualizare_lista_tari
            // 
            this.button_Actualizare_lista_tari.Location = new System.Drawing.Point(26, 24);
            this.button_Actualizare_lista_tari.Name = "button_Actualizare_lista_tari";
            this.button_Actualizare_lista_tari.Size = new System.Drawing.Size(224, 29);
            this.button_Actualizare_lista_tari.TabIndex = 0;
            this.button_Actualizare_lista_tari.Text = "Actualizare listă țări";
            this.button_Actualizare_lista_tari.UseVisualStyleBackColor = true;
            this.button_Actualizare_lista_tari.Click += new System.EventHandler(this.button_Actualizare_lista_tari_Click);
            // 
            // groupBox_Preferinte
            // 
            this.groupBox_Preferinte.Controls.Add(this.button_Actualizare_lista_traduceri);
            this.groupBox_Preferinte.Controls.Add(this.button_Actualizare_lista_themes);
            this.groupBox_Preferinte.Location = new System.Drawing.Point(307, 139);
            this.groupBox_Preferinte.Name = "groupBox_Preferinte";
            this.groupBox_Preferinte.Size = new System.Drawing.Size(281, 125);
            this.groupBox_Preferinte.TabIndex = 3;
            this.groupBox_Preferinte.TabStop = false;
            this.groupBox_Preferinte.Text = "Preferințe";
            // 
            // button_Actualizare_lista_traduceri
            // 
            this.button_Actualizare_lista_traduceri.Location = new System.Drawing.Point(26, 59);
            this.button_Actualizare_lista_traduceri.Name = "button_Actualizare_lista_traduceri";
            this.button_Actualizare_lista_traduceri.Size = new System.Drawing.Size(224, 44);
            this.button_Actualizare_lista_traduceri.TabIndex = 5;
            this.button_Actualizare_lista_traduceri.Text = "Actualizare listă traduceri";
            this.button_Actualizare_lista_traduceri.UseVisualStyleBackColor = true;
            // 
            // button_Actualizare_lista_themes
            // 
            this.button_Actualizare_lista_themes.Location = new System.Drawing.Point(26, 24);
            this.button_Actualizare_lista_themes.Name = "button_Actualizare_lista_themes";
            this.button_Actualizare_lista_themes.Size = new System.Drawing.Size(224, 29);
            this.button_Actualizare_lista_themes.TabIndex = 4;
            this.button_Actualizare_lista_themes.Text = "Actualizare listă teme";
            this.button_Actualizare_lista_themes.UseVisualStyleBackColor = true;
            // 
            // button_Iesire
            // 
            this.button_Iesire.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_Iesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Iesire.Location = new System.Drawing.Point(466, 347);
            this.button_Iesire.Name = "button_Iesire";
            this.button_Iesire.Size = new System.Drawing.Size(122, 29);
            this.button_Iesire.TabIndex = 6;
            this.button_Iesire.Text = "Ieșire";
            this.button_Iesire.UseVisualStyleBackColor = false;
            this.button_Iesire.Click += new System.EventHandler(this.button_Iesire_Click);
            // 
            // statusStrip_Bara_de_stare
            // 
            this.statusStrip_Bara_de_stare.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Bara_de_stare.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Bara_de_stare_Text,
            this.toolStripStatusLabel_Bara_de_stare_Ultima_actualizare});
            this.statusStrip_Bara_de_stare.Location = new System.Drawing.Point(0, 381);
            this.statusStrip_Bara_de_stare.Name = "statusStrip_Bara_de_stare";
            this.statusStrip_Bara_de_stare.Size = new System.Drawing.Size(623, 24);
            this.statusStrip_Bara_de_stare.TabIndex = 7;
            this.statusStrip_Bara_de_stare.Text = "Bară de stare";
            // 
            // toolStripStatusLabel_Bara_de_stare_Text
            // 
            this.toolStripStatusLabel_Bara_de_stare_Text.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel_Bara_de_stare_Text.Name = "toolStripStatusLabel_Bara_de_stare_Text";
            this.toolStripStatusLabel_Bara_de_stare_Text.Size = new System.Drawing.Size(264, 18);
            this.toolStripStatusLabel_Bara_de_stare_Text.Text = "Ultima actualizare a fișierelor:";
            // 
            // toolStripStatusLabel_Bara_de_stare_Ultima_actualizare
            // 
            this.toolStripStatusLabel_Bara_de_stare_Ultima_actualizare.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel_Bara_de_stare_Ultima_actualizare.Name = "toolStripStatusLabel_Bara_de_stare_Ultima_actualizare";
            this.toolStripStatusLabel_Bara_de_stare_Ultima_actualizare.Size = new System.Drawing.Size(168, 18);
            this.toolStripStatusLabel_Bara_de_stare_Ultima_actualizare.Text = "#ULTIMA ACTUALIZARE#";
            // 
            // button_Generare_fisiere
            // 
            this.button_Generare_fisiere.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Generare_fisiere.Location = new System.Drawing.Point(239, 270);
            this.button_Generare_fisiere.Name = "button_Generare_fisiere";
            this.button_Generare_fisiere.Size = new System.Drawing.Size(149, 29);
            this.button_Generare_fisiere.TabIndex = 8;
            this.button_Generare_fisiere.Text = "Generare fișiere";
            this.button_Generare_fisiere.UseVisualStyleBackColor = true;
            // 
            // Generator_fisiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 405);
            this.Controls.Add(this.button_Generare_fisiere);
            this.Controls.Add(this.statusStrip_Bara_de_stare);
            this.Controls.Add(this.button_Iesire);
            this.Controls.Add(this.groupBox_Preferinte);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Date);
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.label_Titlu);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Generator_fisiere";
            this.Text = "Generator de fișiere";
            this.Load += new System.EventHandler(this.Generator_fisiere_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Preferinte.ResumeLayout(false);
            this.statusStrip_Bara_de_stare.ResumeLayout(false);
            this.statusStrip_Bara_de_stare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Titlu;
        private Label label_Desc;
        private GroupBox groupBox_Date;
        private GroupBox groupBox1;
        private Button button_Actualizare_lista_culori;
        private Button button_Actualizare_lista_tari;
        private GroupBox groupBox_Preferinte;
        private Button button_Actualizare_lista_traduceri;
        private Button button_Actualizare_lista_themes;
        private Button button_Iesire;
        private StatusStrip statusStrip_Bara_de_stare;
        private ToolStripStatusLabel toolStripStatusLabel_Bara_de_stare_Text;
        private ToolStripStatusLabel toolStripStatusLabel_Bara_de_stare_Ultima_actualizare;
        private Button button_Generare_fisiere;
    }
}