using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleBudget.Data;
using SimpleBudget.Data.Models;

namespace SimpleBudget.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly IDataRepository _dataRepository;

        public IncomeController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
    }
}
