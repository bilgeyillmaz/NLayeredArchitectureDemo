
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
        where T : IEntity, new() // neden class yazamıyorum ??
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //ürünün isminde şunları getir dediğimizde buraya link expression tanımlayabiliyoruz.
        //Expression diyerek,link ile beraber kullanabileceğimiz
        //ben sana bir T vereceğim, bana bir dönüş tipi olarak bool vereceksin ve buna da filter diyeceğim
        //kullanıcı isterse filter =null filtreyi vermek zorunda değildir. Yani hiçbir şey vermezse tümünü getirecek, filtre verilirse o
        //filtreye göre 

        T Get(Expression<Func<T, bool>> filter); //get i de boş geçemesin, bazılarında id, bazılarında uniqueidentifier a göre ... olsun
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
