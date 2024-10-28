﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models
{
    internal sealed class LibraryMember : Person
    {
        public DateTime MembershipDate;
        public LibraryMember(string name) : base(name)
        {
        }
    }
}
