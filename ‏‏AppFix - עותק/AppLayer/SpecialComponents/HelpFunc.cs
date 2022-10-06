using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.SpecialComponents
{
    public class HelpFunc
    {



        private static void resizeControl(Rectangle r, Control c, Rectangle originalFormSize, object thisObj)
        {
            float xRatio;
            float yRatio;
            if(thisObj == null)
            {
                return;
            }
            else if (thisObj.GetType().BaseType.Name == "Form")
            {
                Form thisForm = (Form)thisObj;
                xRatio  = (float)(thisForm.Width) / (float)(originalFormSize.Width);
                yRatio = (float)(thisForm.Height) / (float)(originalFormSize.Height);
            }
            else if (thisObj.GetType().BaseType.Name == "UserControl")
            {
                UserControl thisUC = (UserControl)thisObj;
                xRatio = (float)(thisUC.Width) / (float)(originalFormSize.Width);
                yRatio = (float)(thisUC.Height) / (float)(originalFormSize.Height);
            }
            else
            {
                return;
            }
            

            int newX = (int)(r.Location.X * xRatio);
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        public  static void Form_Resize(Control[] controls , Rectangle [] controlerOriginalRectangle,Rectangle originalFormSize,object thisObj)
        {
            // loop over controls and updates values
            foreach (var (control, index) in controls.Select((value, i) => (value, i)))
            {
                resizeControl(controlerOriginalRectangle[index], control, originalFormSize, thisObj);
            }

        }

        public static void Form_LoadCreateRectangles(ref Rectangle originalFormSize, ref Control[] controls, ref Rectangle[] controlerOriginalRectangle, object thisObj)
        {


            if (thisObj.GetType().BaseType.Name == "Form")
            {
                Form  thisForm = (Form)thisObj;
                originalFormSize = new Rectangle(thisForm.Location.X, thisForm.Location.Y, thisForm.Size.Width, thisForm.Size.Height);

                controlerOriginalRectangle = new Rectangle[thisForm.Controls.Count];
                controls = new Control[thisForm.Controls.Count];
                // copy all collection to array from 0
                thisForm.Controls.CopyTo(controls, 0);
            }
              
            else if(thisObj.GetType().BaseType.Name == "UserControl")
            {
                UserControl thisForm = (UserControl)thisObj;
                originalFormSize = new Rectangle(thisForm.Location.X, thisForm.Location.Y, thisForm.Size.Width, thisForm.Size.Height);

                controlerOriginalRectangle = new Rectangle[thisForm.Controls.Count];
                controls = new Control[thisForm.Controls.Count];
                // copy all collection to array from 0
                thisForm.Controls.CopyTo(controls, 0);

            }

            else
            {
                return ;
            }
           

            //// Loop over tuples with the item and its index
            foreach (var (control, index) in controls.Select((value, i) => (value, i)))
            {
                controlerOriginalRectangle[index] = new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height);
            }

        }

        // Allow Combo Box to center aligned
        public static void cbxDesign_DrawItem(ref object sender, ref DrawItemEventArgs e)
        {
            // By using Sender, one method could handle multiple ComboBoxes
            ComboBox cbx = sender as ComboBox;
            if (cbx != null)
            {
                // Always draw the background
                e.DrawBackground();

                // Drawing one of the items?
                if (e.Index >= 0)
                {
                    // Set the string alignment.  Choices are Center, Near and Far
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    // Set the Brush to ComboBox ForeColor to maintain any ComboBox color settings
                    // Assumes Brush is solid
                    Brush brush = new SolidBrush(cbx.ForeColor);

                    // If drawing highlighted selection, change brush
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;

                    // Draw the string
                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }

        public static void hideAndShowUC(UserControl[] ucs, string kindAction,Form form)
        {
            if(ucs.Length != 4)
            {
                MessageBox.Show("The array must contain 4 UC (add, delete, show, update)");
                return;
            }
            foreach (UserControl uc in ucs)
            {
                uc.Size = new Size(uc.Parent.Width - 50, uc.Height);
                uc.Location = new Point((form.Width - uc.Width) / 2 - 10, (form.Height - uc.Height) / 2 - 30);
                uc.Hide();
            }

            switch (kindAction)
            {
                case "Add":
                    ucs[0].Show();
                    break;

                case "Delete":
                    ucs[1].Show();
                    break;

                case "Show":
                    ucs[2].Show();
                    break;

                case "Update":
                    ucs[3].Show();
                    break;
            }
        }

    }
}
