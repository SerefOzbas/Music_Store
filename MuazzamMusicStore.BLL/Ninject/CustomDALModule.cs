using MuazzamMusicStore.DAL.Abstract;
using MuazzamMusicStore.DAL.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.BLL.Ninject
{
   public class CustomDALModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAlbumDAL>().To<AlbumRepository>();
            Bind<IArtistDAL>().To<ArtistRepository>();
            Bind<IGenreDAL>().To<GenreRepository>();
            Bind<IOrderDAL>().To<OrderRepository>();
            Bind<IShipperDAL>().To<ShipperRepository>();
            Bind<IUserDAL>().To<UserRepository>();


        }
    }
}
