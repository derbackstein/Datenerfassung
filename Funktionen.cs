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
using System.IO;

public class Funktionen
{
    //erstellt und schreibt in die Datei der Beschreibung des Projektes
    public void writeToTxtFile(string strPath, string strText)
    {
        string ausgabepfad = $"H:/WIndowsForms/Datenerfassung/Projekte/{strPath}";
        StreamWriter myWriter = File.CreateText(ausgabepfad);
        myWriter.WriteLine(strText);
        myWriter.Close();
    }

}