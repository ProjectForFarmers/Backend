﻿using ProjectForFarmers.Application.DataTransferObjects.Dashboard;
using ProjectForFarmers.Application.ViewModels.Dashboard;
using ProjectForFarmers.Domain;

namespace ProjectForFarmers.Application.Services.Business
{
    public interface IDashboardService
    {
        Task<LoadDashboardVm> Load(Guid producerId, Producer producer);
        Task<DashboardVm> Get(Guid id);
        Task<DashboardVm> GetCurrentMonth(Guid producerId, Producer producer);
        Task<OptionListVm> CustomerAutocomplete(Guid producerId, Producer producer, string query, int count);
        Task<CustomerInfoVm> SearchCustomer(GetCustomerDto getCustomerDto);
    }
}
