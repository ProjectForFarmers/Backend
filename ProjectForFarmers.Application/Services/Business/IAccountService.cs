﻿using FarmersMarketplace.Application.DataTransferObjects;
using FarmersMarketplace.Application.DataTransferObjects.Account;
using FarmersMarketplace.Application.ViewModels.Account;
using FarmersMarketplace.Domain;

namespace FarmersMarketplace.Application.Services.Business
{
    public interface IAccountService
    {
        Task<CustomerVm> GetCustomer(Guid accountId);
        Task UpdateCustomer(UpdateCustomerDto dto, Guid accountId);
        Task UpdateCustomerPaymentData(CustomerPaymentDataDto dto, Guid accountId);
        Task<SellerVm> GetSeller(Guid accountId);
        Task UpdateSeller(UpdateSellerDto dto, Guid accountId);
        Task UpdateSellerCategoriesAndSubcategories(SellerCategoriesAndSubcategoriesDto dto, Guid accountId);
        Task<FarmerVm> GetFarmer(Guid accountId);
        Task UpdateFarmer(UpdateFarmerDto dto, Guid accountId);
        Task UpdateFarmerPaymentData(ProducerPaymentDataDto dto, Guid accountId);
        Task UpdateSellerPaymentData(UpdateProducerPaymentDataDto dto, Guid accountId);
        Task DeleteAccount(Role role, Guid accountId);
    }
}
