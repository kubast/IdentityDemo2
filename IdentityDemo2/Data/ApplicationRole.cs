﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityDemo2.Data
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
    }
}
