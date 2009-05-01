using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MDEditor.Database;
using MDEditor.Interface.Attributes;

namespace MDEditor.Interface
{
    [RequirementClass]
    [ObjectToObjectClass]
    public partial class DBProfileEditor : Form
    {
        [ObjectToObjectTarget]
        private DBProfile m_profile;
        private ObjectToObjectClass m_otoClass;
        private RequirementClass m_rClass;

        public DBProfileEditor()
        {
            m_profile = new DBProfile();
            InitializeComponent();
            Initialize();
        }

        public DBProfileEditor(DBProfile profile)
        {
            m_profile = profile;
            InitializeComponent();
            Initialize();
        }

        private void Save()
        {
            if (m_otoClass != null && m_rClass != null)
            {
                if (m_rClass.MeetsRequirement)
                {
                    m_otoClass.SaveValues();

                    if (!m_profile.Saved)
                    {
                        DBProfileHandler.Add(m_profile);
                    }

                    DBProfileHandler.Save();
                }
                else
                {
                    MessageBox.Show("You have not filled out all the required fields", "Incomplete form", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("There was an error saving this profile", "Save error", MessageBoxButtons.OK);
                Close();
            }
        }

        private void Initialize()
        {
            foreach (DatabaseType dbType in Enum.GetValues(typeof(DatabaseType)))
            {
                i_accountSqlType.Items.Add(dbType);
                i_worldSqlType.Items.Add(dbType);
                i_characterSqlType.Items.Add(dbType);
            }

            m_otoClass = Manager.OTOScan(this);
            m_rClass = Manager.RequirementScan(this);

            if (m_otoClass != null)
            {
                m_otoClass.GetValues();
            }
        }

        private void i_saveButton_Click(object sender, EventArgs e)
        {
            //Need checking here but for now we will just save

            Save();
        }

        private void i_connectButton_Click(object sender, EventArgs e)
        {
            if (m_otoClass != null && m_rClass != null)
            {
                m_otoClass.SaveValues();

                if (m_rClass.MeetsRequirement)
                {
                    try
                    {
                        m_profile.Connect();
                    }
                    catch (Exception error)
                    {
                        if (error.InnerException != null)
                            MessageBox.Show(error.InnerException.Message, "Error connecting", MessageBoxButtons.OK);
                        else
                            MessageBox.Show(error.Message, "Error connecting", MessageBoxButtons.OK);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out all required fields before trying to connect.", "Incomplete form", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please report this to developers at: http://code.google.com/p/mdeditor/", "Framework Error", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
