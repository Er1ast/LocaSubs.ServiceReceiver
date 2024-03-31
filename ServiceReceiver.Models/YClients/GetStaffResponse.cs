namespace ServiceReceiver.Models.YClients;

public class GetStaffResponse
{
    public bool Success { get; set; }
    public IReadOnlyCollection<StaffMember>? Data { get; set; }
}
