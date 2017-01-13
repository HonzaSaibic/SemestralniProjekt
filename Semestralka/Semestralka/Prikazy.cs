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

        public bool tabulka()
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

        public bool insert(string jmeno, string proteiny, string sacharidy, string tuky)
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
        public void select ()
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            string select = "SELECT * FROM jidlo ";
            SQLiteCommand prikaz = new SQLiteCommand(select, pripojeni);
            SQLiteDataReader reader = prikaz.ExecuteReader();
            while (reader.Read())
            {
                
            }
            
            
            //return jmeno + proteiny + sacharidy + tuky;
        }
       
    }
}
