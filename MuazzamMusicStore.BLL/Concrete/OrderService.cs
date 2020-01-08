using MuazzamMusicStore.BLL.Abstract;
using MuazzamMusicStore.DAL.Abstract;
using MuazzamMusicStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.BLL.Concrete
{
    public class OrderService : IOrderService
    {
        IOrderDAL _orderDAL;
        public OrderService(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }
        public void DeleetById(int entityID)
        {
            Order order = _orderDAL.Get(a => a.ID == entityID);
            Delete(order);
        }

        public void Delete(Order entity)
        {
            _orderDAL.Remove(entity);
        }

        public Order Get(int entityID)
        {
            return _orderDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Order> GetAll()
        {
            return _orderDAL.GetAll().ToList();
        }

        public void Insert(Order entity)
        {
            _orderDAL.Add(entity);
        }

        public void Update(Order entity)
        {
            _orderDAL.Update(entity);
        }
    }
}
