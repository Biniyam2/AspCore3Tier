using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IPersonRespository
    {
        Task<Person> GetPersonById(int Id);
        Task<Person> AddPerson(string firstName, string lastName, string email, string phoneNumber, string userName, string password);
        Task<List<Person>> GetAllPeople();
    }
}
