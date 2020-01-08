using MuazzamMusicStore.Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.Model
{
   public class Albumler:BaseEntity
    {
        public Albumler()
        {
            Discounted = false;
            //sitede her albümün siparişi olmayabilir,olacağı zaman newleyebiliriz,burada hashset ile newlersek sipariş detayı olmasa bile ram'de yer tutmuş olur.
        }
        public string Title { get; set; }
        public string AlbumArtUrl { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }
        public bool Discounted { get; set; }   //indirimli
        public int GenreID { get; set; }
        public int ArtistID { get; set; }

        //mapping
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
