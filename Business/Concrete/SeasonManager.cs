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
    public class SeasonManager:ISeasonService
    {
        ISeasonDal _seasonDal;

        public SeasonManager(ISeasonDal seasonDal)
        {
            _seasonDal = seasonDal;
        }

        public void Add(Season season)
        {
            _seasonDal.Add(season);
        }

        public void Delete(Season season)
        {
            _seasonDal.Delete(season);
        }

        public Season Get(Expression<Func<Season, bool>> filter)
        {
            return _seasonDal.Get(filter);
        }

        public List<Season> GetList(Expression<Func<Season, bool>> filter = null)
        {
            return _seasonDal.GetList(filter);
        }

        public void Update(Season season)
        {
            _seasonDal.Update(season);
        }
    }
}
