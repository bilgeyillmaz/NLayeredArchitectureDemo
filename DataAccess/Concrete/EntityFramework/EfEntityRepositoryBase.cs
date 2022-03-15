using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : IEntity, new()
        where TContext : DbContext, new()
    {
        //Add,Update,Delete gibi işlemlerin işlem içeriği hep aynı isimleri dışında, sürekli aynı kodu tekrar etmektense bu yapıyı oluşturuyoruz.
        //Bana bir adet tvarlığı ver bir adet de tdatası ben ona göre sana bir implementasyon yapayım, IEntityRepository için yapayım.
        //ve bütün gerekli olan implementations burada
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                //benim bir nesnem var veri tabanında sen buna abone ol, 
                //fakat bu yeni bir nesne sen bunu bulamayacaksın, bu nedenle bunun eklenecek yeni bir nesne olduğunu belitiyorum.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
                //Eğer filtre null ise TEntity'i kendine abone et ve çalıştır, eğer filter null değil ise TEntity'i kendine abone et ama filtrenin ne olduğuna göre
                // ve ona göre listele
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
