﻿using StudyingMvcCore.Business.Models;
using System;
using System.Threading.Tasks;

namespace StudyingMvcCore.Business.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetCustomerToDos(Guid id);
        Task<Customer> GetCustomerAddress(Guid id);
        Task<Customer> GetCustomerAdressToDos(Guid id);
    }
}
