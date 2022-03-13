namespace ProiectSincretic
{
    partial class Meniu_principal
    {

        private System.ComponentModel.IContainer components = null;
        
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
            this.components = new System.ComponentModel.Container();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.label_Titlu = new System.Windows.Forms.Label();
            this.groupBox_Harta = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_GenerareHartaTastatura = new System.Windows.Forms.Button();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.button_Algoritm = new System.Windows.Forms.Button();
            this.button_Contact = new System.Windows.Forms.Button();
            this.button_Dev = new System.Windows.Forms.Button();
            this.button_Versiuni = new System.Windows.Forms.Button();
            this.button_Theme = new System.Windows.Forms.Button();
            this.button_Iesire = new System.Windows.Forms.Button();
            this.statusStrip_StatusAplicatie = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Text = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Timp = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_TimpExecutieAplicatie = new System.Windows.Forms.Timer(this.components);
            this.label_Desc = new System.Windows.Forms.Label();
            this.groupBox_Harta.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            this.statusStrip_StatusAplicatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(188, 194);
            // 
            // label_Titlu
            // 
            this.label_Titlu.AutoSize = true;
            this.label_Titlu.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Titlu.Location = new System.Drawing.Point(37, 9);
            this.label_Titlu.Name = "label_Titlu";
            this.label_Titlu.Size = new System.Drawing.Size(525, 33);
            this.label_Titlu.TabIndex = 0;
            this.label_Titlu.Text = "Generator de culori pentru o hartă";
            // 
            // groupBox_Harta
            // 
            this.groupBox_Harta.Controls.Add(this.button2);
            this.groupBox_Harta.Controls.Add(this.button1);
            this.groupBox_Harta.Controls.Add(this.button_GenerareHartaTastatura);
            this.groupBox_Harta.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Harta.Location = new System.Drawing.Point(21, 64);
            this.groupBox_Harta.Name = "groupBox_Harta";
            this.groupBox_Harta.Size = new System.Drawing.Size(274, 197);
            this.groupBox_Harta.TabIndex = 1;
            this.groupBox_Harta.TabStop = false;
            this.groupBox_Harta.Text = "Hartă";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(16, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Încărcare hartă din fișier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(16, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generare hartă din fișier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_GenerareHartaTastatura
            // 
            this.button_GenerareHartaTastatura.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_GenerareHartaTastatura.Location = new System.Drawing.Point(16, 38);
            this.button_GenerareHartaTastatura.Name = "button_GenerareHartaTastatura";
            this.button_GenerareHartaTastatura.Size = new System.Drawing.Size(238, 29);
            this.button_GenerareHartaTastatura.TabIndex = 0;
            this.button_GenerareHartaTastatura.Text = "Generare hartă nouă";
            this.button_GenerareHartaTastatura.UseVisualStyleBackColor = true;
            this.button_GenerareHartaTastatura.Click += new System.EventHandler(this.button_GenerareHartaTastatura_Click);
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.button_Algoritm);
            this.groupBox_Info.Controls.Add(this.button_Contact);
            this.groupBox_Info.Controls.Add(this.button_Dev);
            this.groupBox_Info.Controls.Add(this.button_Versiuni);
            this.groupBox_Info.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Info.Location = new System.Drawing.Point(322, 64);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(251, 197);
            this.groupBox_Info.TabIndex = 3;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Informații";
            // 
            // button_Algoritm
            // 
            this.button_Algoritm.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Algoritm.Location = new System.Drawing.Point(30, 108);
            this.button_Algoritm.Name = "button_Algoritm";
            this.button_Algoritm.Size = new System.Drawing.Size(183, 29);
            this.button_Algoritm.TabIndex = 3;
            this.button_Algoritm.Text = "Algoritm";
            this.button_Algoritm.UseVisualStyleBackColor = true;
            this.button_Algoritm.Click += new System.EventHandler(this.button_Algoritm_Click);
            // 
            // button_Contact
            // 
            this.button_Contact.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Contact.Location = new System.Drawing.Point(30, 143);
            this.button_Contact.Name = "button_Contact";
            this.button_Contact.Size = new System.Drawing.Size(183, 29);
            this.button_Contact.TabIndex = 2;
            this.button_Contact.Text = "Contact";
            this.button_Contact.UseVisualStyleBackColor = true;
            this.button_Contact.Click += new System.EventHandler(this.button_Contact_Click);
            // 
            // button_Dev
            // 
            this.button_Dev.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Dev.Location = new System.Drawing.Point(30, 73);
            this.button_Dev.Name = "button_Dev";
            this.button_Dev.Size = new System.Drawing.Size(183, 29);
            this.button_Dev.TabIndex = 1;
            this.button_Dev.Text = "Dezvoltare";
            this.button_Dev.UseVisualStyleBackColor = true;
            this.button_Dev.Click += new System.EventHandler(this.button_Dev_Click);
            // 
            // button_Versiuni
            // 
            this.button_Versiuni.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Versiuni.Location = new System.Drawing.Point(30, 38);
            this.button_Versiuni.Name = "button_Versiuni";
            this.button_Versiuni.Size = new System.Drawing.Size(183, 29);
            this.button_Versiuni.TabIndex = 0;
            this.button_Versiuni.Text = "Versiuni";
            this.button_Versiuni.UseVisualStyleBackColor = true;
            this.button_Versiuni.Click += new System.EventHandler(this.button_Versiuni_Click);
            // 
            // button_Theme
            // 
            this.button_Theme.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Theme.Location = new System.Drawing.Point(322, 378);
            this.button_Theme.Name = "button_Theme";
            this.button_Theme.Size = new System.Drawing.Size(134, 29);
            this.button_Theme.TabIndex = 4;
            this.button_Theme.Text = "Temă aplicație";
            this.button_Theme.UseVisualStyleBackColor = true;
            this.button_Theme.Click += new System.EventHandler(this.button_Theme_Click);
            // 
            // button_Iesire
            // 
            this.button_Iesire.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Iesire.Location = new System.Drawing.Point(461, 378);
            this.button_Iesire.Name = "button_Iesire";
            this.button_Iesire.Size = new System.Drawing.Size(134, 29);
            this.button_Iesire.TabIndex = 5;
            this.button_Iesire.Text = "Ieșire";
            this.button_Iesire.UseVisualStyleBackColor = true;
            this.button_Iesire.Click += new System.EventHandler(this.button_Iesire_Click);
            // 
            // statusStrip_StatusAplicatie
            // 
            this.statusStrip_StatusAplicatie.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_StatusAplicatie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Text,
            this.toolStripStatusLabel_Timp});
            this.statusStrip_StatusAplicatie.Location = new System.Drawing.Point(0, 410);
            this.statusStrip_StatusAplicatie.Name = "statusStrip_StatusAplicatie";
            this.statusStrip_StatusAplicatie.Size = new System.Drawing.Size(607, 26);
            this.statusStrip_StatusAplicatie.TabIndex = 6;
            this.statusStrip_StatusAplicatie.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Text
            // 
            this.toolStripStatusLabel_Text.Name = "toolStripStatusLabel_Text";
            this.toolStripStatusLabel_Text.Size = new System.Drawing.Size(186, 20);
            this.toolStripStatusLabel_Text.Text = "Timp petrecut în aplicație: ";
            // 
            // toolStripStatusLabel_Timp
            // 
            this.toolStripStatusLabel_Timp.Name = "toolStripStatusLabel_Timp";
            this.toolStripStatusLabel_Timp.Size = new System.Drawing.Size(42, 20);
            this.toolStripStatusLabel_Timp.Text = "TIMP";
            // 
            // timer_TimpExecutieAplicatie
            // 
            this.timer_TimpExecutieAplicatie.Tick += new System.EventHandler(this.timer_TimpExecutieAplicatie_Tick);
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Desc.Location = new System.Drawing.Point(21, 264);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_Desc.Size = new System.Drawing.Size(530, 88);
            this.label_Desc.TabIndex = 7;
            this.label_Desc.Text = "    Această aplicație are rolul de a genera o listă \r\nde culori pentru reprezenta" +
    "rea unui număr de \r\nțări pe o hartă și afișarea respectivelor țări, \r\nîn funcție" +
    " de vecinii acestora.";
            // 
            // Meniu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 436);
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.statusStrip_StatusAplicatie);
            this.Controls.Add(this.button_Iesire);
            this.Controls.Add(this.button_Theme);
            this.Controls.Add(this.groupBox_Info);
            this.Controls.Add(this.groupBox_Harta);
            this.Controls.Add(this.label_Titlu);
            this.Name = "Meniu_principal";
            this.Text = "Generator culori hartă";
            this.groupBox_Harta.ResumeLayout(false);
            this.groupBox_Info.ResumeLayout(false);
            this.statusStrip_StatusAplicatie.ResumeLayout(false);
            this.statusStrip_StatusAplicatie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Label label_Titlu;
        private GroupBox groupBox_Harta;
        private Button button2;
        private Button button1;
        private Button button_GenerareHartaTastatura;
        private GroupBox groupBox_Info;
        private Button button_Algoritm;
        private Button button_Contact;
        private Button button_Dev;
        private Button button_Versiuni;
        private Button button_Theme;
        private Button button_Iesire;
        private StatusStrip statusStrip_StatusAplicatie;
        private ToolStripStatusLabel toolStripStatusLabel_Text;
        private ToolStripStatusLabel toolStripStatusLabel_Timp;
        private System.Windows.Forms.Timer timer_TimpExecutieAplicatie;
        private Label label_Desc;
    }
}