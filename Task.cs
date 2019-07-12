using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasklogmemorizer
{
    class Task
    {
        public void InsertTaskRecord(int timeTypeCode,int taskCategoryCode, string memo){
            DBConnection dB = new DBConnection();
            dB.Open();
        }

    }
}
