using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Students : Management
    {
        Dictionary<int, string> Dic = new Dictionary<int, string>();
        public override void add_Profile()
        {
            Dic.Add(001, "AAA");
            Dic.Add(002, "BBB");
            Dic.Add(003, "CCC");
            Dic.Add(004, "DDD");
            Dic.Add(005, "EEE");

        }
        
        
    }
}
