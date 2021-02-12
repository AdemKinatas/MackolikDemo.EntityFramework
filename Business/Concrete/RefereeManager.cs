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
    public class RefereeManager : IRefereeService
    {
        IRefereeDal _refereeDal;

        public RefereeManager(IRefereeDal refereeDal)
        {
            _refereeDal = refereeDal;
        }

        public void Add(Referee referee)
        {
            _refereeDal.Add(referee);
        }

        public void Delete(Referee referee)
        {
            _refereeDal.Delete(referee);
        }

        public Referee Get(Expression<Func<Referee, bool>> filter)
        {
            return _refereeDal.Get(filter);
        }

        public List<Referee> GetList(Expression<Func<Referee, bool>> filter = null)
        {
            return _refereeDal.GetList(filter);
        }

        public void Update(Referee referee)
        {
            _refereeDal.Update(referee);
        }
    }
}
