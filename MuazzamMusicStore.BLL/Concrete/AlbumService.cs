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
    public class AlbumService : IAlbumService
    {
        IAlbumDAL _albumDAL;
        public AlbumService(IAlbumDAL albumDAL)
        {
            _albumDAL = albumDAL;
        }
        public void DeleetById(int entityID)
        {
            Albumler album = _albumDAL.Get(a => a.ID == entityID);
            Delete(album);
        }

        public void Delete(Albumler entity)
        {
            _albumDAL.Remove(entity);
        }

        public Albumler Get(int entityID)
        {
            return _albumDAL.Get(a => a.ID == entityID);
        }

        public List<Albumler> GetAlbumOfGenre(int genreId)
        {
            return _albumDAL.GetAll(a => a.GenreID == genreId).ToList();
        }

        public ICollection<Albumler> GetAll()
        {
            return _albumDAL.GetAll().ToList();

        }

        public List<Albumler> GetDiscountedAlbums()
        {
            return _albumDAL.GetAll(a => a.Discounted == true).ToList();
        }

        public List<Albumler> GetLastFiveAlbumlers()
        {
            return _albumDAL.GetAll().OrderByDescending(a => a.CreatedDate).Take(5).ToList();
        }

        public void Insert(Albumler entity)
        {
            _albumDAL.Add(entity);
        }

        public void Update(Albumler entity)
        {
            _albumDAL.Update(entity);
        }
    }
}
