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
    public partial class PopupProjekt : Form
    {
        Projekterfassung _projekterfassung;
        public PopupProjekt()
        {
            InitializeComponent();
            _projekterfassung = new Projekterfassung();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            _projekterfassung.ZugewiesenAn = txtBoxZugewiesen.Text;
            _projekterfassung.Ersteller = txtBoxErsteller.Text;
            _projekterfassung.AbschlussDatum = dTPProjektende.Value.ToString("ddMMyy");
            _projekterfassung.Beschreibung = txtBoxBeschreibung.Text;
            _projekterfassung.FileName = _projekterfassung.ZugewiesenAn + _projekterfassung.AbschlussDatum;
            _projekterfassung.Zustand = "ToDo";
            Funktionen funktionen = new Funktionen();
            funktionen.writeToTxtFile(_projekterfassung.FileName, _projekterfassung.Beschreibung);
            DatenbankFunktionen datenbankFunktionen = new DatenbankFunktionen();
            datenbankFunktionen.SpeichernProjekt(_projekterfassung);
        }
    }
}
