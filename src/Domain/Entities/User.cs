﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        protected User() { }

        public User(string login, string password) : this()
        {
            Id = Guid.NewGuid();
            Login = login;
            Password = password;
        }
    }
}