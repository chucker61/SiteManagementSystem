using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly ISiteService _siteService;
        private readonly IAuthenticationService _authenticationService;
        private readonly IApartmentService _apartmentService;
        private readonly IHouseService _houseService;
        private readonly IMembershipService _membershipService;
        private readonly IPaymentService _paymentService;

        public ServiceManager(ISiteService siteService, IAuthenticationService authenticationService, IApartmentService apartmentService, IHouseService houseService, IMembershipService membershipService, IPaymentService paymentService)
        {
            _siteService = siteService;
            _authenticationService = authenticationService;
            _apartmentService = apartmentService;
            _houseService = houseService;
            _membershipService = membershipService;
            _paymentService = paymentService;
        }

        public ISiteService SiteService => _siteService;
        public IAuthenticationService AuthenticationService => _authenticationService;
        public IApartmentService ApartmentService => _apartmentService;
        public IHouseService HouseService => _houseService;
        public IMembershipService MembershipService => _membershipService;
        public IPaymentService PaymentService => _paymentService;
    }
}
