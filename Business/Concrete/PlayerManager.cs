using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlayerManager:IPlayerService
    {
        IPlayerDal _playerDal;

        public PlayerManager(IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public void Add(Player player)
        {
            _playerDal.Add(player);
        }

        public void Delete(Player player)
        {
            _playerDal.Delete(player);
        }

        public Player Get(Expression<Func<Player, bool>> filter)
        {
            return _playerDal.Get(filter);
        }

        public List<Player> GetList(Expression<Func<Player, bool>> filter = null)
        {
            return _playerDal.GetList(filter);
        }

        public void Update(Player player)
        {
            _playerDal.Update(player);
        }
    }
}
