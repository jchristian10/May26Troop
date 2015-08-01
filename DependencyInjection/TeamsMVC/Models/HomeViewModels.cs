﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamMVC.Data.Models;

namespace TeamsMVC.Models
{
    public class PlayerViewModel
    {
        public string PlayerName { get; set; }

        public string TeamName { get; set; }

        public string TeamCity { get; set; }
    }

    public class IndexViewModel
    {
        public IList<PlayerViewModel> Players { get; set; }

        public int NumberOfPlayers { get; set; } 
    }

    public class CreatePlayerViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IList<Team> Teams { get; set; } //This is bad.  we should create a view model and refrence the view model!

        public int? SelectedTeam { get; set; }


    }
}