using System;
using TeamsMVC.Models;
using System.Collections.Generic;
namespace TeamsMVC.Repositories
{
    public interface IPlayerRepository
    {
        void CreatePlayer(CreatePlayerViewModel player);

        IList<PlayerViewModel> GetPlayers();
    }
}
