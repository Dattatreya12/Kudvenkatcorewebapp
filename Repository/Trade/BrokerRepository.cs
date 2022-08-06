using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.ViewModels.Trade;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade
{
    public class BrokerRepository : IBrokerRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private readonly AppDbContext context;

        public BrokerRepository(IConfiguration configurtion, AppDbContext context)
        {
            this.context = context;
            this._configuration = configurtion;
        }
        public async Task<Broker> Add(Broker broker)
        {
            await context.brokers.AddAsync(broker);
            context.SaveChanges();
            return broker;
        }
        public async Task<List<Broker>> GetAllBrokerList()
        {
            return await context.brokers.Select(x => new Broker()
            {
                ID = x.ID,
                BrokerName = x.BrokerName
            }).ToListAsync();
         }
        public async Task<IEnumerable<Broker>> GetAllBrokerListusingIenumerable()
        {
            //IEnumerable<Broker> brokerlist = await context.brokers.ToListAsync();
            IEnumerable<Broker> brokerlist = await context.brokers.Where(x => x.Active == 1).ToListAsync();
            return brokerlist;
        }


    }
}
