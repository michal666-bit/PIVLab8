using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PIVLab8.Model
{
    class Database
    {
        public bool AddUser(UserAccount userAccount)
        {
            MessageBox.Show("Użytkownik został dodany do bazy danych", "Powodzenie", MessageBoxButton.OK, MessageBoxImage.Information);
            return true;
        }
    }
}
