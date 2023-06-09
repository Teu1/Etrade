﻿using ETrade.Core;
using ETrade.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Rep.Abstracts
{
    public interface IUserRepos : IBaseRepository<Users>
    {
        public bool Login(Users user);

        public void Logout();

        public bool Register(Users user);
    }
}