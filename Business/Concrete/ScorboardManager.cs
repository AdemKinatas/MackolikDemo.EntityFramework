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
    public class ScorboardManager:IScorboardService
    {
        IScorboardDal _scorboardDal;

        public ScorboardManager(IScorboardDal scorboardDal)
        {
            _scorboardDal = scorboardDal;
        }

        public void Add(Scorboard scorboard)
        {
            _scorboardDal.Add(scorboard);
        }

        public void Delete(Scorboard scorboard)
        {
            _scorboardDal.Delete(scorboard);
        }

        public Scorboard Get(Expression<Func<Scorboard, bool>> filter)
        {
            return _scorboardDal.Get(filter);
        }

        public List<Scorboard> GetList(Expression<Func<Scorboard, bool>> filter = null)
        {
            return _scorboardDal.GetList(filter);
        }

        public void Update(Scorboard scorboard)
        {
            _scorboardDal.Update(scorboard);
        }
    }
}
