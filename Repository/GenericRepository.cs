using Model;
using Repository.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class GenericRepository<ReadModel,CommandModel, TEntity>: IDisposable, IGenericRepository<ReadModel,CommandModel> where TEntity :class, ReadModel
    {
        protected readonly IMyDbContext _context;

        public GenericRepository(IMyDbContext context)
        {
            _context = context;

        }

        public virtual ReadModel Get(int Id)
        {
            return _context.Set<TEntity>().Find(Id);

        }
        public virtual void Add(CommandModel obj)
        {
            _context.Set<TEntity>().Add(obj as TEntity);

        }
        public void AddRange(IEnumerable<ReadModel> objects)
        {
            _context.Set<TEntity>().AddRange((IEnumerable<TEntity>)objects);

        }
        public void Remove(ReadModel obj)
        {
            _context.Set<TEntity>().Remove(obj as TEntity);
        }

        public void RemoveRange(IEnumerable<ReadModel> objects)
        {
            _context.Set<TEntity>().RemoveRange((IEnumerable<TEntity>)objects);
        }
        public void Dispose() {

            _context.SaveChanges();
            _context.Dispose();
        }
        
    }
}
