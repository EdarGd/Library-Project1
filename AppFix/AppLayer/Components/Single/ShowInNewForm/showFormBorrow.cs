using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLayer.Components.Single.Show
{
    public partial class showFormBorrow : Form
    {
        public showFormBorrow(DataAccessLayer.Entities.Borrow borrow)
        {
            InitializeComponent();
            code.Text = borrow.Code;
            id.Text = borrow.Id;
        }
    }
}
