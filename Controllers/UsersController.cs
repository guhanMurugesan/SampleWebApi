using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    public class UsersController : ApiController
    {
        UserModel[] users = new UserModel[]
        {
            new UserModel(){ UserId = 100, Username = "guhan", Location = "chennai", Age = 23},
            new UserModel(){UserId = 101, Username = "Bala",Location="chennai",Age=22}
        };

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserModel> GetAllUsers()
        {
            return users;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetUser(long id)
        {
            var user = users.FirstOrDefault((u) => u.UserId == id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
