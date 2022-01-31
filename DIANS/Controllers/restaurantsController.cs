using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DIANS.Models;

namespace DIANS.Controllers
{
    public class restaurantsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/restaurants
        public IQueryable<restaurant> Getrestaurants()
        {
            return db.restaurants;
        }

       
    }
}