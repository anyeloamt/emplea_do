using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Framework.Dto
{
    public class PullRequestEventPayload
    {
        public string Action { get; set; }

        public PullRequest Pullrequest { get; set; }
    }

    public class PullRequest
    {
        public PullRequestUser User { get; set; }

        public bool Merged { get; set; }

        public class PullRequestUser
        {
            public string Login { get; set; }
        }
    }
}
