using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer.SpecialComponents;

namespace AppLayer.Components.comBorrow
{
    public partial class AreaBorrow : Form
    {
        public AreaBorrow(string kindAction)
        {
            InitializeComponent();
            //UserControl[] UCs = { addBorrow1, deleteBorrow1, showBorrow1, updateBorrow1 };
            //HelpFunc.hideAndShowUC(UCs, kindAction, (Form)this.Parent);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
