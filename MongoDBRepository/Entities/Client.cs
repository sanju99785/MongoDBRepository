using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDBRepository.Entities
{

    public class Employee : Entity
    {
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public double Mobile { get; set; }
    }
}