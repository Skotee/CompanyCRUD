using System;
using System.Collections.Generic;

namespace CRUD_Operations.Models
{
    public partial class Projects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public string HealthCondition { get; set; }
        public int ManagerId { get; set; }
        public int LeaderId { get; set; }
        public DateTimeOffset Created { get; set; }

        public virtual Managers Manager { get; set; }
        public virtual Leaders Leader { get; set; }
    }
}
