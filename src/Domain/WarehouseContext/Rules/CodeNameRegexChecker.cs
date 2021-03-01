using Domain.WarehouseContext.ValueObjects;
using SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.WarehouseContext.Rules
{
    public class CodeNameRegexChecker : IBusinessRule
    {
        private readonly IHaveCodeNameRegexChecker _iHaveCodeNameRegexChecker;

        private readonly string _codeName;


        public CodeNameRegexChecker(
            IHaveCodeNameRegexChecker iHaveCodeNameRegexChecker,
            string codeName)
        {
            _iHaveCodeNameRegexChecker = iHaveCodeNameRegexChecker;
            _codeName = codeName;
        }

 
        public string Message => "Warehouse with this WarehouseCodeName already exists.";

        public bool IsBroken()
        {
            return !_iHaveCodeNameRegexChecker.IsUnique(_codeName);
        }
    }
}
