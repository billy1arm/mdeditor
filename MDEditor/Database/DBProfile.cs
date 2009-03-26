using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace MDEditor.Database
{
    [XmlElement]
    internal class DBProfile
    {
        private string m_handle;
        private string m_characterUsername;
        private string m_characterPassword;
        private string m_accountUsername;
        private string m_accountPassword;

        public DBProfile()
        {
            m_handle = "";
            m_characterPassword = "";
            m_characterUsername = "";
            m_accountPassword = "";
            m_accountUsername = "";
        }

        [XmlAttribute]
        public string Handle
        {
            get { return m_handle; }
            internal set { m_handle = value; }
        }

        [XmlAttribute]
        public string CharacterUsername
        {
            get { return m_accountUsername; }
            internal set { m_characterUsername = value; }
        }

        [XmlAttribute]
        public string CharacterPassword
        {
            get { return m_accountPassword; }
            internal set { m_characterPassword = value; }
        }

        [XmlAttribute]
        public string AccountUsername
        {
            get { return m_accountUsername; }
            internal set { m_accountUsername = value; }
        }

        [XmlAttribute]
        public string AccountPassword
        {
            get { return m_accountPassword; }
            internal set { m_accountPassword = value; }
        }
    }
}
