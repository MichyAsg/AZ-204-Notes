using AZ204Notes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AZ204Notes.Application.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
