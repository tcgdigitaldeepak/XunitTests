using System.Collections.Generic;
using WebApiWithTest.Models;

namespace WebApiWithTest.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        Person Add(Person person);
        void Update(int id, Person person);
        void Delete(int id);
    }
}