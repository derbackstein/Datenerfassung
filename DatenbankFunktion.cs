using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Datenerfassung;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class DatenbankFunktionen
{
    const string CONNECTION_STRING = "Data Source = Datensatz.db";
    //führt einfache befehle in der sql datei aus
    public DataTable ReadFromDatabase(string statement)
    {
        SQLiteConnection db_Connection = null;
        SQLiteCommand sql_Command = null;
        try
        {
            db_Connection = new SQLiteConnection();
            db_Connection.ConnectionString = CONNECTION_STRING;
            db_Connection.Open();

            sql_Command = db_Connection.CreateCommand();
            sql_Command.CommandText = statement;

            SQLiteDataReader sQLiteDataReader = sql_Command.ExecuteReader();
            sql_Command.Dispose();

            var dataTable = new DataTable();
            dataTable.Load(sQLiteDataReader);
            return dataTable;
        }
        finally
        {
            sql_Command?.Dispose();
            db_Connection?.Dispose();
        }
    }


    #region LoginLogik
    //Login Logik start
    //checkt ob der Mitarbeiter existiert
    public void LoginLogik(MitarbeiterLogin mitarbeiter)
    {
        DataTable dt = ReadFromDatabase($"SELECT Name FROM Mitarbeiter WHERE Name = '{mitarbeiter.Name}'");
        bool mitarbeiterExists = dt != null && dt.Rows.Count > 0;
        if (mitarbeiterExists)
        {
            CheckPasswort(mitarbeiter);
        }
        else { MessageBox.Show("Mitarbeiter existiert nicht"); }
    }
    //checkt ob der eingegebene Mitarbeiter zum Passwort passt
    public void CheckPasswort(MitarbeiterLogin mitarbeiter)
    {
        {
            SQLiteConnection db_Connection = null;
            SQLiteCommand sql_Command = null;
            try
            {
                db_Connection = new SQLiteConnection();
                db_Connection.ConnectionString = CONNECTION_STRING;
                db_Connection.Open();
                sql_Command = db_Connection.CreateCommand();
                sql_Command.CommandText = $"SELECT Passwort FROM Mitarbeiter WHERE Name = '{mitarbeiter.Name}'";
                SQLiteDataReader sQLiteDataReader = sql_Command.ExecuteReader();
                sql_Command.Dispose();

                while (sQLiteDataReader.HasRows && sQLiteDataReader.Read())
                {
                    string passwort = sQLiteDataReader.GetString(0);
                    sQLiteDataReader.Close();
                    if (mitarbeiter.Passwort == passwort)
                    {
                        db_Connection?.Close();
                        Hauptprogramm hauptprogramm = new Hauptprogramm();
                        hauptprogramm.lblName.Text = mitarbeiter.Name;
                        hauptprogramm.ShowDialog();
                    }
                    else { MessageBox.Show("Passwort ist falsch"); }
                }
            }
            finally
            {
                sql_Command?.Dispose();
                db_Connection?.Dispose();
            }
        }
    }
    //Login Logik ende
    #endregion


    #region Zeiterfassung
    //ZeiterfassungsTablle erstellt
    //Erstellt eine Tabelle für die Zeiterfassung mit dem Mitarbeiternamen
    public void CreateTableZeit(MitarbeiterLogin mitarbeiter)
    {
        mitarbeiter.Tabellenname = mitarbeiter.Name + "Zeiterfassung";
        DataTable dt = ReadFromDatabase($"CREATE TABLE IF NOT EXISTS '{mitarbeiter.Tabellenname}'" +
            $"(Datum INTEGER, von INTEGER, bis INTEGER, Stunden INTEGER, Projekt TEXT, Beschreibung TEXT, ID INTEGER,PRIMARY KEY(ID AUTOINCREMENT) ); ");
    }
    // Zeiterfassungstabelle

    //Fügt die eingegeben Zeitdaten in die Zeiterfassungstabelle
    public void InsertArbeitsZeiten(MitarbeiterLogin mitarbeiter, ZeiterfassungClass zeit)
    {
        DataTable dt = ReadFromDatabase($"INSERT INTO {mitarbeiter.Tabellenname}(Datum,von,bis,Stunden,Projekt,Beschreibung) VALUES ('{zeit.Datum}'," +
        $"'{zeit.von}','{zeit.bis}','{zeit.Stunden}','{zeit.Projekt}','{zeit.Beschreibung}')");
    }
    //Bearbeitet die eingegbenen Zeitdaten
    public void UpdateArbeitsZeiten(string Tabellenname, ZeiterfassungClass zeit, int zeile)
    {
        {
            SQLiteConnection db_Connection = null;
            SQLiteCommand sql_Command = null;
            try
            {
                db_Connection = new SQLiteConnection();
                db_Connection.ConnectionString = CONNECTION_STRING;
                db_Connection.Open();
                sql_Command = db_Connection.CreateCommand();
                sql_Command.CommandText = $"UPDATE {Tabellenname} " +
                                          $"SET (Datum ='{zeit.Datum}', von='{zeit.von}',bis ='{zeit.bis}',Stunden='{zeit.Stunden}',Projek='{zeit.Projekt}',Beschreibung ='{zeit.Beschreibung}' " +
                                          $"WHERE ID ={zeile})";
                sql_Command.Dispose();
            }
            finally
            {
                sql_Command?.Dispose();
                db_Connection?.Dispose();
            }
        }
        //DataTable dt = ReadFromDatabase($"UPDATE {Tabellenname} " +
        //    $"SET (Datum ='{zeit.Datum}', von='{zeit.von}',bis ='{zeit.bis}',Stunden='{zeit.Stunden}',Projek='{zeit.Projekt}',Beschreibung ='{zeit.Beschreibung}' " +
        //    $"WHERE ID ={zeile})");
    }
    //Liest die Zeiterfassungstabelle aus
    public List<ZeiterfassungClass> getDataZeit(string name)
    {
        {
            SQLiteConnection db_Connection = null;
            SQLiteCommand sql_Command = null;
            try
            {
                db_Connection = new SQLiteConnection();
                db_Connection.ConnectionString = CONNECTION_STRING;
                db_Connection.Open();
                sql_Command = db_Connection.CreateCommand();
                sql_Command.CommandText = $"SELECT * FROM'{name}'";
                SQLiteDataReader sQLiteDataReader = sql_Command.ExecuteReader();
                sql_Command.Dispose();

                List<ZeiterfassungClass> lists = new List<ZeiterfassungClass>();
                while (sQLiteDataReader.HasRows && sQLiteDataReader.Read())
                {
                    ZeiterfassungClass list = new ZeiterfassungClass();
                    if (sQLiteDataReader.IsDBNull(0))
                    {
                        list.Datum = 0;
                    }
                    else { list.Datum = sQLiteDataReader.GetInt32(0); }
                    if (sQLiteDataReader.IsDBNull(1))
                    {
                        list.von = 0;
                    }
                    else { list.von = sQLiteDataReader.GetInt32(1); }
                    if (sQLiteDataReader.IsDBNull(2))
                    {
                        list.bis = 0;
                    }
                    else { list.bis = sQLiteDataReader.GetInt32(2); }
                    if (sQLiteDataReader.IsDBNull(3))
                    {
                        list.Stunden = "0";
                    }
                    else { list.Stunden = sQLiteDataReader.GetString(3); }
                    if (sQLiteDataReader.IsDBNull(4))
                    {
                        list.Projekt = String.Empty;
                    }
                    else { list.Projekt = sQLiteDataReader.GetString(4); }
                    if (sQLiteDataReader.IsDBNull(5))
                    {
                        list.Beschreibung = String.Empty;
                    }
                    else { list.Beschreibung = sQLiteDataReader.GetString(5); }
                    if (sQLiteDataReader.IsDBNull(6))
                    {
                        list.ID = 0;
                    }
                    else { list.ID = sQLiteDataReader.GetInt32(6); }
                    lists.Add(list);
                }
                return lists;
            }
            finally
            {
                sql_Command?.Dispose();
                db_Connection?.Dispose();
            }
        }
    }
    // Liest die Zeiterfassungstabelle aus und übergibt die Daten in Popup Zeiterfassung
    public void bearbeiteDataZeit(string name, int id)
    {
        SQLiteConnection db_Connection = null;
        SQLiteCommand sql_Command = null;
        try
        {
            PopupZeiterfassung popupZeiterfassung = new PopupZeiterfassung();
            db_Connection = new SQLiteConnection();
            db_Connection.ConnectionString = CONNECTION_STRING;
            db_Connection.Open();
            sql_Command = db_Connection.CreateCommand();
            sql_Command.CommandText = $"SELECT * FROM'{name}' WHERE '{id}'";
            SQLiteDataReader sQLiteDataReader = sql_Command.ExecuteReader();
            sql_Command.Dispose();

            while (sQLiteDataReader.HasRows && sQLiteDataReader.Read())
            {
                if (sQLiteDataReader.IsDBNull(1))
                {
                    _ = 0;
                }
                else { _ = sQLiteDataReader.GetInt32(1); }
                if (sQLiteDataReader.IsDBNull(2))
                {
                    _ = 0;
                }
                else { _ = sQLiteDataReader.GetInt32(2); }
                if (sQLiteDataReader.IsDBNull(4))
                {
                    popupZeiterfassung.txtBoxProjekt.Text = String.Empty;
                }
                else { popupZeiterfassung.txtBoxProjekt.Text = sQLiteDataReader.GetString(4); }
                if (sQLiteDataReader.IsDBNull(5))
                {
                    popupZeiterfassung.txtBoxBeschreibung.Text = String.Empty;
                }
                else { popupZeiterfassung.txtBoxBeschreibung.Text = sQLiteDataReader.GetString(5); }
                popupZeiterfassung.label5.Text = name;
                popupZeiterfassung.lblId.Text = id.ToString();
                popupZeiterfassung.ShowDialog();
            }
        }
        finally
        {
            sql_Command?.Dispose();
            db_Connection?.Dispose();
        }
    }
    //Löscht die ausgewählte 
    public void DeleteZeiterfassung(string name, int ID)
    {
        DataTable dt = ReadFromDatabase($"DELETE FROM '{name}' WHERE ID = '{ID}'");
    }
    #endregion
    #region Projekt
    public void SpeichernProjekt(Projekterfassung eingabe)
    {
        DataTable dt = ReadFromDatabase($"INSERT INTO Projekte(ZugewiesenAn, Ersteller,AbschlussDatum,Zustand,FileName) VALUES('{eingabe.ZugewiesenAn}'," +
            $"'{eingabe.Ersteller}','{eingabe.AbschlussDatum}','{eingabe.Zustand}','{eingabe.FileName}')");
    }
    public void UpdateProjekt(string eingabe, string zeile)
    {
        DataTable dt = ReadFromDatabase($"UPDATE Projekte SET Zustand = '{eingabe}' WHERE  ID = '{zeile}'");
    }
    public List<Projekterfassung> getDataProjekt()
    {
        {
            SQLiteConnection db_Connection = null;
            SQLiteCommand sql_Command = null;
            try
            {
                db_Connection = new SQLiteConnection();
                db_Connection.ConnectionString = CONNECTION_STRING;
                db_Connection.Open();
                sql_Command = db_Connection.CreateCommand();
                sql_Command.CommandText = $"SELECT * FROM Projekte";
                SQLiteDataReader sQLiteDataReader = sql_Command.ExecuteReader();
                sql_Command.Dispose();

                List<Projekterfassung> lists = new List<Projekterfassung>();
                while (sQLiteDataReader.HasRows && sQLiteDataReader.Read())
                {
                    Projekterfassung list = new Projekterfassung();
                    list.ID = sQLiteDataReader.GetInt32(0);
                    if (sQLiteDataReader.IsDBNull(1))
                    {
                        list.ZugewiesenAn = String.Empty;
                    }
                    else { list.ZugewiesenAn = sQLiteDataReader.GetString(1); }
                    if (sQLiteDataReader.IsDBNull(2))
                    {
                        list.Ersteller = String.Empty;
                    }
                    else { list.Ersteller = sQLiteDataReader.GetString(2); }
                    if (sQLiteDataReader.IsDBNull(3))
                    {
                        list.AbschlussDatum = String.Empty;
                    }
                    else { list.AbschlussDatum = sQLiteDataReader.GetString(3); }
                    if (sQLiteDataReader.IsDBNull(4))
                    {
                        list.Zustand = String.Empty;
                    }
                    else { list.Zustand = sQLiteDataReader.GetString(4); }
                    if (sQLiteDataReader.IsDBNull(5))
                    {
                        list.FileName = String.Empty;
                    }
                    else { list.FileName = sQLiteDataReader.GetString(5); }
                    lists.Add(list);
                }
                return lists;
            }
            finally
            {
                sql_Command?.Dispose();
                db_Connection?.Dispose();
            }
        }
    }
    #endregion
    #region Rechnung
    public void InsertRechungen(RechnungClass eingabe)
    {
        DataTable dt = ReadFromDatabase($"INSERT INTO Rechnungen (Name,Datum,Betrag,FileName) VALUES ('{eingabe.Name}'," +
            $"'{eingabe.Datum}','{eingabe.Betrag}','{eingabe.ausgabepfad}')");
    }
    public List<RechnungClass> GetRechnung()
    {
        {
            SQLiteConnection db_Connection = null;
            SQLiteCommand sql_Command = null;
            try
            {
                db_Connection = new SQLiteConnection();
                db_Connection.ConnectionString = CONNECTION_STRING;
                db_Connection.Open();
                sql_Command = db_Connection.CreateCommand();
                sql_Command.CommandText = $"SELECT * FROM Rechnungen";
                SQLiteDataReader sQLiteDataReader = sql_Command.ExecuteReader();
                sql_Command.Dispose();

                List<RechnungClass> lists = new List<RechnungClass>();
                while (sQLiteDataReader.HasRows && sQLiteDataReader.Read())
                {
                    RechnungClass list = new RechnungClass();
                    if (sQLiteDataReader.IsDBNull(0))
                    {
                        list.Name = String.Empty;
                    }
                    else { list.Name = sQLiteDataReader.GetString(0); }
                    if (sQLiteDataReader.IsDBNull(1))
                    {
                        list.Datum = String.Empty;
                    }
                    else { list.Datum = sQLiteDataReader.GetString(1); }
                    if (sQLiteDataReader.IsDBNull(2))
                    {
                        list.Betrag = 0;
                    }
                    else { list.Betrag = sQLiteDataReader.GetInt32(2); }
                    if (sQLiteDataReader.IsDBNull(3))
                    {
                        list.ausgabepfad = String.Empty;
                    }
                    else { list.ausgabepfad = sQLiteDataReader.GetString(3); }
                    lists.Add(list);
                }
                return lists;
            }
            finally
            {
                sql_Command?.Dispose();
                db_Connection?.Dispose();
            }
        }
    }

    #endregion
}
