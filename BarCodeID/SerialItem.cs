using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCodeID
{
    public class SerialItem
    {
        private string m_qr_data; // qr код присвоенный данному диапазону
        private string m_serial; // список серийных номеров, данного типа изделия

        public string Serial
        {
            get
            {
                return m_serial;
            }

            set
            {
                m_serial = value;
            }
        }

        public string QR_Data
        {
            get
            {
                return m_qr_data;
            }

            set
            {
                m_qr_data = value;
            }
        }

        public SerialItem(string qr, string serial)
        {
            m_qr_data = qr;
            m_serial = serial;
        }
        public override string ToString()
        {
            return m_serial;
        }

    }
}
