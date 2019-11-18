﻿using Tele.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tele.BusinessLayer
{
    public class TeleContext : DbContext
    {

        public TeleContext()
            : base("TeleConnectionString")
        {
        }
        
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Refer> Refers { get; set; }
        public DbSet<Queue> Queue { get; set; }

    }
}
