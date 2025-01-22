using Final.CL.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.DL.Repositories.Abstracts
{
    public interface IRepository<T> where T : BaseEntity,new()
    {
        DbSet<T> Table { get; }

        Task<ICollection<T>> GetAll(params string[] include);
        Task<T> GetById(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);


    }
}
