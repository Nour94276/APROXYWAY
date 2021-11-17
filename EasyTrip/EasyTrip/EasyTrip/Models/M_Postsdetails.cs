using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyTrip.Models
{
    public class M_Postsdetails : ISQLiteTable
    {
        [PrimaryKey, AutoIncrement]
        public int ID_PLace_To_Visit_details { get; set; }

        [NotNull]
        public String nom_Place_To_Visit_details { get; set; }

        [NotNull]
        public String GPS { get; set; }
        [NotNull]
        public String City { get; set; }
        [NotNull]
        public String Description { get; set; }

        public void CheckExistence()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }
    }
}
