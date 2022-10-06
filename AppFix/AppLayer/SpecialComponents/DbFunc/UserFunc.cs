using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayer.StoredProceduresLogic;
    
namespace AppLayer.SpecialComponents
{
    public class UserFunc
    {
        private static UserLogic userLogic = new UserLogic();

        public static void deleteSelectedUser(string id)
        {
            MessageBox.Show(userLogic.deleteSelectedUser(id));
        }
    }
}
