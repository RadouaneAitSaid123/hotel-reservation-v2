using hotel_reservation_services.ViewModel;

namespace hotel_reservation_services.Client
{
    public interface IClientService
    {
        List<ClientModel> GetClients();
        ClientModel GetClient(int clientId);
    }
}