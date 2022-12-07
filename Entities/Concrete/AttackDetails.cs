using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public  class AttackDetails : IEntity
    {
        public int AttackId { get; set; }
        public string AttackDescription { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string AttackType { get; set; }

    }
}
