using AspCore3Tier.Models;
using ClassLibrary1.PersonLogin;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore3Tier.Controllers
{
    [Route("api/person/")]
    [ApiController]
    public class PersonController : Controller
    {
        PersonLogin _personLogin = new PersonLogin();
       
        [Route("add")]
        [HttpGet]
        public async Task<Boolean> AddUser(string firstName, string lastName, string email, string phoneNumber, string userName, string password) 
        {
            bool result = await _personLogin.CreateUser(firstName, lastName, email, phoneNumber, userName, password);
            return result;
        }
        [Route("all")]
        [HttpGet]
        public async Task<List<Person>> GetPeople()
        {
            List<Person> AspPeopl = new List<Person>();
            List<DataAccess.Models.Person> people = await _personLogin.GetAllPeople();
            foreach (var item in people)
            {
                Person person = new Person
                { 
                    Email = item.Email,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    PhoneNumber = item.PhoneNumber,
                    Id = item.Id,
                    UserName = item.UserName
                };
                AspPeopl.Add(person);
            }
            return AspPeopl;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
