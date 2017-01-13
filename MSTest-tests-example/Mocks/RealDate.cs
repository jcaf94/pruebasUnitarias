using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTest_tests_example.Mocks.Date
{
    public class RealDate : IFecha

    {
        public int getFecha()
        {
            return DateTime.Now.Hour;
        }
    }
}
