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

namespace AppLayer.Components.comExistingCategories
{
    public partial class AreaExistingCategories : Form
    {
        public AreaExistingCategories(string kindAction)
        {
            InitializeComponent();
            //UserControl[] UCs = { addExistingCategories1, deleteExistingCategories1, showExistingCategories1, updateExistingCategories1 };
            //HelpFunc.hideAndShowUC(UCs, kindAction, (Form)this.Parent);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
