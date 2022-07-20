using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CRUD_project.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        [DisplayName("FirstName")]
        public string FirstName { get; set; } = null!;
        [DisplayName("LastName")]
        public string? LastName { get; set; }
    }
}
