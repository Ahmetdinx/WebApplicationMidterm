﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class UserForUpdateDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordToCheck { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
