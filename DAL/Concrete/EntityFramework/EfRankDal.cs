using DAL.Abstract;
using ENT.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Concrete.EntityFramework
{
    public class EfRankDal : IRankDal
    {
        public void Add(Rank entity)
        {
            using (GYTDBContext context = new GYTDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Rank entity)
        {
            using (GYTDBContext context = new GYTDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Rank Get(Expression<Func<Rank, bool>> filter)
        {
            using (GYTDBContext context = new GYTDBContext())
            {
                return context.Set<Rank>().SingleOrDefault(filter);
            }
        }

        public List<Rank> GetAll(Expression<Func<Rank, bool>> filter = null)
        {
            using (GYTDBContext context = new GYTDBContext())
            {
                return filter == null ? context.Set<Rank>().ToList() : context.Set<Rank>().Where(filter).ToList();
            }
        }

        public void Update(Rank entity)
        {
            using (GYTDBContext context = new GYTDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
