using MuazzamMusicStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.BLL.Abstract
{
   public interface IAlbumService :IBaseService<Albumler>
    {
        List<Albumler> GetAlbumOfGenre(int genreId);
        List<Albumler> GetDiscountedAlbums();
        List<Albumler> GetLastFiveAlbumlers();
    }
}
