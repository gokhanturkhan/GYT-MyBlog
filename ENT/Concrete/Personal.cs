using ENT.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ENT.Concrete
{
    public class Personal : IEntity
    {
        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RankId { get; set; }

    }
}
