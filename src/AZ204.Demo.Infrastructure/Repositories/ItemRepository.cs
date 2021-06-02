using AZ204.Demo.Domain.Entities;
using AZ204.Demo.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZ204.Demo.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly CatalogContext _context;

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public ItemRepository(CatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Item>> GetAsync()
        {
            return await _context.Items
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Item> GetAsync(Guid id)
        {
            var item = await _context.Items
                .AsNoTracking()
                .Where(x => x.id == id)
                .FirstOrDefaultAsync();

            return item;
        }

        public Item Add(Item item)
        {
            return _context.Items.Add(item).Entity;
        }        

        public Item Update(Item item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return item;
        }
    }
}
