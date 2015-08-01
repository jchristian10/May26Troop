﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamMVC.Data.Models;

namespace TeamMVC.Data
{
    public class TeamDbContext : DbContext  //THIS IS A TYPE OF REPOSITORY
    {
        public IDbSet<Team> Teams { get; set; }

        public IDbSet<Player> Players { get; set; }
    }
}
