using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Season:IEntity
    {
        public int Id { get; set; }
        public DateTime SeasonDate { get; set; }
        public List<Team> Teams { get; set; }
    }
}
