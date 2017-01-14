using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Semestralka
{
    class Prikazy
    {
        Databaze databaze = new Databaze();
        SQLiteConnection pripojeni = new SQLiteConnection();



        public bool CreateTabulka()
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                string vytvoreni = "CREATE TABLE IF NOT EXISTS jidlo (jmeno TEXT UNIQUE, proteiny INT, sacharidy INT, tuky INT)";
                SQLiteCommand prikaz = new SQLiteCommand(vytvoreni, pripojeni);
                prikaz.ExecuteNonQuery();
                pripojeni.Close();
                return true;
            }
            catch
            {
                pripojeni.Close();
                return false;
            }
        }

        public bool Insert(string jmeno, string proteiny, string sacharidy, string tuky)
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                string insert = "INSERT INTO jidlo (jmeno, proteiny, sacharidy, tuky) VALUES ('" +
                    jmeno.ToLower() + "','" + proteiny + "','" + sacharidy + "','" + tuky + "')";
                SQLiteCommand prikaz = new SQLiteCommand(insert, pripojeni);
                prikaz.ExecuteNonQuery();
                pripojeni.Close();
                return true;
            }
            catch
            {
                pripojeni.Close();
                return false;
            }
            
        }

        public bool KontrolaJidla (string jmeno)
        {

        }

        }
}
