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
    public class TeamStatisticManager:ITeamStatisticService
    {
        ITeamStatisticDal _teamStatisticDal;

        public TeamStatisticManager(ITeamStatisticDal teamStatisticDal)
        {
            _teamStatisticDal = teamStatisticDal;
        }

        public void Add(TeamStatistic teamStatistic)
        {
            _teamStatisticDal.Add(teamStatistic);
        }

        public void Delete(TeamStatistic teamStatistic)
        {
            _teamStatisticDal.Delete(teamStatistic);
        }

        public TeamStatistic Get(Expression<Func<TeamStatistic, bool>> filter)
        {
            return _teamStatisticDal.Get(filter);
        }

        public List<TeamStatistic> GetList(Expression<Func<TeamStatistic, bool>> filter = null)
        {
            return _teamStatisticDal.GetList(filter);
        }

        public void Update(TeamStatistic teamStatistic)
        {
            _teamStatisticDal.Update(teamStatistic);
        }
    }
}
