using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Fixture:IEntity
    {
        public int Id { get; set; }
        public List<Referee> Referees { get; set; }
        public List<Team> Teams { get; set; }
        public DateTime MatchDate { get; set; }
        public List<Stadium> Stadiums { get; set; }
    }
}
