using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwndPro.Entities.Orm
{
    public partial class Territory
    {
        public Territory()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritory>();
        }

        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionId { get; set; }

        public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
    }
}
