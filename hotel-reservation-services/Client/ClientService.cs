using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using hotel_reservation_services.ViewModel;
using hotel_reservation_DAL.Contexts;

namespace hotel_reservation_services.Client
{
    public class ClientService : IClientService
    {
        private readonly IServiceProvider _serviceProvider;

        private HotelReservationContext _context;
        protected HotelReservationContext Context => _context ?? (_context = _serviceProvider.GetService<HotelReservationContext>());

        private IMapper _mapper;
        protected IMapper Mapper => _mapper ?? (_mapper = _serviceProvider.GetService<IMapper>());

        public ClientService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public List<ClientModel> GetClients()
            => Context.Clients.AsNoTracking().ToList().Select(x => Mapper.Map<ClientModel>(x)).ToList();

        public ClientModel GetClient(int clientId)
            => Mapper.Map<ClientModel>(Context.Clients.FirstOrDefault(x => x.ID == clientId));
    }
}