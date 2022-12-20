using ShoppingCart.DataAccess.Data;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public class ApplicationUserRepository: Repository<ApplicationUser>, IApplicationUser
    {
        private ApplicationDbContext _context;
        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(ApplicationUser applicationUser)
        {
            var user = _context.ApplicationUsers.FirstOrDefault(x => x.Id == applicationUser.Id);
            if(user != null)
            {
                applicationUser.UserName = user.UserName;
                applicationUser.Email = user.Email;
                applicationUser.Address=user.Address;
                applicationUser.PhoneNumber=user.PhoneNumber;
                
            }
        }
    }
}
