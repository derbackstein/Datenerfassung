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
    public partial class PopupProjektBearbeiten : Form
    {
        public PopupProjektBearbeiten()
        {
            InitializeComponent();
        }

        private void btnBearbeitenProjekt_Click(object sender, EventArgs e)
        {
            PopupProjekt popupProjekt = new PopupProjekt();
            popupProjekt.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Update Zustand Click
        private void btnToDo_Click(object sender, EventArgs e)
        {
            string zustand = "ToDo";
            string zeile = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();
            DatenbankFunktionen datenbankFunktionen = new DatenbankFunktionen();
            datenbankFunktionen.UpdateProjekt(zustand,zeile);
            List<Projekterfassung> list = datenbankFunktionen.getDataProjekt();
            dataGridView1.DataSource = list;
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            string zustand = "InProgress";
            string zeile = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();
            DatenbankFunktionen datenbankFunktionen = new DatenbankFunktionen();
            datenbankFunktionen.UpdateProjekt(zustand,zeile);
            List<Projekterfassung> list = datenbankFunktionen.getDataProjekt();
            dataGridView1.DataSource = list;
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            string zustand = "InReview";
            string zeile = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();
            DatenbankFunktionen datenbankFunktionen = new DatenbankFunktionen();
            datenbankFunktionen.UpdateProjekt(zustand, zeile);
            List<Projekterfassung> list = datenbankFunktionen.getDataProjekt();
            dataGridView1.DataSource = list;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string zustand = "Done";
            string zeile = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();
            DatenbankFunktionen datenbankFunktionen = new DatenbankFunktionen();
            datenbankFunktionen.UpdateProjekt(zustand, zeile);
            List<Projekterfassung> list = datenbankFunktionen.getDataProjekt();
            dataGridView1.DataSource = list;
        }
        #endregion

        private void PopupProjektBearbeiten_Load(object sender, EventArgs e)
        {
            DatenbankFunktionen datenbankFunktionen = new DatenbankFunktionen();
            List<Projekterfassung> list = datenbankFunktionen.getDataProjekt();
            dataGridView1.DataSource = list;
        }
    }
}
