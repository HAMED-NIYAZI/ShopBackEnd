using Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Entity.Common.Enums;

namespace Domain.Entity
{
    public class User : BaseEntity
    {
  
        public int Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        //public List<Address> Addresses { get; set; }
        public UserType UserType { get; set; }


    }
}
