using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.Model
{
   public class OrderDetail
    {
        public OrderDetail()
        {
            Discount = 0;
        }
        public int OrderID { get; set; }
        public int AlbumID { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }  //discount:indirim
        public OrderState OrderState { get; set; }
        public string Notes { get; set; }

        //Mapping
        public virtual Order Order { get; set; }
        public virtual Albumler  Album { get; set; }
    }

    public enum OrderState
    {
        Preparing, //Hazırlanıyor
        Delivered,  //teslim
        Canceled,   //İptal
        Returned  //iade
    }
}
