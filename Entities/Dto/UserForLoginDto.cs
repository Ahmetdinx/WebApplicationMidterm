﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class UserForLoginDto:IDto
    {
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
