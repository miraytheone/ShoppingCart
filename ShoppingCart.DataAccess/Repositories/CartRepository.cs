using ShoppingCart.DataAccess.Data;
using ShoppingCart.DataAccess.ViewModels;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.DataAccess.Repositories
{
    public class CartRepository: Repository<Cart>, ICartRepository
    {
        private ApplicationDbContext _context;

        public CartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void DecrementCartItem(Cart cart, int v)
        {
            throw new NotImplementedException();
        }

        public void IncrementCartItem(Cart cart, int v)
        {
            throw new NotImplementedException();
        }

        public void Update(Cart cart)
        {
            var cartDB = _context.Carts.FirstOrDefault(c => c.Id == cart.Id);
            if(cartDB != null)
            {
                cart.Product = cartDB.Product;  
                cart.ApplicationUser=cartDB.ApplicationUser;
            }
        }
    }
}
