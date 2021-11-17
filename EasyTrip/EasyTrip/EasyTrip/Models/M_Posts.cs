using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyTrip.Models
{
    public class M_Posts : ISQLiteTable
    {
        public M_Posts(int iD_User)
        {
            ID_Posts = iD_User;
        }

        public M_Posts()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID_Posts { get; set; }

        [NotNull]
        public List<PLACE_TO_VISIT> Place_To_Visit { get; set; }

        [NotNull]
        public String Town { get; set; }
        [NotNull]
        public String City { get; set; }
        [NotNull]
        public String Description { get; set; }
        [NotNull]
        public String GPS { get; set; }
        public string img { get; set;  }
        public void CheckExistence()
        {
            SqliteDatabase db = DataBase.GetInstance();
            var tableExistsQuery = "SELECT * FROM sqlite_master where name = 'M_Posts';";
            var result = db.GetConnection().ExecuteScalar<string>(tableExistsQuery);

            if (result == null)
                throw new Exception("La table M_Posts n'existe pas.");
        }

        public void Init()
        {
            SqliteDatabase db = DataBase.GetInstance();
            db.GetConnection().DropTable<M_Posts>();
            db.GetConnection().CreateTable<M_Posts>();
        }
    }
}
