using Ardalis.GuardClauses;
using Domain.Warehouse.Rules;
using SharedKernel.Models;
using SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Warehouse.ValueObjects
{
  public class WarehouseCodeName : ValueObject
    {
        public string CodeName { get; private set; }
        private readonly IHaveCodeNameRegexChecker _iHaveCodeNameRegexChecker;


        public WarehouseCodeName(string codeName)
        {
            string regexPattern = @"\b\w*[-']\w*\b";
            Guard.Against.NullOrEmpty(codeName, nameof(codeName));
            Guard.Against.NullOrWhiteSpace(codeName, nameof(codeName));
            Guard.Against.InvalidFormat(codeName, nameof(codeName), regexPattern);
            Guard.Against.InvalidInput(codeName, nameof(codeName), CodeNameIsUnique);


            CodeName = codeName;

        }


        public override string ToString()
        {

            return CodeName;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return CodeName.ToUpper().Trim();

        }

        private bool CodeNameIsUnique(string codeName)
        {
            return _iHaveCodeNameRegexChecker.IsUnique(codeName);
        }
    }
}
