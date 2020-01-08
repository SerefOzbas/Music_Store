using MuazzamMusicStore.Core.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.Model
{
   public class Artist:BaseEntity
    {
       
        public string FullName { get; set; }
        public byte Rating { get; set; }

        //Mapping
        public virtual List<Albumler> Albums { get; set; }
    }
}
