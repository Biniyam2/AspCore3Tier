using DataAccess.DataContext;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//http://localhost:55810/api/person/add?firstName=Biniyam&lastName=Yemane&email=Test@gmail.com&phoneNumber=1238547589&userName=Benji&password=abcd1234&id=1
namespace DataAccess.Repositories.Implimentations
{
    public class PersonRespository : IPersonRespository
    {
        public async Task<Person> AddPerson(string firstName, string lastName, string email, string phoneNumber, string userName, string password)
        {
            
            var pepole = new Person()
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                UserName = userName,
                Password = password
            };

            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                await context.PeopleDb.AddAsync(pepole);
                await context.SaveChangesAsync();
            }
            return pepole;
        }

        public async Task<List<Person>> GetAllPeople()
        {
            List<Person> people = new List<Person>();
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                people = await context.PeopleDb.ToListAsync();
            }
            return people;
        }

        public async Task<Person> GetPersonById(int Id)
        {
            var people = new Person();
            using (var context = new DatabaseContext(DatabaseContext.ops.dbOptions))
            {
                people = await context.PeopleDb.FindAsync(Id);
            }
            return people;
        }
    }
}




