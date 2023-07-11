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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brands entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brands entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brands Get(Expression<Func<Brands, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Brands>().SingleOrDefault(filter);
            }
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null
                    ? context.Set<Brands>().ToList() :
                    context.Set<Brands>().Where(filter).ToList();
            }
        }

        public void Update(Brands entity)
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
