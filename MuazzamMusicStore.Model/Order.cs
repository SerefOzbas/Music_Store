using MuazzamMusicStore.Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.Model
{
   public class Order:BaseEntity
    {

        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShippAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int UserID { get; set; }
        public int ShipperID { get; set; }

        //Mapping
        public virtual List<OrderDetail>orderDetails { get; set; }
        public virtual User UserDetail { get; set; }
        public virtual Shipper Shipper { get; set; }

    }
}
