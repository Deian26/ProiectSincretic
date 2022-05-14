using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Main
{

    public class Utilitary //clasa care defineste structuri de date si functii utilitare
    {
        //structuri de date
        public struct err
        {
            private string code, desc;

            public err()
            {
                this.code = "E0";
                this.desc = "Undefined error";
            }
            public err(string code, string desc)
            {
                this.code = code;
                this.desc = desc;
            }
            //getters
            public string getErr(string code)
            {
                if (this.code == code) return this.code + ": " + this.desc;
                return "E0: Undefined error";
            }
        };

        public struct language
        {
            private string name, text;

            public language()
            {
                this.name = "#ERROR";
                this.text = "#ERROR#";
            }
            public language(string name, string text)
            {
                this.name = name;
                this.text = text;
            }
            //getters
            public string getText()
            {
                return this.text;
            }
            public string getName()
            {
                return this.name;
            }
        };

        //structura care memoreaza tara curenta si vecinii sai
        public struct Tara
        {
            private string tara;
            private List<string> vecini;

            //setters
            public void setTara(string tara)
            {
                this.tara = tara;
            }
            public void setVecini(List<string> vecini)
            {
                this.vecini = vecini;
            }
            //getters
            public string getTara()
            {
                return this.tara;
            }
            public List<string> getVecini()
            {
                return this.vecini;
            }

        };

        //structura care salveaza datele returnate de catre algoritm spre a fi stocate pe disc (fisier)
        public struct FileSave
        {
            private string tara;
            private string culoare;
            private List<string> vecini;

            //setters
            public void setTara(string tara)
            {
                this.tara = tara;
            }
            public void setVecini(List<string> vecini)
            {
                this.vecini = vecini;
            }
            public void setCuloare(string culoare)
            {
                this.culoare = culoare;
            }

            //getters
            public string getTara()
            {
                return this.tara;
            }
            public List<string> getVecini()
            {
                return this.vecini;
            }

            public string getCuloare()
            {
                return this.culoare;
            }
        };


        //algoritm
        public List<FileSave> Algorithm(List<Tara> Tari, List<string> culori)
        {
            List<FileSave> result = new List<FileSave>();
            static bool verif(int i, List<FileSave> result, string Nume)
            {
                int ok = -1;
                for (int j = 0; j < result[i].getVecini().Count; j++)
                {
                    if (result[i].getVecini(j) == Nume)
                        ok = j;
                }
                if (ok != -1)
                {
                    return true;
                }
                return false;
            }
            static void setTara(List<FileSave> result, Tara tara, List<string> cul)
            {
                int k = result.Count;
                int i;
                int index = 0, indexm = 0;
                Boolean[] seen;
                seen = new bool[result.Count];
                if (k == 0)
                {
                    FileSave t = new FileSave();
                    t.setTara(tara.getTara());
                    t.setCuloare(cul[index]);
                    t.setVecini(tara.getVecini());
                    result.Add(t);
                }
                else
                {
                    Boolean ok = false;
                    for (i = 0; i < k; i++)
                        if (verif(i, result, tara.getTara()) == true)
                        {
                            index = cul.IndexOf(result[i].Culoare);
                            seen[index] = true;
                            if (index > indexm)
                                indexm = index;
                        }

                    for (i = 0; i <= indexm; i++)
                        if (seen[i] == false)
                        {
                            ok = true;
                            FileSave t = new FileSave();
                            t.setTara(tara.getTara());
                            t.setCuloare(cul[index]);
                            t.setVecini(tara.getVecini());
                            result.Add(t);
                            break;
                        }
                    if (ok == false)
                    {
                        FileSave t = new FileSave();
                        t.setTara(tara.getTara());
                        t.setCuloare(cul[index]);
                        t.setVecini(tara.getVecini());
                        result.Add(t);
                    }
                }

            }
            static void citireDate()
            {
                foreach (var tara in Tari)
                {
                    setTara(result, tara, culori);
                }
            }

            return result;
        }


        //functii

        //traducere
        //incarca prescurtarile traducerilor (RO, EN etc.)
        public void LoadLanguageList(string languages_filename, List<string> language_list, ComboBox combo)
        {
            XmlDocument list = new XmlDocument();
            list.Load(languages_filename);

            foreach (XmlNode node in list.DocumentElement.ChildNodes[0].ChildNodes)
            {
                combo.Items.Add(node.InnerText);
                language_list.Add(node.Name.ToString());
            }
        }
        //incarca textul afisate in functie de limba aleasa
        public void LoadTranslations(string Language, string languages_filename, List<language> language_texts)
        {
            XmlDocument list = new XmlDocument();
            list.Load(languages_filename);

            foreach (XmlNode node in list.DocumentElement.ChildNodes)
                if (node.Name == Language)
                    foreach (XmlNode node2 in node.ChildNodes)
                        if (node2.Attributes.Count != 0) language_texts.Add(new language(node2.Attributes[0].Value.ToString(), node2.InnerText));

        }

        //incarca mesajele de eroare in lista err_message, in functie de limba
        public void LoadErrorMessages(string err_filename, List<err> err_message)
        {

            XmlDocument list = new XmlDocument();
            list.Load(err_filename);
            foreach (XmlNode node in list.DocumentElement.ChildNodes)
                foreach (XmlNode node2 in node.ChildNodes)
                    err_message.Add(new Utilitary.err(node2.Name, node2.InnerText));

        }

        //incarca informatii despre aplicatie
        public void LoadSoftwareInfo(string SoftwareInfo_filename, List<string> SoftwareInfo)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(SoftwareInfo_filename);

            foreach (XmlNode node in xml.DocumentElement.ChildNodes)
                if (node.Name == "Versions")
                {
                    SoftwareInfo.Add(node.ChildNodes[0].InnerText + "\n");
                    SoftwareInfo.Add(node.ChildNodes[1].InnerText + "\n");
                }
                else if (node.Name == "Development")
                {
                    SoftwareInfo.Add(node.ChildNodes[0].InnerText + "\n");
                }
                else if (node.Name == "Algorithm")
                {
                    SoftwareInfo.Add(node.ChildNodes[0].InnerText + "\n");
                }
                else if (node.Name == "Contact")
                {
                    SoftwareInfo.Add(node.ChildNodes[0].InnerText + "\n");
                }

        }

        //actualizeaza textele din form-ul dat (de obicei, form-ul curent - 'this' )
        public void RewriteTexts(List<language> language_texts, Form form)
        {
            if (language_texts.Count != 0) form.Text = language_texts[0].getText();
            foreach (Utilitary.language language in language_texts)
            {
                if (language.getName() != "")
                {
                    Control[] list = form.Controls.Find(language.getName(), true);
                    if (list.Length != 0)
                        list[0].Text = language.getText();

                }
            }
        }

        //theme
        //incarca lista temelor de aplicatie
        public void LoadThemeList(string themes_filename, List<string> theme_list, ComboBox combo)
        {
            XmlDocument list = new XmlDocument();
            list.Load(themes_filename);

            foreach (XmlNode node in list.DocumentElement.ChildNodes[0].ChildNodes)
            {
                combo.Items.Add(node.InnerText);
                theme_list.Add(node.Name.ToString());
            }
        }

        //setare tema aplicatie
        public void ChangeTheme(string theme, string themes_filename, Form form)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(themes_filename);

            foreach (XmlNode node in xml.DocumentElement.ChildNodes)
                if (node.Name == theme)
                {
                    form.BackColor = Color.FromName(node.Attributes[0].Value.ToString());

                    foreach (Control control in form.Controls)
                        foreach (XmlNode node2 in node.ChildNodes)
                        {
                            if ("System.Windows.Forms." + node2.Name.ToString() == control.GetType().ToString())
                            {
                                switch (control.GetType().ToString())
                                {
                                    case "System.Windows.Forms.Button":
                                        Button btn = (Button)control;
                                        btn.Font = SystemFonts.GetFontByName(node2.Attributes[2].Value);
                                        btn.FlatAppearance.BorderSize = Convert.ToInt32(node2.Attributes[4].Value);
                                        btn.FlatAppearance.BorderColor = Color.FromName(node2.Attributes[5].Value);
                                        if (btn.Name != "button_Iesire")
                                        {
                                            btn.ForeColor = Color.FromName(node2.Attributes[0].Value);
                                            btn.FlatStyle = (FlatStyle)Convert.ToInt32(node2.Attributes[3].Value);
                                            btn.BackColor = Color.FromName(node2.Attributes[1].Value);
                                        }
                                        break;
                                    default:
                                        Control ctrl = control;
                                        ctrl.ForeColor = Color.FromName(node2.Attributes[0].Value);
                                        ctrl.BackColor = Color.FromName(node2.Attributes[1].Value);
                                        ctrl.Font = SystemFonts.GetFontByName(node2.Attributes[2].Value);
                                        break;
                                }

                            }
                            if ("System.Windows.Forms." + node2.Name.ToString() == "System.Windows.Forms.GroupBox")
                            {
                                foreach (Control ctrl_groupbox in control.Controls)
                                    foreach (XmlNode node3 in node.ChildNodes)
                                        if ("System.Windows.Forms." + node3.Name.ToString() == ctrl_groupbox.GetType().ToString())
                                            switch (ctrl_groupbox.GetType().ToString())
                                            {
                                                case "System.Windows.Forms.Button":
                                                    Button btn = (Button)ctrl_groupbox;
                                                    btn.Font = SystemFonts.GetFontByName(node3.Attributes[2].Value);
                                                    btn.Font = SystemFonts.GetFontByName(node3.Attributes[2].Value);
                                                    btn.FlatAppearance.BorderSize = Convert.ToInt32(node3.Attributes[4].Value);
                                                    btn.FlatAppearance.BorderColor = Color.FromName(node3.Attributes[5].Value);
                                                    if (btn.Name != "button_Iesire")
                                                    {
                                                        btn.ForeColor = Color.FromName(node3.Attributes[0].Value);
                                                        btn.BackColor = Color.FromName(node3.Attributes[1].Value);
                                                        btn.FlatStyle = (FlatStyle)Convert.ToInt32(node3.Attributes[3].Value);
                                                    }
                                                    break;
                                                default:
                                                    Control ctrl = ctrl_groupbox;
                                                    ctrl.ForeColor = Color.FromName(node3.Attributes[0].Value);
                                                    ctrl.BackColor = Color.FromName(node3.Attributes[1].Value);
                                                    ctrl.Font = SystemFonts.GetFontByName(node3.Attributes[2].Value);
                                                    break;
                                            }
                            }

                        }
                }


            Control[] title = form.Controls.Find("label_Titlu", true);
            if (title.Length != 0)
            {
                title[0].Font = new Font(FontFamily.Families[8], 16.0F);
                //title[0].Font = new Font(FontFamily.Families[8], 16.0F,FontStyle.Bold);
            }

        }


        //incarcare tari si culori in comboBox-urile corespondente
        public void LoadComboBox(string language, string filename, ComboBox combo)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);

            foreach (XmlNode node in xml.DocumentElement.ChildNodes)
                if (node.Name == language)
                    foreach (XmlNode node2 in node.ChildNodes)
                        combo.Items.Add(node2.InnerText);

        }

    }
}
