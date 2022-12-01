using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datenerfassung
{
    public partial class PopupZeiterfassung : Form
    {
        public ZeiterfassungClass _zeiterfassungClass;
        public MitarbeiterLogin _mitarbeiterLogin;
        public Zustande zustande;
        public bool _update;
        public PopupZeiterfassung()
        {
            InitializeComponent();
            _zeiterfassungClass = new ZeiterfassungClass();
            _mitarbeiterLogin = new MitarbeiterLogin();
        }
        public void Zeitraum()
        {
            int ZeitraumEins = Convert.ToInt32(dTPbis.Value.ToString("HHmm")) - Convert.ToInt32(dTPVon.Value.ToString("HHmm"));
            if (ZeitraumEins < 100)
            {
                if (Convert.ToInt32(dTPbis.Value.ToString("HH")) != Convert.ToInt32(dTPVon.Value.ToString("HH"))) {
                    int ZeitraumMinuten = ZeitraumEins - 40;
                if (ZeitraumMinuten >= 1 && ZeitraumMinuten < 20)
                {
                    ZeitraumMinuten = 25;
                    _zeiterfassungClass.Stunden = "0," + ZeitraumMinuten.ToString();
                }
                else if (ZeitraumMinuten >= 20 && ZeitraumMinuten < 40)
                {
                    ZeitraumMinuten = 50;
                    _zeiterfassungClass.Stunden = "0," + ZeitraumMinuten.ToString();
                }
                else if (ZeitraumMinuten >= 40 && ZeitraumMinuten <= 60)
                {
                    ZeitraumMinuten = 75;
                    _zeiterfassungClass.Stunden = "0," + ZeitraumMinuten.ToString();
                }
            }
                else {
                     int ZeitraumMinuten = ZeitraumEins;
                    if (ZeitraumMinuten >= 1 && ZeitraumMinuten < 20)
                    {
                        ZeitraumMinuten = 25;
                        _zeiterfassungClass.Stunden = "0," + ZeitraumMinuten.ToString();
                    }
                    else if (ZeitraumMinuten >= 20 && ZeitraumMinuten < 40)
                    {
                        ZeitraumMinuten = 50;
                        _zeiterfassungClass.Stunden = "0," + ZeitraumMinuten.ToString();
                    }
                    else if (ZeitraumMinuten >= 40 && ZeitraumMinuten <= 60)
                    {
                        ZeitraumMinuten = 75;
                        _zeiterfassungClass.Stunden = "0," + ZeitraumMinuten.ToString();
                    }
                }

            }
            else if(ZeitraumEins >= 100)
            {
                int ZeitraumStunde = ZeitraumEins / 100;
                int ZeitraumMinuten = ((ZeitraumStunde * 100) - ZeitraumEins)*-1;
                if(ZeitraumMinuten == 0)
                {
                    _zeiterfassungClass.Stunden = ZeitraumStunde.ToString();
                }
                else if(ZeitraumMinuten >= 1 && ZeitraumMinuten <20)
                {
                    ZeitraumMinuten = 25;
                    _zeiterfassungClass.Stunden = ZeitraumStunde.ToString() + "," + ZeitraumMinuten.ToString();
                }
                else if (ZeitraumMinuten >= 20 && ZeitraumMinuten <40)
                {
                    ZeitraumMinuten = 50;
                    _zeiterfassungClass.Stunden = ZeitraumStunde.ToString() + "," + ZeitraumMinuten.ToString();
                }
                else if(ZeitraumMinuten >=40 && ZeitraumMinuten <= 60)
                {
                    ZeitraumMinuten = 75;
                    _zeiterfassungClass.Stunden = ZeitraumStunde.ToString() + "," + ZeitraumMinuten.ToString();
                }

                
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Zeitraum();
            _zeiterfassungClass.Projekt = txtBoxProjekt.Text;
            _zeiterfassungClass.Beschreibung = txtBoxBeschreibung.Text;
            _zeiterfassungClass.von = int.Parse(dTPVon.Value.ToString("HHmm"));
            _zeiterfassungClass.bis = int.Parse(dTPbis.Value.ToString("HHmm"));
            _zeiterfassungClass.Datum = int.Parse(dTPVon.Value.ToString("ddMMyy"));
            _mitarbeiterLogin.Name = label5.Text;
            _mitarbeiterLogin.Tabellenname = _mitarbeiterLogin.Name + "Zeiterfassung";

            DatenbankFunktionen datenbank = new DatenbankFunktionen();
            if(_update == true)
            {
                 string name = label5.Text;
                int zeile = Convert.ToInt32(lblId.Text);
                 datenbank.UpdateArbeitsZeiten(name, _zeiterfassungClass, zeile);
            }
            else {datenbank.InsertArbeitsZeiten(_mitarbeiterLogin, _zeiterfassungClass); }
            
            Close();
        }

        private void PopupZeiterfassung_Load(object sender, EventArgs e)
        {
            if(txtBoxProjekt.Text != string.Empty)
            {
                _update = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
