using ServiceReceiver.Models.YClients;

namespace ServiceReceiver.Services.YClients
{
    public interface IYClientsFacade
    {
        Task<IReadOnlyCollection<Company>> GetCompanies(ServiceType serviceType);
        Task<IReadOnlyCollection<StaffMember>> GetStaff(long companyId);
        Task<SeanceDate> GetSeanceDate(long companyId, long staffId);
    }
}
