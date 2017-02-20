using System;
using System.Collections.Generic;
using System.Text;

namespace MyCouch
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum)
 ]
    public class Serializable : System.Attribute
    {
      

        public Serializable()
        {
           
        }
    }

}
