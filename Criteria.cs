using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi
{
    public class Criteria
    {
        public int Id { get; set; }
        public List<Criteria> Criterias { get; set;  } = new List<Criteria>();
    }
}