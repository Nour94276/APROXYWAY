namespace EasyTrip.Models
{
    interface ISQLiteTable
    {
        void Init();

        void CheckExistence();
    }
}