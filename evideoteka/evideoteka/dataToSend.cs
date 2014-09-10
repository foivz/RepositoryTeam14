using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evideoteka
{
    public class dataToSend : System.EventArgs
    {
        private string tableNumber;
        private string tableName;
        public dataToSend(string s, string ss )
        {
            this.tableNumber = s;
            this.tableName = ss;
        }
        public string getNumber
        {
            get
            {
                return tableNumber;
            }
            set
            {
                getNumber = value;
            }
        }

        public string getTableName
        {
            get
            {
                return tableName;
            }
            set
            {
                tableName = value;
            }
        }
    }
}
