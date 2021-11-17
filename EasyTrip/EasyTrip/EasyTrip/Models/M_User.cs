using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using SQLite;


namespace EasyTrip.Models
{
    public class M_User : ISQLiteTable
    {
        public M_User(int iD_User)
        {
            ID_User = iD_User;
        }

        public M_User()
        {
        }

        [PrimaryKey, AutoIncrement]
        public int ID_User { get; set; }

        [NotNull]
        public String User_nom { get; set; }

        [NotNull]
        public String User_prenom { get; set; }
        [NotNull]
        public String User_mail { get; set; }
        [NotNull]
        public String User_mdp { get; set; }
      

        public void CheckExistence()
        {
            SqliteDatabase db = DataBase.GetInstance();
            var tableExistsQuery = "SELECT * FROM sqlite_master where name = 'M_User';";
            var result = db.GetConnection().ExecuteScalar<string>(tableExistsQuery);

            if (result == null)
                throw new Exception("La table M_User n'existe pas.");
        }

        public void Init()
        {
            SqliteDatabase db = DataBase.GetInstance();
            db.GetConnection().DropTable<M_User>();
            db.GetConnection().CreateTable<M_User>();
        }
        public void Insert()
        {
            SqliteDatabase db = DataBase.GetInstance();

            db.Insert<M_User>(this);
        }
        public List<M_User> CheckExistanceUser(string UserMail, string UserMDP)
        {
            var email = UserMail;
            var mdp = UserMDP;
            SqliteDatabase db = DataBase.GetInstance();
            var sqlite = "Select * from M_User where User_mail = '" + email + "' and User_mdp = '" + mdp + "'";
            List<M_User> m_Users = db.GetConnection().Query<M_User>(sqlite);
            return m_Users;
        }
        public bool checkExistanceEmail(string UserMail)
        {
            bool _exist = false;
            var _UserMail = UserMail;
            var sqlite = "Select * from M_User where User_mail = '" + _UserMail + "'";
            SqliteDatabase db = DataBase.GetInstance();
            List<M_User> m_Users = db.GetConnection().Query<M_User>(sqlite);
            if (m_Users.Count != 0) { _exist = true; };
            return _exist;
        }
        public static List<M_User> GetList(string UserMail)
        {
            SqliteDatabase db = DataBase.GetInstance();
            List<M_User> _toBeSent = db.GetConnection().Query<M_User>($"Select * from M_User where User_mail = '" + UserMail + "'");
            return _toBeSent;
        }
    }
}