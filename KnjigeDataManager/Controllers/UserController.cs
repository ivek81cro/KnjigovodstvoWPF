using KnjigeDataManager.Library.DataAccess;
using KnjigeDataManager.Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace KnjigeDataManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IConfiguration _config;
        public UserController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public UserModel GetById()
        {
            int userId = 2;
            UserData data = new UserData(_config);

            return data.GetUserById(userId).First();
        }
    }
}
