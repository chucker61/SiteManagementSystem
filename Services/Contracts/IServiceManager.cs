using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IServiceManager
    {
        ISiteService SiteService { get; }
        IAuthenticationService AuthenticationService { get; }
        IApartmentService ApartmentService { get; }
        IHouseService HouseService { get; }
        IMembershipService MembershipService { get; }
        IPaymentService PaymentService { get; }
    }
}
