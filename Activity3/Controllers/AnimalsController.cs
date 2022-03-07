using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Activity3.Models;


namespace Activity3.Controllers
{
    public class AnimalsController : ApiController
    {

        public Animals Get()
        {
            Animals a = new Animals();
            a.name = "Chester";
            a.color = "Gray";
            a.type = "Ninja Turtle";
            a.size = 36;
            return a;
        }

        public Animals Post(string name)
        {
            Animals a = new Animals();
            a.name = name;
            a.color = "Red";
            a.type = "Chimken";
            a.size = 29;
            return a;
        }
        public Animals Put(string name, string color, int size)
        {
            Animals a = new Animals();
            a.name = name;
            a.color = color;
            a.type = "Cat";
            a.size = size;
            return a;
        }
        public void Delete()
        {

        }

    }
}
