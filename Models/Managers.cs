using System;
using System.Collections.Generic;

namespace CRUD_Operations.Models
{
    public partial class Managers
    {
        public Managers()
        {
            Projects = new HashSet<Projects>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int Gender { get; set; }
        public string Team { get; set; }
        public DateTimeOffset Created { get; set; }

        public virtual ICollection<Projects> Projects { get; set; }
    }
}
