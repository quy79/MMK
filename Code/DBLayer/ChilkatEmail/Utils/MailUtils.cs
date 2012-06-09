using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChilkatEmail.Utils
{
    public class MailUtils
    {
        public String mailParse(List<String> list)
        {
            String result = "";
            foreach(String item in list){
                result += ";" + item;
            }
            return result;
        }
    }
}
