using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTest_tests_example.Basics
{
    class CustomReplacer
    {
        public string CustomReplace(string str, string charStr)
        {
            if (str == null || charStr == null || charStr.Length > 1)
            {
                throw new Exception("datos incorrectos en la entrada");
            }

            char theChar = charStr[0];
            int counter = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == theChar)
                {
                    sb.Append(++counter);
                }
                else
                {
                    sb.Append(str[i]);
                }
            }

            return sb.ToString();
        }
    }
}
