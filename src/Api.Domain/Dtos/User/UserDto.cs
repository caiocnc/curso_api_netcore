﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos.User
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatAt { get; set; }
    }
}
