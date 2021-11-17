using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyTrip.Models
{
    public class town : ISQLiteTable
    {


        [PrimaryKey, AutoIncrement]
        public int ID_Town { get; set; }

        [NotNull]
        public String town_nom{ get; set; }

        [NotNull]
        public String town_gps { get; set; }
        [NotNull]
        public String town_img { get; set; }

        public void CheckExistence()
        {
            SqliteDatabase db = DataBase.GetInstance();
            var tableExistsQuery = "SELECT * FROM sqlite_master where name = 'town';";
            var result = db.GetConnection().ExecuteScalar<string>(tableExistsQuery);

            if (result == null)
                throw new Exception("La table town n'existe pas.");
        }

        public void Init()
        {
            SqliteDatabase db = DataBase.GetInstance();
            db.GetConnection().DropTable<town>();
            db.GetConnection().CreateTable<town>();
        }
    }
}
