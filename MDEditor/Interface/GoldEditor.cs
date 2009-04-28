using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MDEditor.Interface
{
    public partial class GoldEditor : UserControl
    {
        public GoldEditor()
        {
            InitializeComponent();
        }

        public int Copper
        {
            get { return (int)i_goldNumeric.Value * 10000 + (int)i_silverNumeric.Value * 100 + (int)i_copperNumeric.Value; }
            set
            {
                i_copperNumeric.Value = value % 100;
                i_silverNumeric.Value = (value % 10000 - i_copperNumeric.Value) / 100;
                i_goldNumeric.Value = (value % 1000000 - i_silverNumeric.Value) / 10000;
            }
        }
    }
}
