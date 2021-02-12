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
    public class TeamManager:ITeamService
    {
        ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void Add(Team team)
        {
            _teamDal.Add(team);
        }

        public void Delete(Team team)
        {
            _teamDal.Delete(team);
        }

        public Team Get(Expression<Func<Team, bool>> filter)
        {
            return _teamDal.Get(filter);
        }

        public List<Team> GetList(Expression<Func<Team, bool>> filter = null)
        {
            return _teamDal.GetList(filter);
        }

        public void Update(Team team)
        {
            _teamDal.Update(team);
        }
    }
}
