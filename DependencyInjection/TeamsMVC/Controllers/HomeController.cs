using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamMVC.Data;
using TeamMVC.Data.Models;
using TeamsMVC.Models;
using TeamsMVC.Repositories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
namespace TeamsMVC.Controllers
{
    public class HomeController : Controller
    {
        ////private IPlayerRepository _repo;//This is a private, classwide repository variable

        ////public HomeController() : this(new PlayerDataRepository())
        ////{
        ////    // is equillivant to calling _repo = new PlayerDataRepository in a standare HomeController Constructor
        ////}

        //public HomeController(IPlayerRepository repo)//This is the constructor for the home controller.
        //{
        //    _repo = repo;

        //}

        //private IGenericRepository _repo;  //If using Ninject, don't need this here.  go to NinjectWebcommon in the AppStart folder


        //public HomeController()  //default constructor
        //{

        //}

        private IGenericRepository _repo;

        public HomeController(IGenericRepository repo)
        {
            _repo = repo;
        }




        public ActionResult Index()  //This is the index function
        {
            IndexViewModel model = new IndexViewModel();

            model.Players = _repo.Query<Player>().Project().To<PlayerViewModel>().ToList();
            //(p => new PlayerViewModel
            //{
            //    PlayerName = p.FistName + " " + p.LastName,  //Should have followed _repo.Query<Player>(). but is possible because of 'AutoMapper'
            //    TeamCity = p.Team.City,
            //    TeamName = p.Team.Name
            //}).ToList();

            model.NumberOfPlayers = model.Players.Count;
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}