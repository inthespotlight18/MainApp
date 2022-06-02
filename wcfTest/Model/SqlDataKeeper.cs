using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DataFromSqlReader
    {
        public DataFromSqlReader(string firstName, string lastName, string age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Age { get; private set; }
        public string Email { get; private set; }














    }

}
