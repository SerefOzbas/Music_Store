using MuazzamMusicStore.Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.Model
{
   public class Genre:BaseEntity
    {
        //Genre:Tür
        public string Name { get; set; }
        public string Description { get; set; }

        //Mapping
        public virtual List<Albumler>Albums { get; set; }
    }
}
