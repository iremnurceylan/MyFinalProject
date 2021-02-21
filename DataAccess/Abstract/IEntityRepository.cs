using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // generic constraint
    // class : referans tip 
    //IEntity : IEntity olabılır veya IEntity implemente eden bir nesne olabılır
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class
    {
        //Filtreler yazmamızı sağlar
        List<T> GetAll(Expression<Func<T ,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
