using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessagePostApp.Models
{
    public class MessageViewModel
    {
        public IList<Message> Messages { get; set; }
    }
}