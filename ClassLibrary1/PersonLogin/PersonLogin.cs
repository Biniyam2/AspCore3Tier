using DataAccess.DataContext;
using DataAccess.Models;
using DataAccess.Repositories;
using DataAccess.Repositories.Implimentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.PersonLogin
{
    public class PersonLogin
    {
        private IPersonRespository _personRespository = new PersonRespository();
        public async Task<bool> CreateUser (string firstName, string lastName, string email, string phoneNumber, string userName, string password)
        {
            try
            {
                var result = await _personRespository.AddPerson(firstName, lastName, email, phoneNumber, userName, password);
                if (result.Id < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }  
          
        }
        public async Task<List<Person>> GetAllPeople() 
        {
            List<Person> people = await _personRespository.GetAllPeople();
            return people;
        }
    }
}
