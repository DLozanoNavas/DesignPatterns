using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// Subsystem class
    /// </summary>
    public class Cart
    {
        public Cart(double total)
        {
            Total = total;
        }
        public double Total { get; set; }

    }

    /// <summary>
    /// Subsystem class
    /// </summary>
    public class CustomerDiscountBaseService
    {
        public double GetDiscountPercentage(Cart cart)
        {
            return (cart.Total > 10) ? 10 : 0;
        }
    }

    /// <summary>
    /// Subsystem class
    /// </summary>
    public class DayOfTheWeekDiscountService
    {
        public double CalculateDayOfTheWeekDiscount()
        {
            // fake calculation for demo purposes
            return DateTime.UtcNow.DayOfWeek switch
            {
                DayOfWeek.Saturday => 10,
                DayOfWeek.Sunday => 10,
                DayOfWeek.Monday => 1,
                DayOfWeek.Tuesday => 2,
                DayOfWeek.Wednesday => 3,
                DayOfWeek.Thursday => 4,
                DayOfWeek.Friday => 5,
                _ => 0
            };
        }
    }

    /// <summary>
    /// Facade
    /// </summary>
    public class CartsServiceFacade
    {
        private readonly CustomerDiscountBaseService _customerDiscountBaseService = new();
        private readonly DayOfTheWeekDiscountService _dayOfTheWeekDiscountService = new();

        public double CalculateDiscountPercentage(Cart cart)
        {
            return _customerDiscountBaseService.GetDiscountPercentage(cart) + _dayOfTheWeekDiscountService.CalculateDayOfTheWeekDiscount();
        }

    }
}
