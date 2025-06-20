﻿using PharmacySystem.ApplicationLayer.Common;
using PharmacySystem.ApplicationLayer.DTOs.Pharmacy.Login;
using PharmacySystem.ApplicationLayer.DTOs.Pharmacy.Register;
using PharmacySystem.ApplicationLayer.DTOs.representative.Create;
using PharmacySystem.ApplicationLayer.DTOs.representative.Read;
using PharmacySystem.ApplicationLayer.DTOs.representative.Update;
using PharmacySystem.ApplicationLayer.DTOs.RepresentatitvePharmacies;
using PharmacySystem.ApplicationLayer.DTOs.RepresentatitvePharmaciesOrdersAndOrderDetails;


namespace PharmacySystem.ApplicationLayer.IServiceInterfaces
{
    public interface IRepresentativeService
    {
        Task<IEnumerable<GetAllRepresentatitveDto>> GetAllAsync();
        Task<GetRepresentativeByIdDto> GetByIdAsync(int id);
        Task<GetRepresentativeByIdDto> CreateAsync(CreateRepresentativeDto dto);
        Task<GetRepresentativeByIdDto> UpdateAsync(int id, UpdateRepresentativeDto dto);
        Task<bool> DeleteAsync(int id);
        Task<GetRepresentatitvePharmaciesCountDto> GetPharmaciesCountById(int id);
        Task<GetRepresentatitvePharmaciesCountDto> GetPharmaciesCountByCode(string code);
        Task<GetOrdersPharmaciesCountDto> GetOrdersCountById(int id);
        Task<RepresentativeLoginResponseDTO> LoginAsync(RepresentativeLoginDTO dto);
    }
}
