using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.Core.DAL.EntityFramework
{
   public class EFSingletonContext<TContext>
        where TContext:DbContext,new()
    {

        //bu classın instance'ı alınabilir,ileride dene!
        private static TContext _context;
        public static TContext Instance
        {
            get
            {
                if (_context==null)
                {
                    _context = new TContext();
                }
                return _context;
            }
        }
    }
}
