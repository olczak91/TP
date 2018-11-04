using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace models
{
    public class Client
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Email
        {
            get => email;
            set => email = value;
        }

    }
}
