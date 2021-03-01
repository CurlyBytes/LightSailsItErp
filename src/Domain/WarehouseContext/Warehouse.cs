using Ardalis.GuardClauses;
using Domain.WarehouseContext.Rules;
using Domain.WarehouseContext.ValueObjects;
using SharedKernel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.WarehouseContext
{
    public class Warehouse : Entity, IHaveAggregateRoot
    {
        public WarehouseId WarehouseId { get; private set; }

        public WarehouseCodeName WarehouseCodeName { get; private set; }

        public string WareHouseTitle { get; private set; }

        private readonly IHaveCodeNameRegexChecker _iHaveCodeNameRegexChecker;

        public Warehouse(WarehouseId warehouseId,
            WarehouseCodeName warehouseCodeName,
            string wareHouseTitle,
            IHaveCodeNameRegexChecker iHaveCodeNameRegexChecker)
        {
            Guard.Against.Null(warehouseCodeName, nameof(warehouseCodeName));
            Guard.Against.Null(warehouseId, nameof(warehouseId));
            Guard.Against.NullOrWhiteSpace(wareHouseTitle, nameof(wareHouseTitle));
            Guard.Against.InvalidFormat(wareHouseTitle, nameof(wareHouseTitle), Constants.Regexpattern.WarehouseTitle);
            Guard.Against.InvalidFormat(wareHouseTitle, nameof(wareHouseTitle), Constants.Regexpattern.WarehouseTitle);
            Guard.Against.Null(iHaveCodeNameRegexChecker, nameof(iHaveCodeNameRegexChecker));

            _iHaveCodeNameRegexChecker = iHaveCodeNameRegexChecker;
            WarehouseId = warehouseId;
            WarehouseCodeName = warehouseCodeName;
            WareHouseTitle = wareHouseTitle;

            //TASK fire an event on instantiate
        }

        public void NewWarehouse(
             WarehouseCodeName warehouseCodeName,
             string wareHouseTitle,
             IHaveCodeNameRegexChecker iHaveCodeNameRegexChecker)
        {
            Guard.Against.Null(warehouseCodeName, nameof(warehouseCodeName));
            Guard.Against.NullOrWhiteSpace(wareHouseTitle, nameof(wareHouseTitle));
            Guard.Against.InvalidFormat(wareHouseTitle, nameof(wareHouseTitle), Constants.Regexpattern.WarehouseTitle);
            Guard.Against.InvalidInput(warehouseCodeName, nameof(warehouseCodeName), IsUniqueWarehouseCodeName);

            WarehouseId = new WarehouseId(new Guid());
            WarehouseCodeName = warehouseCodeName;
            WareHouseTitle = wareHouseTitle;

            Warehouse warehouse = new Warehouse(WarehouseId, WarehouseCodeName, WareHouseTitle, iHaveCodeNameRegexChecker);
            //TASK Fire an event of Create New Warehouse
        }

        
        private  bool IsUniqueWarehouseCodeName(WarehouseCodeName warehouseCodeName) 
        {
            bool isUniqueWarehouseCodename = new CodeNameRegexChecker(_iHaveCodeNameRegexChecker,warehouseCodeName.ToString()).IsBroken();
            return isUniqueWarehouseCodename;
        }
    }
}
