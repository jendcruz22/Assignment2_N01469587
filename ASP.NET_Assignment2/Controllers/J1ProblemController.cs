﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP.NET_Assignment2.Controllers
{
    //J1 Problem from 2007: Who is in the middle?
    public class J1ProblemController : ApiController
    {
        //GET: api/j1problem/goldilocks/Weight1/Weight2/Weight3
        [HttpGet]
        [Route("api/j1problem/goldilocks/{Weight1}/{Weight2}/{Weight3}")]

        public int Goldilocks(int Weight1, int Weight2, int Weight3)
        {
            int MamaBearBowl;
            if (((Weight1 > Weight2) & (Weight1 < Weight3)) | 
                ((Weight1 < Weight2) & (Weight1 > Weight3)))
            {
                MamaBearBowl = Weight1;
            }
            else if (((Weight2 > Weight1) & (Weight2 < Weight3)) | 
                ((Weight2 < Weight1) & (Weight2 > Weight3)))
            {
                MamaBearBowl = Weight2;
            }
            else 
            {
                MamaBearBowl = Weight3;
            }
            return MamaBearBowl;
        }
    }
}
