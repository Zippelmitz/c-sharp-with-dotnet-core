﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lesson22Xam
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
