using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Semestralka
{
    class Databaze
    {

        public string ulozeniDatabaze()
        {
            string soubor = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);           
            return "Data Source=" + soubor + "\\Jidla.sqlite; Version=3; New=True";
        }      
    }
}
