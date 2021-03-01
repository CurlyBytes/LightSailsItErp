using SharedKernel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.WarehouseContext
{
    public class WarehouseId : TypedIdValueBase
    {
        public WarehouseId(Guid value) : base(value)
        {
        }
    }
}
