using System;
using System.Collections.Generic;
using System.Text;

namespace EasyTrip.Models
{
    class DataBase : SqliteDatabase
    {
        private static DataBase INSTANCE = null;

        private List<M_User> _Items;

        // prgrès en cous
        public double CurrentProgress { get; set; } = 1;

        //Mise à jour en cours
        public bool UpdateRunning { get; set; } = false;

        // Réseau perdu
        public bool LostNetwork { get; set; } = false;

        //Envoyer les visiteurs en attente est en cours d'exécution
        public bool SendWaitingVisitorsIsRunning { get; set; } = false;

        ////Relancer l'envoi des visiteurs en attente
        public bool ReLaunchSendWaitingVisitors { get; set; } = false;

        protected DataBase()
        {
        }

        public static DataBase GetInstance()
        {
            if (DataBase.INSTANCE == null)
                INSTANCE = new DataBase();
            return INSTANCE;
        }
    }
}