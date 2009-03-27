using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MDEditor.Database
{
    public class DBProfile
    {
        private string m_handle;
        private string m_worldUsername;
        private string m_worldPassword;
        private string m_accountUsername;
        private string m_accountPassword;

        public DBProfile()
        {
            m_handle = "";
            m_worldPassword = "";
            m_worldUsername = "";
            m_accountPassword = "";
            m_accountUsername = "";
        }

        [XmlAttribute]
        public string Handle
        {
            get { return m_handle; }
             set { m_handle = value; }
        }

        [XmlAttribute]
        public string WorldUsername
        {
            get { return m_worldUsername; }
            set { m_worldUsername = value; }
        }

        [XmlAttribute]
        public string WorldPassword
        {
            get { return m_worldPassword; }
            set { m_worldPassword = value; }
        }

        [XmlAttribute]
        public string AccountUsername
        {
            get { return m_accountUsername; }
            set { m_accountUsername = value; }
        }

        [XmlAttribute]
        public string AccountPassword
        {
            get { return m_accountPassword; }
            set { m_accountPassword = value; }
        }

        public override string ToString()
        {
            return m_handle;
        }
    }
}
