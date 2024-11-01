using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.PaymentDtos
{
    public class CreatePaymentDto
    {
        public string UserName { get; set; }
        public decimal Payment { get; set; }
        public int MembershipId { get; set; }
    }
}
