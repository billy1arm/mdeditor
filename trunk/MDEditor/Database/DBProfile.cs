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
        private string m_worldHost;
        private decimal m_worldPort;
        private string m_accountHost;
        private decimal m_accountPort;
        private bool m_saved;

        public DBProfile()
        {
            m_handle = "";
            m_worldPassword = "";
            m_worldUsername = "";
            m_accountPassword = "";
            m_accountUsername = "";
            m_accountPort = 3306;
            m_worldPort = 3306;
            m_saved = false;
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
        public string WorldHost
        {
            get { return m_worldHost; }
            set { m_worldHost = value; }
        }

        [XmlAttribute]
        public decimal WorldPort
        {
            get { return m_worldPort; }
            set { m_worldPort = value; }
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

        [XmlAttribute]
        public decimal AccountPort
        {
            get { return m_accountPort; }
            set { m_accountPort = value; }
        }

        [XmlAttribute]
        public string AccountHost
        {
            get { return m_accountHost; }
            set { m_accountHost = value; }
        }

        [XmlIgnore]
        public bool Saved
        {
            get { return m_saved; }
            internal set { m_saved = value; }
        }

        public override string ToString()
        {
            return m_handle;
        }
    }
}
