﻿using System;

namespace OS.WpfDevExpressPlc.Domain.Entities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public DateTime StartDate { get; set; }
        public int Salary { get; set; }

    }
}
