﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBKC.Service.DTOs.KitchenCenters
{
    public class CreateKitchenCenterRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public IFormFile Logo { get; set; }
        public string ManagerEmail { get; set; }
    }
}
