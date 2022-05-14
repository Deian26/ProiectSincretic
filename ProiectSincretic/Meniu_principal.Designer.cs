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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu_principal));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.label_Titlu = new System.Windows.Forms.Label();
            this.groupBox_Harta = new System.Windows.Forms.GroupBox();
            this.button_GenerareHartaDinFisier = new System.Windows.Forms.Button();
            this.button_GenerareHartaTastatura = new System.Windows.Forms.Button();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.button_Algoritm = new System.Windows.Forms.Button();
            this.button_Contact = new System.Windows.Forms.Button();
            this.button_Dev = new System.Windows.Forms.Button();
            this.button_Versiuni = new System.Windows.Forms.Button();
            this.button_Iesire = new System.Windows.Forms.Button();
            this.statusStrip_StatusAplicatie = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Text = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Timp = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_TimpExecutieAplicatie = new System.Windows.Forms.Timer(this.components);
            this.label_Desc = new System.Windows.Forms.Label();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.label_Limba = new System.Windows.Forms.Label();
            this.openFileDialog_IncarcareHarta = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label_Theme = new System.Windows.Forms.Label();
            this.comboBox_Theme = new System.Windows.Forms.ComboBox();
            this.groupBox_Harta.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            this.statusStrip_StatusAplicatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            resources.ApplyResources(this.BottomToolStripPanel, "BottomToolStripPanel");
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // TopToolStripPanel
            // 
            resources.ApplyResources(this.TopToolStripPanel, "TopToolStripPanel");
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // RightToolStripPanel
            // 
            resources.ApplyResources(this.RightToolStripPanel, "RightToolStripPanel");
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // LeftToolStripPanel
            // 
            resources.ApplyResources(this.LeftToolStripPanel, "LeftToolStripPanel");
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            // 
            // ContentPanel
            // 
            resources.ApplyResources(this.ContentPanel, "ContentPanel");
            // 
            // label_Titlu
            // 
            resources.ApplyResources(this.label_Titlu, "label_Titlu");
            this.label_Titlu.Name = "label_Titlu";
            // 
            // groupBox_Harta
            // 
            this.groupBox_Harta.Controls.Add(this.button_GenerareHartaDinFisier);
            this.groupBox_Harta.Controls.Add(this.button_GenerareHartaTastatura);
            resources.ApplyResources(this.groupBox_Harta, "groupBox_Harta");
            this.groupBox_Harta.Name = "groupBox_Harta";
            this.groupBox_Harta.TabStop = false;
            // 
            // button_GenerareHartaDinFisier
            // 
            resources.ApplyResources(this.button_GenerareHartaDinFisier, "button_GenerareHartaDinFisier");
            this.button_GenerareHartaDinFisier.Name = "button_GenerareHartaDinFisier";
            this.button_GenerareHartaDinFisier.UseVisualStyleBackColor = true;
            this.button_GenerareHartaDinFisier.Click += new System.EventHandler(this.button_GenerareHartaDinFisier_Click);
            // 
            // button_GenerareHartaTastatura
            // 
            resources.ApplyResources(this.button_GenerareHartaTastatura, "button_GenerareHartaTastatura");
            this.button_GenerareHartaTastatura.Name = "button_GenerareHartaTastatura";
            this.button_GenerareHartaTastatura.UseVisualStyleBackColor = true;
            this.button_GenerareHartaTastatura.Click += new System.EventHandler(this.button_GenerareHartaTastatura_Click);
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.button_Algoritm);
            this.groupBox_Info.Controls.Add(this.button_Contact);
            this.groupBox_Info.Controls.Add(this.button_Dev);
            this.groupBox_Info.Controls.Add(this.button_Versiuni);
            resources.ApplyResources(this.groupBox_Info, "groupBox_Info");
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.TabStop = false;
            // 
            // button_Algoritm
            // 
            resources.ApplyResources(this.button_Algoritm, "button_Algoritm");
            this.button_Algoritm.Name = "button_Algoritm";
            this.button_Algoritm.UseVisualStyleBackColor = true;
            this.button_Algoritm.Click += new System.EventHandler(this.button_Algoritm_Click);
            // 
            // button_Contact
            // 
            resources.ApplyResources(this.button_Contact, "button_Contact");
            this.button_Contact.Name = "button_Contact";
            this.button_Contact.UseVisualStyleBackColor = true;
            this.button_Contact.Click += new System.EventHandler(this.button_Contact_Click);
            // 
            // button_Dev
            // 
            resources.ApplyResources(this.button_Dev, "button_Dev");
            this.button_Dev.Name = "button_Dev";
            this.button_Dev.UseVisualStyleBackColor = true;
            this.button_Dev.Click += new System.EventHandler(this.button_Dev_Click);
            // 
            // button_Versiuni
            // 
            resources.ApplyResources(this.button_Versiuni, "button_Versiuni");
            this.button_Versiuni.Name = "button_Versiuni";
            this.button_Versiuni.UseVisualStyleBackColor = true;
            this.button_Versiuni.Click += new System.EventHandler(this.button_Versiuni_Click);
            // 
            // button_Iesire
            // 
            this.button_Iesire.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.button_Iesire, "button_Iesire");
            this.button_Iesire.Name = "button_Iesire";
            this.button_Iesire.UseVisualStyleBackColor = false;
            this.button_Iesire.Click += new System.EventHandler(this.button_Iesire_Click);
            // 
            // statusStrip_StatusAplicatie
            // 
            this.statusStrip_StatusAplicatie.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_StatusAplicatie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Text,
            this.toolStripStatusLabel_Timp});
            resources.ApplyResources(this.statusStrip_StatusAplicatie, "statusStrip_StatusAplicatie");
            this.statusStrip_StatusAplicatie.Name = "statusStrip_StatusAplicatie";
            // 
            // toolStripStatusLabel_Text
            // 
            resources.ApplyResources(this.toolStripStatusLabel_Text, "toolStripStatusLabel_Text");
            this.toolStripStatusLabel_Text.Name = "toolStripStatusLabel_Text";
            // 
            // toolStripStatusLabel_Timp
            // 
            resources.ApplyResources(this.toolStripStatusLabel_Timp, "toolStripStatusLabel_Timp");
            this.toolStripStatusLabel_Timp.Name = "toolStripStatusLabel_Timp";
            // 
            // timer_TimpExecutieAplicatie
            // 
            this.timer_TimpExecutieAplicatie.Tick += new System.EventHandler(this.timer_TimpExecutieAplicatie_Tick);
            // 
            // label_Desc
            // 
            resources.ApplyResources(this.label_Desc, "label_Desc");
            this.label_Desc.Name = "label_Desc";
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_Language, "comboBox_Language");
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.SelectedIndexChanged += new System.EventHandler(this.comboBox_Language_SelectedIndexChanged);
            // 
            // label_Limba
            // 
            resources.ApplyResources(this.label_Limba, "label_Limba");
            this.label_Limba.Name = "label_Limba";
            // 
            // label_Theme
            // 
            resources.ApplyResources(this.label_Theme, "label_Theme");
            this.label_Theme.Name = "label_Theme";
            // 
            // comboBox_Theme
            // 
            this.comboBox_Theme.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox_Theme, "comboBox_Theme");
            this.comboBox_Theme.Name = "comboBox_Theme";
            this.comboBox_Theme.SelectedIndexChanged += new System.EventHandler(this.comboBox_Theme_SelectedIndexChanged);
            // 
            // Meniu_principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_Theme);
            this.Controls.Add(this.label_Theme);
            this.Controls.Add(this.label_Limba);
            this.Controls.Add(this.comboBox_Language);
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.statusStrip_StatusAplicatie);
            this.Controls.Add(this.button_Iesire);
            this.Controls.Add(this.groupBox_Info);
            this.Controls.Add(this.groupBox_Harta);
            this.Controls.Add(this.label_Titlu);
            this.MaximizeBox = false;
            this.Name = "Meniu_principal";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Meniu_principal_Load);
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
        private Button button_GenerareHartaDinFisier;
        private Button button_GenerareHartaTastatura;
        private GroupBox groupBox_Info;
        private Button button_Algoritm;
        private Button button_Contact;
        private Button button_Dev;
        private Button button_Versiuni;
        private Button button_Iesire;
        private StatusStrip statusStrip_StatusAplicatie;
        private ToolStripStatusLabel toolStripStatusLabel_Text;
        private ToolStripStatusLabel toolStripStatusLabel_Timp;
        private System.Windows.Forms.Timer timer_TimpExecutieAplicatie;
        private Label label_Desc;
        private ComboBox comboBox_Language;
        private Label label_Limba;
        private OpenFileDialog openFileDialog_IncarcareHarta;
        private SaveFileDialog saveFileDialog1;
        private Label label_Theme;
        private ComboBox comboBox_Theme;
    }
}