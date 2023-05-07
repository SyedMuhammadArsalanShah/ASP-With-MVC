using Lecture29WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lecture29WebAPI.Controllers
{
    public class ResultController : ApiController
    {


        User[] users = new User[] {

            new User{Id=1, name="demo",date=DateTime.Parse(DateTime.Today.ToString()), age=20},
            new User{Id=2, name="demo1",date=DateTime.Parse(DateTime.Today.ToString()), age=40},
            new User{Id=3, name="demo2",date=DateTime.Parse(DateTime.Today.ToString()), age=60},
            new User{Id=4, name="demo3",date=DateTime.Parse(DateTime.Today.ToString()), age=80},
            new User{Id=5, name="demo4",date=DateTime.Parse(DateTime.Today.ToString()), age=100},



        };

        public IEnumerable<User> Getallusers()
        {


            return users;
        }

    }
}
