﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainChat.Entities
{
    public class ApplicationUser 
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsOnline { get; set; } = false;
        public string Role { get; set; }
    }
}