namespace Main
{
    partial class Ad_vecini
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
            this.comboBox_ListaVecini = new System.Windows.Forms.ComboBox();
            this.listBox_ListaVecini = new System.Windows.Forms.ListBox();
            this.label_SelectareVecini = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_ListaVecini
            // 
            this.comboBox_ListaVecini.FormattingEnabled = true;
            this.comboBox_ListaVecini.Location = new System.Drawing.Point(215, 30);
            this.comboBox_ListaVecini.Name = "comboBox_ListaVecini";
            this.comboBox_ListaVecini.Size = new System.Drawing.Size(204, 26);
            this.comboBox_ListaVecini.TabIndex = 0;
            this.comboBox_ListaVecini.SelectedIndexChanged += new System.EventHandler(this.comboBox_ListaVecini_SelectedIndexChanged);
            // 
            // listBox_ListaVecini
            // 
            this.listBox_ListaVecini.FormattingEnabled = true;
            this.listBox_ListaVecini.ItemHeight = 18;
            this.listBox_ListaVecini.Location = new System.Drawing.Point(12, 101);
            this.listBox_ListaVecini.Name = "listBox_ListaVecini";
            this.listBox_ListaVecini.Size = new System.Drawing.Size(409, 112);
            this.listBox_ListaVecini.TabIndex = 1;
            this.listBox_ListaVecini.SelectedIndexChanged += new System.EventHandler(this.listBox_ListaVecini_SelectedIndexChanged);
            // 
            // label_SelectareVecini
            // 
            this.label_SelectareVecini.AutoSize = true;
            this.label_SelectareVecini.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SelectareVecini.Location = new System.Drawing.Point(12, 29);
            this.label_SelectareVecini.Name = "label_SelectareVecini";
            this.label_SelectareVecini.Size = new System.Drawing.Size(197, 23);
            this.label_SelectareVecini.TabIndex = 2;
            this.label_SelectareVecini.Text = "Selectare vecini:";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(172, 253);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(94, 29);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Ad_vecini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 294);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_SelectareVecini);
            this.Controls.Add(this.listBox_ListaVecini);
            this.Controls.Add(this.comboBox_ListaVecini);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Ad_vecini";
            this.Text = "Adăugare vecini";
            this.Load += new System.EventHandler(this.Ad_vecini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox_ListaVecini;
        private ListBox listBox_ListaVecini;
        private Label label_SelectareVecini;
        private Button button_OK;
    }
}