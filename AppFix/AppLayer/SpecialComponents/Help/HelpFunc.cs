using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.StoredProceduresLogic;

namespace AppLayer.SpecialComponents
{
    public class HelpFunc
    {


        public static void playSound(string urlSound)
        {
            SoundPlayer simpleSound = new SoundPlayer(urlSound);
            simpleSound.Stop();
            simpleSound.PlayLooping();
        }


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
            if(controls != null)
            {
                // loop over controls and updates values
                foreach (var (control, index) in controls.Select((value, i) => (value, i)))
                {
                    resizeControl(controlerOriginalRectangle[index], control, originalFormSize, thisObj);
                }
            }
           

        }


        public static void addImgCursor(string url, Size size, Control control)
        {
            Bitmap bitmap = new Bitmap(new Bitmap(url), size);
            control.Cursor = new Cursor(bitmap.GetHicon());
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
            if(ucs.Length != 5)
            {
                MessageBox.Show("The array must contain 4 UC (add, delete, showSearch, showAll, update)");
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

                case "Show All":
                    ucs[2].Show();
                    break;

                case "Show Search":
                    ucs[3].Show();
                    break;

                case "Update":
                    ucs[4].Show();
                    break;
            }
        }

        public static void createCheckComboBoxList(string[] fieldsName,CheckComboBox checkComboBox1,Control[] controls, Control panelShow)
        {
            CheckComboBoxItem[] checkComboBoxItems = new CheckComboBoxItem[fieldsName.Length];
            foreach (var (field, index) in fieldsName.Select((field, index) => (field, index)))
            {
                checkComboBoxItems[index] = new CheckComboBoxItem(field, false);
            }
            checkComboBox1.Items.AddRange(checkComboBoxItems);

            //// wire up the check state changed event
            checkComboBox1.CheckStateChanged += new System.EventHandler((sender, e) => checkComboBox1_CheckStateChanged(sender,e,controls,checkComboBox1.Items.Cast<CheckComboBoxItem>().ToArray(),panelShow));

        }

        private static void showAll(CheckComboBoxItem[] checkComboBox, Boolean showAll)
        {
            foreach (CheckComboBoxItem item in checkComboBox)
            {
                if (item.Text.ToLower() != "all")
                {
                    switch (showAll)
                    {

                        case true:
                            {
                                item.CheckState = true;
                            }
                                
                            break;
                        case false:
                            item.CheckState = false;
                            break;
                    }
                }
                    
            }
        }

        private static void checkComboBox1_CheckStateChanged(object sender, EventArgs e,Control[] controls, CheckComboBoxItem[] checkComboBoxItems, Control panelShow)
        {
            if (sender is CheckComboBoxItem)
            {
                CheckComboBoxItem item = (CheckComboBoxItem)sender;
                MessageBox.Show(item.Text);
                MessageBox.Show(item.CheckState.ToString());
                if(item.Text.ToLower() == "all")
                {
                    showAll(checkComboBoxItems,item.CheckState);
                }
                foreach(Control control in controls)
                {
                    if (item.Text.ToLower() == "all")
                    {
                        switch (item.CheckState)
                        {
                            case true:
                                control.Show();
                                control.Tag = "show";
                                break;
                            case false:
                                control.Hide();
                                control.Tag = "hide";
                                break;
                        }
                    }
                    // name control must start with panel
                    // name CheckComboBoxItem maybe have space
                    else if (control.Name.ToLower().Split("panel")[1] == item.Text.Replace(" ", "").ToLower())
                    {
                        if (item.CheckState)
                        {
                            control.Show();
                            control.Tag = "show";
                        }
                        if (!item.CheckState)
                        {
                            control.Hide();
                            control.Tag = "hide";
                        }

                        foreach (CheckComboBoxItem removeMark in checkComboBoxItems)
                        {
                            if (removeMark.Text.ToLower() == "all" && removeMark.CheckState)
                            {
                                removeMark.CheckState = false;
                            }
                        }
                    }
                }
                //foreach
                //switch (item.Text)
                //{
                //    case "One":
                //        //checkBox1.Checked = item.CheckState;
                //        break;
                //    case "Two":
                //        //checkBox2.Checked = item.CheckState;
                //        break;
                //    case "Three":
                //        //checkBox3.Checked = item.CheckState;
                //        break;
                //}

                int countControlShow = 0;
                foreach(Control control in controls)
                {
                    if(control.Name.ToLower() != "panelaction" && control.Tag.ToString() == "show")
                    {
                        countControlShow++;
                    }
                }
                if(countControlShow > 0)
                {
                    panelShow.Show();
                }
                else
                {
                    panelShow.Hide();
                }
            }
        }


        public static void checkAndSetError(Control insertErrNext, string? checkRes,ErrorProvider err)
        {
            if (checkRes != null)
            {
                err.SetError(insertErrNext, checkRes);
            }
            else
            {
                err.SetError(insertErrNext, String.Empty);
            }
        }
    }
}
