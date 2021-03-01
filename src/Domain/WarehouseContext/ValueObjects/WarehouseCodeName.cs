using Ardalis.GuardClauses;
using Domain.WarehouseContext.Rules;
using SharedKernel.Models;
using SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.WarehouseContext.ValueObjects
{
  public class WarehouseCodeName : ValueObject
    {
        public string CodeName { get; private set; }

        public WarehouseCodeName( string codeName)
        {
           
            
            //Guard.Against.Null(iHaveCodeNameRegexChecker, nameof(iHaveCodeNameRegexChecker));
            Guard.Against.NullOrEmpty(codeName, nameof(codeName));
            Guard.Against.NullOrWhiteSpace(codeName, nameof(codeName));
            Guard.Against.InvalidFormat(codeName, nameof(codeName), Constants.Regexpattern.WarehouseCodeName);
           

           // _iHaveCodeNameRegexChecker = iHaveCodeNameRegexChecker;
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

 
    }
}
