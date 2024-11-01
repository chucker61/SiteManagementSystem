using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        ISiteRepository SiteRepository { get; }
        IApartmentRepository ApartmentRepository { get; }
        IHouseRepository HouseRepository { get; }
        IMembershipRepository MembershipRepository { get; }
        Task SaveAsync();
    }
}
