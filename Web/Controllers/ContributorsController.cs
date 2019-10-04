using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AppServices.Services;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.ViewModels;

namespace Web.Controllers
{
    public class ContributorsController : BaseController
    {
        //private IJobsService _jobsService;

        //public ContributorsController(IJobsService jobsService)
        //{
        //    _jobsService = jobsService;
        //}

        [HttpPost]
        public IActionResult Create()
        {
            throw new NotImplementedException();
        }
    }
}
