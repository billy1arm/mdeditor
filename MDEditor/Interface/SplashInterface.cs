using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MDEditor.Database;

namespace MDEditor.Interface
{
    public partial class SplashInterface : Form
    {
        public SplashInterface()
        {
            InitializeComponent();

            SwitchSplash(false);

            DBProfile profile = new DBProfile();
            profile.Handle = "ABC WoW";

            DBProfile profile2 = new DBProfile();
            profile2.Handle = "XAOS WoW";

            DBProfileHandler.Add(profile);
            DBProfileHandler.Add(profile2);
            DBProfileHandler.Save();
        }

        private void i_createFirst_Click(object sender, EventArgs e)
        {

        }

        internal void SwitchSplash(bool hasProfiles)
        {
            foreach (Control control in Controls)
            {
                if (control.Tag is string)
                    control.Visible = (control.Tag as string).ToLower() == "true" && hasProfiles ? true : false;
            }
        }

        private void i_profileSelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            i_deleteButton.Enabled = i_editButton.Enabled = i_profileSelection.SelectedValue != null;
        }
    }
}
