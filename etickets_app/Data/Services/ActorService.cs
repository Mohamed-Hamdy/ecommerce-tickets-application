using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorService :EntityBaseRepository<Actor> , IActorsService
    {
        public ActorService(AppDbContext context) : base(context)
        {
            
        }
    }
}