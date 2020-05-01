﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AgroContainerTracker.Domain.Companies;

namespace AgroContainerTracker.Core.Services
{
    public interface ICarrierService
    {
        Task<List<Carrier>> GetAllAsync();
        
        Task<Carrier> GetByIdAsync(int carrierId);

        Task AddAsync(AddCarrierRequest carrier);

        Task<bool> DeleteAsync(int carrierId);

    }
}
