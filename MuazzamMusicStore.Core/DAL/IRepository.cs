using MuazzamMusicStore.Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.Core.DAL
{
   public interface IRepository<TEntity>  
        where TEntity: BaseEntity  //bu interface'i implement edecek Entityler baseentitiyden kalıtım almalı
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
