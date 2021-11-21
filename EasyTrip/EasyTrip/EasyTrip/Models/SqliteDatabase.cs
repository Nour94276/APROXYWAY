using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace EasyTrip.Models
{
    public abstract class SqliteDatabase
    {
        public static string sqliteFilename = "UserList.db3";
        protected string Path { get; }

        public List<Type> Tables { get; set; } = new List<Type>();

        protected SQLiteConnection db;
        protected SqliteDatabase()
        {
            string libraryPath = "";
            if (Device.RuntimePlatform == Device.Android)
                libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            else if (Device.RuntimePlatform == Device.iOS)
            {
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
                libraryPath = System.IO.Path.Combine(documentsPath, "..", "Library");          //string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            }

            try
            {
                Path = System.IO.Path.Combine(libraryPath, sqliteFilename);
                db = new SQLiteConnection(Path);

                Console.WriteLine(Path);
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public SQLiteConnection GetConnection()
        {
            return db;
        }

        public int Insert<T>(T item)
        {
            return db.Insert(item);
        }

        public int Update<T>(T item)
        {
            return db.Update(item);
        }

        public void AddTable(Type tableType)
        {
            Tables.Add(tableType);
        }

        public void CreateTables()
        {
            foreach (Type tableType in Tables)
            {
                ((ISQLiteTable)Activator.CreateInstance(tableType)).Init();
            }
        }

        public void CheckExistence()
        {
            foreach (Type tableType in Tables)
                ((ISQLiteTable)Activator.CreateInstance(tableType)).CheckExistence();
        }
    }
}
