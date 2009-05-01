using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Castle.ActiveRecord.Framework.Config;
using Castle.ActiveRecord;
using System.Collections;
using System.Reflection;

namespace MDEditor.Database
{
    public enum DatabaseType
    {
        MySQL
    }

    public enum ProfileType : uint
    {
        Account = 0,
        World,
        Character,
        Last
    }

    public class DBProfile
    {
        private string m_handle;
        private string[] m_username;
        private string[] m_password;
        private string[] m_host;
        private int[] m_port;
        private string[] m_database;
        private DatabaseType[] m_dbtype;
        private Type[] m_dbRecordTypes;
        private bool m_saved;

        public DBProfile()
        {
            m_handle = "";

            m_username = new string[(int)ProfileType.Last];
            m_password = new string[(int)ProfileType.Last];
            m_host = new string[(int)ProfileType.Last];
            m_database = new string[(int)ProfileType.Last];
            m_port = new int[(int)ProfileType.Last];
            m_dbtype = new DatabaseType[(int)ProfileType.Last];
            m_dbRecordTypes = new Type[(int)ProfileType.Last];

            for (int i = 0; i < (int)ProfileType.Last - 1; i++)
            {
                m_username[i] = "";
                m_password[i] = "";
                m_host[i] = "";
                m_port[i] = 3306;
                m_database[i] = "";
                m_dbtype[i] = DatabaseType.MySQL;
            }
        }

        [XmlAttribute]
        public string Handle
        {
            get { return m_handle; }
             set { m_handle = value; }
        }

        [XmlAttribute]
        public int CharacterPort
        {
            get { return m_port[(int)ProfileType.Character]; }
            set { m_port[(int)ProfileType.Character] = value; }
        }

        [XmlAttribute]
        public string CharacterHost
        {
            get { return m_host[(int)ProfileType.Character]; }
            set { m_host[(int)ProfileType.Character] = value; }
        }

        [XmlAttribute]
        public string CharacterDatabase
        {
            get { return m_database[(int)ProfileType.Character]; }
            set { m_database[(int)ProfileType.Character] = value; }
        }

        [XmlAttribute]
        public string CharacterPassword
        {
            get { return m_password[(int)ProfileType.Character]; }
            set { m_password[(int)ProfileType.Character] = value; }
        }

        [XmlAttribute]
        public string CharacterUsername
        {
            get { return m_username[(int)ProfileType.Character]; }
            set { m_username[(int)ProfileType.Character] = value; }
        }

        [XmlAttribute]
        public string WorldUsername
        {
            get { return m_username[(int)ProfileType.World]; }
            set { m_username[(int)ProfileType.World] = value; }
        }

        [XmlAttribute]
        public string WorldHost
        {
            get { return m_host[(int)ProfileType.World]; }
            set { m_host[(int)ProfileType.World] = value; }
        }

        [XmlAttribute]
        public int WorldPort
        {
            get { return m_port[(int)ProfileType.World]; }
            set { m_port[(int)ProfileType.World] = value; }
        }

        [XmlAttribute]
        public string WorldDatabase
        {
            get { return m_database[(int)ProfileType.World]; }
            set { m_database[(int)ProfileType.World] = value; }
        }

        [XmlAttribute]
        public string WorldPassword
        {
            get { return m_password[(int)ProfileType.World]; }
            set { m_password[(int)ProfileType.World] = value; }
        }

        [XmlAttribute]
        public string AccountUsername
        {
            get { return m_username[(int)ProfileType.Account]; }
            set { m_username[(int)ProfileType.Account] = value; }
        }

        [XmlAttribute]
        public string AccountPassword
        {
            get { return m_password[(int)ProfileType.Account]; }
            set { m_password[(int)ProfileType.Account] = value; }
        }

        [XmlAttribute]
        public int AccountPort
        {
            get { return m_port[(int)ProfileType.Account]; }
            set { m_port[(int)ProfileType.Account] = value; }
        }

        [XmlAttribute]
        public string AccountHost
        {
            get { return m_host[(int)ProfileType.Account]; }
            set { m_host[(int)ProfileType.Account] = value; }
        }

        [XmlAttribute]
        public string AccountDatabase
        {
            get { return m_database[(int)ProfileType.Account]; }
            set { m_database[(int)ProfileType.Account] = value; }
        }

        [XmlAttribute]
        public DatabaseType AccountDatabaseType
        {
            get { return m_dbtype[(int)ProfileType.Account]; }
            set { m_dbtype[(int)ProfileType.Account] = value; }
        }

        [XmlAttribute]
        public DatabaseType WorldDatabaseType
        {
            get { return m_dbtype[(int)ProfileType.World]; }
            set { m_dbtype[(int)ProfileType.World] = value; }
        }

        [XmlAttribute]
        public DatabaseType CharacterDatabaseType
        {
            get { return m_dbtype[(int)ProfileType.Character]; }
            set { m_dbtype[(int)ProfileType.Character] = value; }
        }

        [XmlIgnore]
        public bool Saved
        {
            get { return m_saved; }
            internal set { m_saved = value; }
        }

        [XmlIgnore]
        internal string AccountMySQLString
        {
            get { return string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};", AccountHost, AccountPort, AccountDatabase, AccountUsername, AccountPassword); }
        }

        public string GenerateConnectionString(DatabaseType dbType, ProfileType profileType)
        {
            return string.Format(dbType == DatabaseType.MySQL ? "Server={0};Port={1};Database={2};Uid={3};Pwd={4};" : "", m_host[(int)profileType], m_port[(int)profileType], m_database[(int)profileType], m_username[(int)profileType], m_password[(int)profileType]);
        }

        public InPlaceConfigurationSource CreateSource()
        {
            InPlaceConfigurationSource source = new InPlaceConfigurationSource();

            for (int i = 0; i < (int)ProfileType.Last - 1; i++)
            {
                if (m_host[i].Length > 0)
                {
                    Hashtable properties = new Hashtable();

                    properties.Add("hibernate.connection.driver_class", "NHibernate.Driver.MySqlDataDriver");
                    properties.Add("hibernate.dialect", "NHibernate.Dialect.MySQLDialect");
                    properties.Add("hibernate.connection.provider", "NHibernate.Connection.DriverConnectionProvider");
                    properties.Add("hibernate.connection.connection_string", GenerateConnectionString(DatabaseType.MySQL, (ProfileType)i));

                    source.Add(typeof(ActiveRecordBase), properties);
                }
            }

            return source;
        }

        internal void Connect()
        {
            ActiveRecordStarter.Initialize(Assembly.GetExecutingAssembly(), CreateSource());
        }

        public override string ToString()
        {
            return m_handle;
        }
    }
}
