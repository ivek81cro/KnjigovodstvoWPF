using KnjigeDataManager.Library.Internal.DataAccess;
using KnjigeDataManager.Library.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnjigeDataManager.Library.DataAccess
{
    public class UserData
    {
        private IConfiguration _config;
        public UserData(IConfiguration config)
        {
            _config = config;
        }
        public List<UserModel> GetUserById(int id)
        {
            SqlDataAccess sql = new SqlDataAccess(_config);

            var p = new { Id = id };//anonimous object, no name

            var output = sql.LoadData<UserModel, dynamic>("spUserLookup", p, "KnjigeData");

            return output;
        }
    }
}
