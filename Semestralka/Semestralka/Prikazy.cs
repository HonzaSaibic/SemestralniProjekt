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


        // Vytvoreni tabulky v databazi, pokud jeste neexistuje
        public bool CreateTabulka()
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                string vytvoreniJidla = "CREATE TABLE IF NOT EXISTS jidlo (jmeno TEXT UNIQUE, proteiny INT, sacharidy INT, tuky INT)";
                SQLiteCommand prikaz = new SQLiteCommand(vytvoreniJidla, pripojeni);
                prikaz.ExecuteNonQuery();

                string vytvoreniDennihoPrijmu = "CREATE TABLE IF NOT EXISTS denniPrijem (id PRIMARY KEY, proteiny INT, sacharidy INT, tuky INT)";
                SQLiteCommand prikaz2 = new SQLiteCommand(vytvoreniDennihoPrijmu, pripojeni);
                prikaz2.ExecuteNonQuery();

                string vytvoreniAktualnihoPrijmu = "CREATE TABLE IF NOT EXISTS aktualniPrijem (id PRIMARY KEY, proteiny INT, sacharidy INT, tuky INT)";
                SQLiteCommand prikaz3 = new SQLiteCommand(vytvoreniAktualnihoPrijmu, pripojeni);
                prikaz3.ExecuteNonQuery();

                pripojeni.Close();
                return true;
            }
            catch
            {
                pripojeni.Close();
                return false;
            }

        }

        // Prikaz pro vlozeni do tabulky.
        public bool InsertJidlo(string jmeno, string proteiny, string sacharidy, string tuky)
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

        public bool KontrolaJidla(string jmeno)
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM jidlo WHERE jmeno='" + jmeno + "'", pripojeni);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    pripojeni.Close();
                    return true;
                }
                else
                {
                    pripojeni.Close();
                    return false;
                }
            }
            finally
            {
                pripojeni.Close();
            }          
        }

        public void InsertDenniPrijem (int proteiny, int sacharidy, int tuky)
        {
            try
            {
                pripojeni.ConnectionString = databaze.ulozeniDatabaze();
                pripojeni.Open();
                string insert = "INSERT INTO denniPrijem (id, proteiny, sacharidy, tuky) VALUES (1," + proteiny + "," + sacharidy + "," + tuky + ")";
                SQLiteCommand prikaz = new SQLiteCommand(insert, pripojeni);
                prikaz.ExecuteNonQuery();
                pripojeni.Close();
            }
            finally
            {
                pripojeni.Close();
            }
        }

        public void InsertAktualniPrijem(int proteiny, int sacharidy, int tuky)
        {
            try
            {
                pripojeni.ConnectionString = databaze.ulozeniDatabaze();
                pripojeni.Open();
                string insert = "INSERT INTO aktualniPrijem (id, proteiny, sacharidy, tuky) VALUES (1," + proteiny + "," + sacharidy + "," + tuky + ")";
                SQLiteCommand prikaz = new SQLiteCommand(insert, pripojeni);
                prikaz.ExecuteNonQuery();
                pripojeni.Close();
            }
            finally
            {
                pripojeni.Close();
            }
        }

        public void VymazaniPoslednihoPrijmu()
        {
            try
            {
                pripojeni.ConnectionString = databaze.ulozeniDatabaze();
                pripojeni.Open();
                string delete = "DELETE FROM denniPrijem WHERE id=1";
                SQLiteCommand prikaz = new SQLiteCommand(delete, pripojeni);
                prikaz.ExecuteNonQuery();
                pripojeni.Close();
            }
            finally
            {
                pripojeni.Close();
            }
        }

        public void VymazaniAktualnihoPrijmu()
        {
            try
            {
                pripojeni.ConnectionString = databaze.ulozeniDatabaze();
                pripojeni.Open();
                string delete = "DELETE FROM aktualniPrijem WHERE id=1";
                SQLiteCommand prikaz = new SQLiteCommand(delete, pripojeni);
                prikaz.ExecuteNonQuery();
                pripojeni.Close();
            }
            finally
            {
                pripojeni.Close();
            }
        }

        public void NahraniDenniPrijmu()
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                string select = "SELECT * FROM denniPrijem";
                SQLiteCommand vyber = new SQLiteCommand(select, pripojeni);
                SQLiteDataReader reader = vyber.ExecuteReader();
                while (reader.Read())
                {
                    ObjektDenniPrijem.proteiny = Convert.ToInt32(reader["proteiny"]);
                    ObjektDenniPrijem.sacharidy = Convert.ToInt32(reader["sacharidy"]);
                    ObjektDenniPrijem.tuky = Convert.ToInt32(reader["tuky"]);
                }
                pripojeni.Close();
            }
            finally
            {
                pripojeni.Close();
            }

        }

        public void NahraniAktualnihoPrijmu()
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                string select = "SELECT * FROM aktualniPrijem";
                SQLiteCommand vyber = new SQLiteCommand(select, pripojeni);
                SQLiteDataReader reader = vyber.ExecuteReader();
                while (reader.Read())
                {
                    ObjektAktualniPrijem.proteiny = Convert.ToInt32(reader["proteiny"]);
                    ObjektAktualniPrijem.sacharidy = Convert.ToInt32(reader["sacharidy"]);
                    ObjektAktualniPrijem.tuky = Convert.ToInt32(reader["tuky"]);
                }
                pripojeni.Close();
            }
            finally
            {
                pripojeni.Close();
            }
        }

        public void NahraniVybranehoJidla(string jmeno)
        {
            pripojeni.ConnectionString = databaze.ulozeniDatabaze();
            pripojeni.Open();
            try
            {
                string select = "SELECT * FROM jidlo WHERE jmeno='" + jmeno + "'";
                SQLiteCommand vyber = new SQLiteCommand(select, pripojeni);
                SQLiteDataReader reader = vyber.ExecuteReader();
                while (reader.Read())
                {
                    ObjektAktualniPrijem.pridanyProteiny = Convert.ToInt32(reader["proteiny"]);
                    ObjektAktualniPrijem.pridanySacharidy = Convert.ToInt32(reader["sacharidy"]);
                    ObjektAktualniPrijem.pridanyTuky = Convert.ToInt32(reader["tuky"]);
                }
                pripojeni.Close();
            }
            finally
            {
                pripojeni.Close();
            }
        }

    }
}
