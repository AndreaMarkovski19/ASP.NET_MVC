﻿using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Domain.Models;


namespace ToDoApp.Services.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        int AddNewUser(User entity);        
    }
}
