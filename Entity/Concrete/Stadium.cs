using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Stadium : IEntity
    {
        public int Id { get; set; }
        public int FixtureId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Team Team { get; set; }
        public Fixture Fixture { get; set; }
    }
}
