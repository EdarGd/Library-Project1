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

namespace AppLayer
{
    public partial class programForm : Form
    {
        private Rectangle[] controlerOriginalRectangle;
        // save pointer to controls
        private Control[] controls;
        private Rectangle originalFormSize;

        public programForm()
        {
            InitializeComponent();
        }

        private void programForm_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Location = new Point(0, 0);
            login.Dock = DockStyle.Fill;
            login.Show();

            HelpFunc.Form_LoadCreateRectangles(ref originalFormSize, ref controls, ref controlerOriginalRectangle, this);
        }

        private void ProgramForm_Resize(object sender, EventArgs e)
        {
            // loop over controls and updates values
            HelpFunc.Form_Resize(controls, controlerOriginalRectangle,originalFormSize,this);

        }
    }
}
