using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.WarehouseContext.Rules
{
    public static class Constants
    {
        public static class Regexpattern
        {
            public const string WarehouseCodeName = @"\b\w*[-']\w*\b";
            public const string WarehouseTitle = @"\b\w*";
        }
        // more stuff here
    }
}
