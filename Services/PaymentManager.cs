using Entities.Dtos.PaymentDtos;
using Entities.Dtos.SiteDtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PaymentManager : IPaymentService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IRepositoryManager _repositoryManager;

        public PaymentManager(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IRepositoryManager repositoryManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _repositoryManager = repositoryManager;
        }

        public async Task<bool> CreatePayment(CreatePaymentDto createPayment)
        {
            var user = await _userManager.FindByNameAsync(createPayment.UserName);
            var membership = await _repositoryManager.MembershipRepository.GetMembershipByIdAsync(createPayment.MembershipId);

            if (user is null || membership is null)
                throw new Exception("An error occured");
            if(createPayment.Payment == membership.Price)
            {
                user.LastPaymentDate = DateTime.Now;
                user.Membership = membership;
                await _userManager.AddToRoleAsync(user, "SiteManager");

                var site = new Site
                {
                    Name = user.UserName,
                };
                _repositoryManager.SiteRepository.CreateOneSite(site);

                var apartment = new Apartment
                {
                    Name = user.UserName,
                    Site = site,
                };
                _repositoryManager.ApartmentRepository.CreateApartment(apartment);

                var house = new House
                {
                    Num = 1,
                    Apartment = apartment,
                    AppUser = user,
                };
                _repositoryManager.HouseRepository.CreateHouse(house);

                return true;
            }
            else
            {
                return false;
                throw new Exception("Payment amount is not correct");
            }

        }
    }
}
