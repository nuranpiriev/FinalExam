using Final.CL.Models.Base;
using Final.DL.Contexts;
using Final.DL.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DL.Repositories.Concrets
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        readonly AppDbContext _context;
        public DbSet<T> Table => _context.Set<T>(); 

        public async Task CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            Table.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<ICollection<T>> GetAll(params string[] includes)
        {
            IQueryable<T> query = Table;
            if (includes.Length > 0)
            {
               foreach(string include in includes)
                {
                    query=query.Include(include);
                }
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            Table.Update(entity);
          await  _context.SaveChangesAsync();
        }
    }
}
