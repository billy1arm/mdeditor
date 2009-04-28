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
    public partial class ParentInterface : Form
    {
        public ParentInterface()
        {
            InitializeComponent();
        }

        void DBProfileHandler_Added(DBProfile obj)
        {
            ToolStripMenuItem newItem = new ToolStripMenuItem(obj.Handle);
            newItem.Tag = obj;
            newItem.Click += new EventHandler(profileItem_Click);

            profilesToolStripMenuItem.DropDownItems.Add(newItem);
        }

        void profileItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            DBProfileEditor profileEditor = new DBProfileEditor((DBProfile)item.Tag);
            profileEditor.MdiParent = this;

            profileEditor.Show();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ParentInterface_Load(object sender, EventArgs e)
        {
            DBProfileHandler.Added += new Action<DBProfile>(DBProfileHandler_Added);
            DBProfileHandler.Removed += new Action<DBProfile>(DBProfileHandler_Removed);

            DBProfileHandler.Load();

            if (DBProfileHandler.Count == 0)
            {
                DialogResult result = MessageBox.Show("You have no database profiles created.\nWould you like to create one now?", "No profiles detected", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBProfileEditor editor = new DBProfileEditor();
                    editor.MdiParent = this;
                    editor.Show();
                }
            }

            CharacterEditorInterface newwindow = new CharacterEditorInterface();
            newwindow.MdiParent = this;
            newwindow.Show();
        }

        void DBProfileHandler_Removed(DBProfile obj)
        {
            profilesToolStripMenuItem.DropDownItems.RemoveByKey(obj.Handle);
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Manager.LogInterface.Visible)
            {
                Manager.LogInterface.Show();
            }
        }
    }
}
