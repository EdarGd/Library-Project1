using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.SpecialComponents
{
    public class BorrowFunc
    {
        private static Borrowlogic borrowLogic = new Borrowlogic();

        public static void deleteSelectedBorrow(string code)
        {
            MessageBox.Show(borrowLogic.deleteSelectedBorrow(code));
        }
    }
}
