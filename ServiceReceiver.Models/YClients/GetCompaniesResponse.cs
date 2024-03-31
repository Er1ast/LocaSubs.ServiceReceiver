namespace ServiceReceiver.Models.YClients
{
    public class GetCompaniesResponse
    {
        public bool Success { get; set; }
        public IReadOnlyCollection<Company>? Data { get; set; }
    }
}
