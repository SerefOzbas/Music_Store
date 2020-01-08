using MuazzamMusicStore.Core.DAL.EntityFramework;
using MuazzamMusicStore.DAL.Abstract;
using MuazzamMusicStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.DAL.Concrete.EntityFramework
{
   public class OrderRepository: EFRepositoryBase<Order, MuazzamMusicStoreDbContext>, IOrderDAL
    {
    }
}
