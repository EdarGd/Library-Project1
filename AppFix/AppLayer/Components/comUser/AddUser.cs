﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLayer.Components.comUser
{
    public partial class AddUser : UserControl
    {
        public AddUser()
        {
            InitializeComponent();
            type.SelectedIndex = 1;
        }

    }
}
