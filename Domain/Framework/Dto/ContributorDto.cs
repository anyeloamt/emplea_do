using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Framework.Dto
{
    public class ContributorDto
    {
        public string login { get; set; }

        public string name { get; set; }

        public string bio { get; set; }

        public string avatar_url { get; set; }

        public string blog { get; set; }

        public bool hireable { get; set; }
    }
}
