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
    public class FixtureManager : IFixtureService
    {
        IFixtureDal _fixtureDal;

        public FixtureManager(IFixtureDal fixtureDal)
        {
            _fixtureDal = fixtureDal;
        }

        public void Add(Fixture fixture)
        {
            _fixtureDal.Add(fixture);
        }

        public void Delete(Fixture fixture)
        {
            _fixtureDal.Delete(fixture);
        }

        public Fixture Get(Expression<Func<Fixture, bool>> filter)
        {
            return _fixtureDal.Get(filter);
        }

        public List<Fixture> GetList(Expression<Func<Fixture, bool>> filter = null)
        {
            return _fixtureDal.GetList(filter).ToList();
        }

        public void Update(Fixture fixture)
        {
            _fixtureDal.Update(fixture);
        }
    }
}
