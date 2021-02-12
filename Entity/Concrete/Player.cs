using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int PlayerStatisticId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Position { get; set; }
        public bool InjuryStatus { get; set; }
        public Team Team { get; set; }
        public PlayerStatistic PlayerStatistic { get; set; }
    }
}
