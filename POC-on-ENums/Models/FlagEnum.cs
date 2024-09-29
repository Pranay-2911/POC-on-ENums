using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_on_ENums.Models
{
    internal class FlagEnum
    {
        //Enum for fileacess to use bitwise operator
        public enum FileAccess
        {
            Read = 1,
            Write = 2,
            Execute = 3
        }
            
    }
}
