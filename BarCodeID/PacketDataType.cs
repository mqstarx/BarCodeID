using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeID
{
    [Serializable]
    public class PacketDataType
    {
        string m_typeId;
        int m_dataLen;

        string m_dataDescr;

        List<KeyValuePair<string, string>> m_keyValues;

        public string TypeId
        {
            get
            {
                return m_typeId;
            }

            set
            {
                m_typeId = value;
            }
        }

        public int DataLen
        {
            get
            {
                return m_dataLen;
            }

            set
            {
                m_dataLen = value;
            }
        }



        public string DataDescr
        {
            get
            {
                return m_dataDescr;
            }

            set
            {
                m_dataDescr = value;
            }
        }



        public List<KeyValuePair<string, string>> KeyValue
        {
            get
            {
                return m_keyValues;
            }

            set
            {
                m_keyValues = value;
            }
        }

        public PacketDataType(string typeId, int dataLen, string dataDescr)
        {
            TypeId = typeId;
            DataLen = dataLen;

            DataDescr = dataDescr;

            m_keyValues = new List <KeyValuePair<string, string>>();
        }
        public override string ToString()
        {
            return m_dataDescr;
        }

    }
    public class ListObject
    {
        object m_object;
        object m_object1;
        string m_text;
        string m_text1;
        public ListObject()
        { }

        public object Object
        {
            get
            {
                return m_object;
            }

            set
            {
                m_object = value;
            }
        }

        public object Object1
        {
            get
            {
                return m_object1;
            }

            set
            {
                m_object1 = value;
            }
        }

        public string Text
        {
            get
            {
                return m_text;
            }

            set
            {
                m_text = value;
            }
        }

        public string Text1
        {
            get
            {
                return m_text1;
            }

            set
            {
                m_text1 = value;
            }
        }

        public override string ToString()
        {
            return m_text;
        }
    }
    public static class Functions
    {
        public static void SaveConfig(List<PacketDataType> cfg,string path)
        {
            if (MessageBox.Show("Внимание данные будут сохранены в файл", "Подвердите действие...", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, cfg);
                    fs.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Config save Error "+e.Message);
                }
            }
        }
        public static List<PacketDataType> LoadConfig(string path)
        {
            IniFile ini = new IniFile(path);
            string datatypes = ini.ReadINI("main", "datatypes");
            string[] datatypesarray = datatypes.Split(';');
            List<PacketDataType> lp = new List<PacketDataType>();
            for(int i=0;i< datatypesarray.Length;i++)
            {
                PacketDataType pd = new PacketDataType(datatypesarray[i], Int32.Parse(ini.ReadINI(datatypesarray[i], "len")), ini.ReadINI(datatypesarray[i], "name"));
                if(ini.KeyExists("array",datatypesarray[i]))
                {
                   string[] arrayvalues  = ini.ReadINI(datatypesarray[i], "array").Split(';');
                    for (int j = 0; j < arrayvalues.Length; j++)
                    {
                        pd.KeyValue.Add(new KeyValuePair<string, string>(arrayvalues[j].Split(':')[0], arrayvalues[j].Split(':')[1]));
                     }
                }
                lp.Add(pd);
            }

            return lp;

           
        }
    }
}

