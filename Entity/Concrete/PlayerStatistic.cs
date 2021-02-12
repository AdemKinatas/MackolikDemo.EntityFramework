using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PlayerStatistic:IEntity
    {
        public int Id { get; set; }
        public int GoalNumber { get; set; }
        public int AssistNumber { get; set; }
        public int YellowCardNumber { get; set; }
        public int RedCardNumber { get; set; }
        public int InjuryNumber { get; set; }
        public int MatchNumber { get; set; }
        public List<Player> Players { get; set; }
    }
}
