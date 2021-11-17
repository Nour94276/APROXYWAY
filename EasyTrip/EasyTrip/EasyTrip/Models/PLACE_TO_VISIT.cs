using SQLite;
using System;

namespace EasyTrip.Models
{
    public class PLACE_TO_VISIT : ISQLiteTable
    {
        [PrimaryKey, AutoIncrement]
        public int ID_PLace_To_Visit { get; set; }

        [NotNull]
        public String nom_Place_To_Visit { get; set; }

        [NotNull]
        public String GPS { get; set; }
        [NotNull]
        public String City { get; set; }
        [NotNull]
        public String Description { get; set; }
        [NotNull]
        public String img { get; set; }

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