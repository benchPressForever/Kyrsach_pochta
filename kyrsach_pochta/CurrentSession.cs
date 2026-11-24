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
        public static bool IsclientLoggedIn => Client != null;

        public static EmployeeInfo Employee { get; private set; }
        public static bool IsEmployeeLoggedIn => Employee != null;

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

        public static void LoginEmployee(kyrsachDataSet.СотрудникRow row)
{
    Employee = new EmployeeInfo
    {
        Id = row.Код_сотрудника,
        Fio = row.ФИО,
        Role = row.Должность,
        Login = row.Логин
    };
}

        public static void Logout() {
            Client = null;
            Employee = null;
        }


    }
}
