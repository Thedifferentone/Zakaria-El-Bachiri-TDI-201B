﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RecipesApi.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
