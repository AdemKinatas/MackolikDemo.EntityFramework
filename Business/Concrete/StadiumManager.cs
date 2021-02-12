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
    public class StadiumManager:IStadiumService
    {
        IStadiumDal _stadiumDal;

        public StadiumManager(IStadiumDal stadiumDal)
        {
            _stadiumDal = stadiumDal;
        }

        public void Add(Stadium stadium)
        {
            _stadiumDal.Add(stadium);
        }

        public void Delete(Stadium stadium)
        {
            _stadiumDal.Delete(stadium);
        }

        public Stadium Get(Expression<Func<Stadium, bool>> filter)
        {
            return _stadiumDal.Get(filter);
        }

        public List<Stadium> GetList(Expression<Func<Stadium, bool>> filter = null)
        {
            return _stadiumDal.GetList(filter);
        }

        public void Update(Stadium stadium)
        {
            _stadiumDal.Update(stadium);
        }
    }
}
