using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MDEditor.Interface
{
    public partial class EnableDisableCheckbox : CheckBox
    {
        private TextBox[] m_boxes;
        private bool m_enabledWhenChecked;

        public EnableDisableCheckbox()
        {
            m_boxes = new TextBox[0];
            m_enabledWhenChecked = true;
        }

        public bool EnabledWhenChecked
        {
            get { return m_enabledWhenChecked; }
            internal set { m_enabledWhenChecked = value; }
        }

        public TextBox[] Boxes
        {
            get { return m_boxes; }
            internal set { m_boxes = value; }
        }

        public EnableDisableCheckbox(bool enabledWhenChecked, params TextBox[] boxes)
        {
            m_boxes = boxes;
            m_enabledWhenChecked = enabledWhenChecked;
            InitializeComponent();
        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            foreach (TextBox box in m_boxes)
                box.Enabled = m_enabledWhenChecked ? Checked : !Checked;
            base.OnCheckedChanged(e);
        }
    }
}
