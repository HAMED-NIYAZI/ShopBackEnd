using Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Course : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int Price { get; set; }

        public int Code { get; set; }

        public string ImagePath { get; set; }

        public int LevelId { get; set; }
         public DateTime LastUpdate { get; set; }


        



    }
}
