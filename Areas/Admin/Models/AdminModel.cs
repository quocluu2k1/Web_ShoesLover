﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesLover.Areas.Admin.Models
{
    public class AdminModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "Admin";
    }
}
