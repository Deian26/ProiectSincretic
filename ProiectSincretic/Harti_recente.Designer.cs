namespace ProiectSincretic
{
    partial class Harti_recente
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
            this.button_IncarcareHarta_B3 = new System.Windows.Forms.Button();
            this.label_Titlu_B3 = new System.Windows.Forms.Label();
            this.comboBox_HartiRecente_B3 = new System.Windows.Forms.ComboBox();
            this.button_Iesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_IncarcareHarta_B3
            // 
            this.button_IncarcareHarta_B3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_IncarcareHarta_B3.Location = new System.Drawing.Point(94, 104);
            this.button_IncarcareHarta_B3.Name = "button_IncarcareHarta_B3";
            this.button_IncarcareHarta_B3.Size = new System.Drawing.Size(190, 29);
            this.button_IncarcareHarta_B3.TabIndex = 0;
            this.button_IncarcareHarta_B3.Text = "Încărcare hartă";
            this.button_IncarcareHarta_B3.UseVisualStyleBackColor = true;
            this.button_IncarcareHarta_B3.Click += new System.EventHandler(this.button_IncarcareHarta_B3_Click);
            // 
            // label_Titlu_B3
            // 
            this.label_Titlu_B3.AutoSize = true;
            this.label_Titlu_B3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Titlu_B3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Titlu_B3.Location = new System.Drawing.Point(12, 57);
            this.label_Titlu_B3.Name = "label_Titlu_B3";
            this.label_Titlu_B3.Size = new System.Drawing.Size(186, 23);
            this.label_Titlu_B3.TabIndex = 1;
            this.label_Titlu_B3.Text = "Selectați harta:";
            // 
            // comboBox_HartiRecente_B3
            // 
            this.comboBox_HartiRecente_B3.FormattingEnabled = true;
            this.comboBox_HartiRecente_B3.Location = new System.Drawing.Point(204, 54);
            this.comboBox_HartiRecente_B3.Name = "comboBox_HartiRecente_B3";
            this.comboBox_HartiRecente_B3.Size = new System.Drawing.Size(151, 26);
            this.comboBox_HartiRecente_B3.TabIndex = 2;
            this.comboBox_HartiRecente_B3.SelectedIndexChanged += new System.EventHandler(this.comboBox_HartiRecente_B3_SelectedIndexChanged);
            // 
            // button_Iesire
            // 
            this.button_Iesire.BackColor = System.Drawing.Color.LavenderBlush;
            this.button_Iesire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Iesire.Location = new System.Drawing.Point(12, 11);
            this.button_Iesire.Name = "button_Iesire";
            this.button_Iesire.Size = new System.Drawing.Size(94, 29);
            this.button_Iesire.TabIndex = 3;
            this.button_Iesire.Text = "Înapoi";
            this.button_Iesire.UseVisualStyleBackColor = false;
            this.button_Iesire.Click += new System.EventHandler(this.button_Iesire_Click_1);
            // 
            // Harti_recente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 157);
            this.Controls.Add(this.button_Iesire);
            this.Controls.Add(this.comboBox_HartiRecente_B3);
            this.Controls.Add(this.label_Titlu_B3);
            this.Controls.Add(this.button_IncarcareHarta_B3);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Harti_recente";
            this.Text = "Hărți recente";
            this.Load += new System.EventHandler(this.Harti_recente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_IncarcareHarta_B3;
        private Label label_Titlu_B3;
        private ComboBox comboBox_HartiRecente_B3;
        private Button button_Iesire;
    }
}