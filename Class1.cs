using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenerfassung
{
    public class Zustande
    {
         public int Zeile { get; set; }
    }
    /// <summary>
    /// Klasse für die RECHNUNGEN
    /// </summary>
    public class RechnungClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Betrag { get; set; }
        public string Datum { get; set; }
        public string RechnungName { get; set; }
        public string ausgabepfad { get; set; }
    }
    /// <summary>
    /// Klasse für Login
    /// </summary>
    public class MitarbeiterLogin
    {
        public string Name { get; set; }
        public string Passwort { get; set; }
        public string Tabellenname { get; set; }
    }

    public class ZeiterfassungClass
    {
        public string Projekt { get; set; }
        public string Beschreibung { get; set; }
        public string Stunden { get; set; }
        public int von { get; set; }
        public int bis { get; set; }
        public int Datum { get; set; }
        public int ID { get; set; }

    }
    public class Projekterfassung
    {
        public int ID { get; set; }
        public string ZugewiesenAn { get; set; }
        public string Ersteller { get; set; }
        public string AbschlussDatum { get; set; }
        public string Zustand { get; set; }
        
        public string FileName { get; set; }
        public string Beschreibung { get; set; }
    }
}
