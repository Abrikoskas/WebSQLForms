using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSQLForms
{
    public class Check
    {
        public bool IsNULL { get; set; }
        public string Value { get; set; }
        public bool IsPhone { get; set; }
        public string Select { get; set; }

        //public List<Check> listForCheck = new List<Check>(5);

        public Check(bool isNULL, string value, bool isPhone, string select)
        {
            IsNULL = isNULL;
            Value = value;
            IsPhone = isPhone;
            Select = select;
        }

    }
}
