﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.ApplicationLayer.DTOs.Warehouses.Read
{
    public class ReadWareHouseDTO
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string Address { get; set; }
        public string? Governate { get; set; }

        public bool IsTrusted { get; set; }
        public bool IsWarehouseApproved { get; set; }

        public string UserId { get; set; }
        public string? ApprovedByAdminId { get; set; }

        public List<ReadWareHouseAreaDTO> WareHouseAreas { get; set; }


    }
}
