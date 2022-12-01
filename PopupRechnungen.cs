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

namespace Datenerfassung
{
    public partial class PopupRechnungen : Form
    {
        public RechnungClass _rechnungenClass;
        public PopupRechnungen()
        {
            InitializeComponent();
            _rechnungenClass = new RechnungClass();
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "All files | *.*" })
            {
                try {if(ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    _rechnungenClass.Name = txtBoxName.Text;
                    _rechnungenClass.Betrag = Convert.ToInt32(txtBoxBetrag.Text);
                    _rechnungenClass.Datum = dtPRechnung.Value.ToString("dd.MM.yy");
                    _rechnungenClass.Description = txtBoxBeschreibung.Text;
                    _rechnungenClass.RechnungName = _rechnungenClass.Name + _rechnungenClass.Datum;

                    _rechnungenClass.ausgabepfad = $"H:/WIndowsForms/Datenerfassung/Rechnungen/{_rechnungenClass.RechnungName}.pdf";
                    System.IO.File.Copy(fi.FullName, _rechnungenClass.ausgabepfad);
                        DatenbankFunktionen datenbankFunktionen = new DatenbankFunktionen();
                        datenbankFunktionen.InsertRechungen(_rechnungenClass);

                }
                }
                catch { MessageBox.Show("JUNGE PDF HAB ICH GESAGT"); }
                
            }
        }

        private void Rechnungen_Load(object sender, EventArgs e)
        {

        }
    }
}
