using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamMVC.Data;
using TeamMVC.Data.Models;
using TeamsMVC.Models;

namespace TeamsMVC.Repositories
{
    public class PlayerDataRepository : TeamsMVC.Repositories.IPlayerRepository
    {
        private TeamDbContext _db = new TeamDbContext();

        //CRUD Opperations!!!!!

        public IList<PlayerViewModel> GetPlayers()
            {
                return _db.Players.Select(p => new PlayerViewModel //This projects the data model to the view model
                {
                    PlayerName = p.FistName + " " + p.LastName,
                    TeamCity = p.Team.City,
                    TeamName = p.Team.Name
                }).ToList();
            }

        public void CreatePlayer(CreatePlayerViewModel player)
        {
            Player dbPlayer = new Player  //Converting our ViewModel into a DataModel
            {
                FistName = player.FirstName,
                LastName = player.LastName,
                TeamId = player.SelectedTeam.Value
            };

            _db.Players.Add(dbPlayer);
            _db.SaveChanges();
        }
        
        

    }
}