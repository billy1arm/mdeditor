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

            DBProfileHandler.NoProfiles += new Action(DBProfileHandler_NoProfiles);
            DBProfileHandler.ProfilesAvaliable += new Action(DBProfileHandler_ProfilesAvaliable);
            DBProfileHandler.Added += new Action<DBProfile>(DBProfileHandler_Added);
            DBProfileHandler.Removed += new Action<DBProfile>(DBProfileHandler_Removed);

            DBProfileHandler.Load();
        }

        void DBProfileHandler_Removed(DBProfile obj)
        {
            i_profileSelection.Items.Remove(obj);
        }

        void DBProfileHandler_Added(DBProfile obj)
        {
            i_profileSelection.Items.Add(obj);
        }

        void DBProfileHandler_ProfilesAvaliable()
        {
            SwitchSplash(true);
        }

        void DBProfileHandler_NoProfiles()
        {
            SwitchSplash(false);
        }

        private void i_createFirst_Click(object sender, EventArgs e)
        {

        }

        internal void SwitchSplash(bool hasProfiles)
        {
            foreach (Control control in Controls)
            {
                if (control.Tag is string)
                    control.Visible = ((control.Tag as string).ToLower() == "true" && hasProfiles) || (control.Tag as string).ToLower() == "false" && !hasProfiles ? true : false;
            }
        }

        private void i_profileSelection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            i_deleteButton.Enabled = i_editButton.Enabled = i_profileSelection.SelectedItem != null;
        }

        private void i_editButton_Click(object sender, EventArgs e)
        {

        }

        private void i_deleteButton_Click(object sender, EventArgs e)
        {
            if (i_profileSelection.SelectedItem != null && i_profileSelection.SelectedItem is DBProfile)
            {
                DBProfileHandler.Remove(i_profileSelection.SelectedItem as DBProfile);
                DBProfileHandler.Save();
            }
        }
    }
}
