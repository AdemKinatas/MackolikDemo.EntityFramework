using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Team:IEntity
    {
        public int Id { get; set; }
        public int TeamStatisticId { get; set; }
        public int FixtureId { get; set; }
        public string TeamName { get; set; }
        public List<Player> Players { get; set; }
        public TeamStatistic TeamStatistic { get; set; }
        public Stadium Stadium { get; set; }
        public List<Season> Seasons { get; set; }
        public Fixture Fixture { get; set; }
    }
}
