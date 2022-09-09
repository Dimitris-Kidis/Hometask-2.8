using Hometask_2._8.Context;
using Hometask_2._8.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2._8.Repository
{
    internal class ClientRepository : GenericRepository<Client>
    {
        public ClientRepository(ScheduleDbContext context) : base(context)
        {
        }

        public Client SelectClientsOlder20(int id)
        {
            return _context.Clients.Include(client => client.Age).First(client => client.Id == id);
        }
    }
}
