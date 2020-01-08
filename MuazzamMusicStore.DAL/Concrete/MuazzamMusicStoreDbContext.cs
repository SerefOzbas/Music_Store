using MuazzamMusicStore.DAL.Concrete.EntityFramework;
using MuazzamMusicStore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuazzamMusicStore.DAL.Concrete
{
   public class MuazzamMusicStoreDbContext:DbContext
    {
        public MuazzamMusicStoreDbContext():base("Server=.;Database=MuazzamStoreDb;Integrated Security=true;")
        {
            Database.SetInitializer<MuazzamMusicStoreDbContext>(new MyStrategy());
        }

        public DbSet<Albumler> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderDetailMapping());

            modelBuilder.Properties().Where(a => a.PropertyType == typeof(DateTime)).Configure(a => a.HasColumnType("datetime2"));
            //c# tarafında veri tabanında uyuşmayan bir veri tipi varsa onu değiştirmek için mapping yazarız

            //sql'de burada kullandığımız datetime.now'ı karşılaması için veritabanındaki propertylerden default value or binding:getDate()  yazarsak çakışma olmaz
        }
    }
}
