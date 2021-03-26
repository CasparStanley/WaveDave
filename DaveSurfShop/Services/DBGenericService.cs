using DaveSurfShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DaveSurfShop.Services
{
    public class DBGenericService<T> where T : class
    {
        // GET ----------------------------------------------------------------------
        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new ObjectDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        // ADD ----------------------------------------------------------------------
        public async Task AddObjectAsync(T obj)
        {
            using (var context = new ObjectDbContext())
            {
                context.Set<T>().Add(obj);
                await context.SaveChangesAsync();
            }
        }

        // UPDATE -------------------------------------------------------------------
        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new ObjectDbContext())
            {
                context.Set<T>().Add(obj);
                context.SaveChanges();
            }
        }


        // UPDATE ALL OBJECTS -------------------------------------------------------
        public async Task UpdateObjectsAsync(List<T> objects)
        {
            using (var context = new ObjectDbContext())
            {
                foreach (T obj in objects)
                {
                    context.Set<T>().Add(obj);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }

        // DELETE
        public async Task DeleteObjectAsync(T obj)
        {
            using (var context = new ObjectDbContext())
            {
                context.Set<T>().Remove(obj);
                context.SaveChanges();
            }
        }
    }
}
