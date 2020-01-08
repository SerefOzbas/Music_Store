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
    public class ShipperService : IShipperService
    {
        IShipperDAL _shipperDAL;
        public ShipperService(IShipperDAL shipperDAL)
        {
            _shipperDAL = shipperDAL;
        }
        public void DeleetById(int entityID)
        {
            Shipper shipper = _shipperDAL.Get(a => a.ID == entityID);
            Delete(shipper);
        }

        public void Delete(Shipper entity)
        {
            _shipperDAL.Remove(entity);
        }

        public Shipper Get(int entityID)
        {
            return _shipperDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Shipper> GetAll()
        {
            return _shipperDAL.GetAll().ToList();
        }

        public void Insert(Shipper entity)
        {
            _shipperDAL.Add(entity);
        }

        public void Update(Shipper entity)
        {
            _shipperDAL.Update(entity);
        }
    }
}
