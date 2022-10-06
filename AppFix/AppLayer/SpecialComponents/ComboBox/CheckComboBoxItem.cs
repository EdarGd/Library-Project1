using System.ComponentModel;

namespace AppLayer.SpecialComponents
{
    /// <summary>
    /// from list items to combo box
    /// </summary>
    public class CheckComboBoxItem
    {
       
        public CheckComboBoxItem(string text, bool initialCheckState)
        {
            _checkState = initialCheckState;
            _text = text;
        }

        #region Get and Set to Properties

        //Properties - CheckState

        [Category("CheckComboBoxItem Get_Set_Fun")]
        private bool _checkState = false;
        public bool CheckState
        {
            get { return _checkState; }
            set { _checkState = value; }
        }

        //Properties - Text

        [Category("CheckComboBoxItem Get_Set_Fun")]
        private string _text = "";
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        //Properties - Tag

        [Category("CheckComboBoxItem Get_Set_Fun")]
        private object _tag = null;
        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        // Happens after selecting CheckComboBoxItem from the list items
        public override string ToString()
        {
            //return Text;
            return "Select Search Options";
        }

        #endregion

    }

}