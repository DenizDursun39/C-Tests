using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Colors entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Colors entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Colors>().SingleOrDefault(filter);
            }
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null 
                    ? context.Set<Colors>().ToList() 
                    : context.Set<Colors>().Where(filter).ToList();
                    
            }
        }

        public void Update(Colors entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var modifiedEntity = context.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
