using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class Client
    {
        public int C_ID { get; set; }
        public string C_Name { get; set; }
        public string C_L_Name { get; set; }
        public string C_Tel { get; set; }
        public string C_Address { get; set; }
        public string C_Main { get; set; }

        public Client(string C_Name, string C_L_Name, string C_Tel, string C_Address)
        {
            this.C_Name = C_Name;
            this.C_L_Name = C_L_Name;
            this.C_Tel = C_Tel;
            this.C_Address = C_Address;
        }
    }
}
