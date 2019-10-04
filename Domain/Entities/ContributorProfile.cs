using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ContributorProfile : Entity
    {
        public string Login { get; set; }

        public string Name { get; set; }

        public string Bio { get; set; }

        public string AvatarUrl { get; set; }

        public string Blog { get; set; }

        public bool Hireable { get; set; }
    }
}
