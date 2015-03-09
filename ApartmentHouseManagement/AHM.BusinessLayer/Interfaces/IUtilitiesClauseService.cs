﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AHM.Common.DomainModel;

namespace AHM.BusinessLayer.Interfaces
{
    public interface IUtilitiesClauseService
    {
        Task<ICollection<UtilitiesClause>> GetAllUtilitiesClausesAsync(int buildingId);

        Task<ICollection<UtilitiesClause>> GetActiveUtilitiesClausesAsync(int buildingId);

        Task<UtilitiesClause> GetByIdAsync(int id);

        Task AddAsync(UtilitiesClause utilitiesClause);

        Task UpdateAsync(UtilitiesClause utilitiesClause);
    }
}