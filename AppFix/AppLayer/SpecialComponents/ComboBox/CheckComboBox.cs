using System.Windows.Forms.VisualStyles;

namespace AppLayer.SpecialComponents
{

    /// <summary>
    /// as ComboBox 
    /// Create functions to DrawItem and SelectedIndexChanged events
    /// Creates the combo box drop-down
    /// The contents of the dropdown are rendered using the
    /// CheckBoxRenderer class.
    /// The information of the combo box  is updated according to the CheckComboBox_DrawItem() in our class
    /// </summary>
    public partial class CheckComboBox : ComboBox
    {

        public CheckComboBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DrawItem += new DrawItemEventHandler(CheckComboBox_DrawItem);
            this.SelectedIndexChanged += new EventHandler(CheckComboBox_SelectedIndexChanged);
        }

        void CheckComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxItem item = (CheckComboBoxItem)SelectedItem;
            item.CheckState = !item.CheckState;
            if (CheckStateChanged != null)
                CheckStateChanged(item, e);
        }

        //Will fire when the list updates its content
        void CheckComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // make sure the index is valid (sanity check)
            if (e.Index == -1)
            {
                return;
            }

            // test the item to see if its a CheckComboBoxItem
            if (!(Items[e.Index] is CheckComboBoxItem))
            {
                // it's not, so just render it as a default string
                e.Graphics.DrawString(
                    Items[e.Index].ToString(),
                    this.Font,
                    Brushes.Black,
                    new Point(e.Bounds.X, e.Bounds.Y));
                return;
            }

            // get the CheckComboBoxItem from the collection
            CheckComboBoxItem box = (CheckComboBoxItem)Items[e.Index];

            // render it
            CheckBoxRenderer.RenderMatchingApplicationState = true;
            CheckBoxRenderer.DrawCheckBox(
                e.Graphics,
                new Point(e.Bounds.X, e.Bounds.Y),
                e.Bounds,
                box.Text,
                this.Font,
                (e.State & DrawItemState.Focus) == 0,
                box.CheckState ? CheckBoxState.CheckedNormal : CheckBoxState.UncheckedNormal);
        }

        /// will run when we change the check box item in the drop-down list
        public event EventHandler CheckStateChanged;

    }
}
