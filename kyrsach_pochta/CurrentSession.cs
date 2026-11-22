using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsach_pochta
{
    internal class CurrentSession
    {
        public static ClientInfo Client { get; private set; }
        public static bool IsLoggedIn => Client != null;

        public static void LoginClient(kyrsachDataSet.КлиентRow row)
        {
            Client = new ClientInfo
            {
                Id = row.Код_клиента,
                Fio = row.ФИО,
                Email = row.Электронная_почта,
                Phone = row.Телефон
            };
        }

        public static void Logout() => Client = null;


    }
}
