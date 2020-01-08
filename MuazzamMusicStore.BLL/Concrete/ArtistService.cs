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

   public class ArtistService : IArtistService
    {
        IArtistDAL _artistDAL;
        public ArtistService(IArtistDAL artistDAL)
        {
            _artistDAL = artistDAL;
        }
        public void DeleetById(int entityID)
        {
            Artist artist = _artistDAL.Get(a=>a.ID==entityID);
            Delete(artist);
        }

        public void Delete(Artist entity)
        {
            _artistDAL.Remove(entity);
        }

        public Artist Get(int entityID)
        {
            return _artistDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Artist> GetAll()
        {
            return _artistDAL.GetAll().ToList();
        }

        public void Insert(Artist entity)
        {
            _artistDAL.Add(entity);
        }

        public void Update(Artist entity)
        {
            _artistDAL.Update(entity);
        }
    }
}
