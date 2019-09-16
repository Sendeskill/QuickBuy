﻿using QuickBuy.Domain.Contract.Managers;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract
{
    public interface IUserRepository : IRepository<User>
    {
        Task Register(IUserManager param);
    }
}
