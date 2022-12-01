using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.PdfViewer;


namespace Datenerfassung
{
    public partial class Hauptprogramm : Form
    {
        DatenbankFunktionen _datenbankFunktionen;
        Zustande _zustande;
        public Hauptprogramm()
        {
            InitializeComponent();
            _datenbankFunktionen = new DatenbankFunktionen();

            _zustande = new Zustande();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnZeit_Click(object sender, EventArgs e)
        {
            PopupZeiterfassung zeiterfassung = new PopupZeiterfassung();
            zeiterfassung.label5.Text = lblName.Text;
            zeiterfassung.ShowDialog();
            string name = lblName.Text + "Zeiterfassung";
            List<ZeiterfassungClass> zeiterfassungClasses = _datenbankFunktionen.getDataZeit(name);
            dataGridZeit.DataSource = zeiterfassungClasses;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Hauptprogramm_Load(object sender, EventArgs e)
        {
            List<Projekterfassung> list = _datenbankFunktionen.getDataProjekt();
            string name = lblName.Text + "Zeiterfassung";
            List<ZeiterfassungClass> zeiterfassungClasses = _datenbankFunktionen.getDataZeit(name);
            List<RechnungClass> rechnungClasses = _datenbankFunktionen.GetRechnung();
            dataGridRechnung.DataSource = rechnungClasses;
            dataGridZeit.DataSource = zeiterfassungClasses;
            dataGridProjekt.DataSource = list;
        }

        private void BtnAddProjekt_Click(object sender, EventArgs e)
        {
            PopupProjekt projekt = new PopupProjekt();
            projekt.ShowDialog();
        }

        private void dataGridRechnung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridRechnung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string zeile = dataGridRechnung.CurrentRow.Cells[5].FormattedValue.ToString();
            string adresse = zeile + ".pdf";
            webBrowser1.Navigate(adresse);
        }

        private void dataGridZeit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _zustande.Zeile = int.Parse(dataGridZeit.CurrentRow.Cells[6].FormattedValue.ToString());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = lblName.Text + "Zeiterfassung";
            _datenbankFunktionen.DeleteZeiterfassung(name, _zustande.Zeile);
            List<ZeiterfassungClass> zeiterfassungClasses = _datenbankFunktionen.getDataZeit(name);
            dataGridZeit.DataSource = zeiterfassungClasses;
        }

        private void btnBearbeiten_Click(object sender, EventArgs e)
        {
            string name = lblName.Text + "Zeiterfassung";
            _datenbankFunktionen.bearbeiteDataZeit(name, _zustande.Zeile);
            List<ZeiterfassungClass> zeiterfassungClasses = _datenbankFunktionen.getDataZeit(name);
            dataGridZeit.DataSource = zeiterfassungClasses;
        }
    }
}
