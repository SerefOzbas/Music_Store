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
    public class UserService : IUserService
    {
        IUserDAL _userDAL;
        public UserService(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }
        public void DeleetById(int entityID)
        {
            User user = _userDAL.Get(a => a.ID == entityID);
            Delete(user);
        }

        public void Delete(User entity)
        {
            _userDAL.Remove(entity);
        }

        public User Get(int entityID)
        {
            return _userDAL.Get(a => a.ID == entityID);
        }

        public ICollection<User> GetAll()
        {
            return _userDAL.GetAll().ToList();
        }

        public User GetUserByLogin(string userName, string password)
        {
            return _userDAL.Get(a => a.UserName == userName && a.Password == password);
        }

        public void Insert(User entity)
        {
            _userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            _userDAL.Update(entity);
        }
    }
}
