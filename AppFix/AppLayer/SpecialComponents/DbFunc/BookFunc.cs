using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.SpecialComponents
{
    public class BookFunc
    {
        private static BookLogic bookLogic = new BookLogic();

        public static void deleteSelectedBook(string code)
        {
            MessageBox.Show(bookLogic.deleteSelectedBook(code));
        }
    }
}
