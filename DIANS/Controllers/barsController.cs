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
    public class barsController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/bars
        public IQueryable<bars> Getbars()
        {
            return db.bars;
        }
     

    }
}