using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimTravel.DAL
{
    public static class AppConfig
    {
        private static string DataSource = "103.53.231.198";
        private static string DataBase = "KimTravelDesktop";
        private static string UserID = "hoang1995";
        private static string Password = "Hoang911";

        private static string ConnectionString
        {
            get
            {
                //Data Source=103.53.231.198;Initial Catalog=KimTravelDesktop;Persist Security Info=True;User ID=hoang1995
                //Data Source=103.53.231.198;Initial Catalog=KimTravelDesktop;Persist Security Info=True;User ID=hoang1995;Password=Hoang911
                return "Data Source=" + DataSource + ";Initial Catalog=" + DataBase + ";Persist Security Info=True;User ID=" + UserID + ";Password=" + Password + "";
            }
        }

        private static string ConnectionStringLocal
        {
            get
            {
                //Data Source=103.53.231.198;Initial Catalog=KimTravelDesktop;Persist Security Info=True;User ID=hoang1995
                //Data Source=103.53.231.198;Initial Catalog=KimTravelDesktop;Persist Security Info=True;User ID=hoang1995;Password=Hoang911
                //Data Source=.\SQLEXPRESS;Initial Catalog=KimTravelDesktop;User ID=sa;Password=Hoang911
                return @"Data Source=.\SQLEXPRESS;Initial Catalog=KimTravelDesktop;User ID=sa;Password=Hoang911";
            }
        }

        public static string getStringConnection()
        {
            bool isLocal = true;
            if (isLocal)
                return ConnectionStringLocal;
            else
                return ConnectionString;
        }
    }
}
