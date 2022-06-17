using eTicketMVC.Data.Base;
using eTicketMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMVC.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context): base(context) { }

    }
}
