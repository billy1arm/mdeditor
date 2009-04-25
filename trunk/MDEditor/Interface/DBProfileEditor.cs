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
            if (m_otoClass != null)
            {
                m_otoClass.SaveValues();

                if (!m_profile.Saved)
                {
                    DBProfileHandler.Add(m_profile);
                }

                DBProfileHandler.Save();
            }
        }

        private void Initialize()
        {
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
    }
}
