using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStore.Controllers
{
    public class BannerAdController : Controller
    {

        
  
        // GET: BannerAd
        [ChildActionOnly]
        public ActionResult GetAd()
        {   IList<string> _quoteList;
            _quoteList = new List<string>();
            _quoteList.Add("Do or do not, there is no try.  -Yoda");
            _quoteList.Add("You can't blame gravity for falling in love");
            _quoteList.Add("May the Force be with You - Every Main Star Wars Character Ever");
            _quoteList.Add("I AM CORNHOLIO! - Bevis");
            _quoteList.Add("In the words of the eternal Colonel Sanders: I'm too drunk to taste THIS chicken - Ricky Bobby");
            Random _rnd = new Random();
            int rnd = _rnd.Next(0, 5);
            

            string quote = _quoteList[rnd];



            return PartialView("_BannerAd", quote);
        }
    }
}