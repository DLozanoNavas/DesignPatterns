using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// Abstract Product: Declares an interface for a type of product object
    /// </summary>
    public interface IDiscountService
    {
        double Discount { get;}
    }


    /// <summary>
    /// Abstract Product: Declares an interface for a type of product object
    /// </summary>
    public interface IShippingCostService
    {
        double Cost { get; }
    }


    /// <summary>
    /// Abstract Factory: Creates an interface for operations that create Abstract Product objects.
    /// </summary>
    public interface IShoppingCartServicesFactory
    {
        IDiscountService CreateDiscountService();
        IShippingCostService CreateShippingCostService();
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class ColombiaShippingService : IShippingCostService
    {
        public double Cost => 200;
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class SpainShippingService : IShippingCostService
    {
        public double Cost => 100;
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class ColombiaDiscountService : IDiscountService
    {
        public double Discount => 20;
    }

    /// <summary>
    /// Concrete Product
    /// </summary>
    public class SpainDiscountService : IDiscountService
    {
        public double Discount => 10;
    }

    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class SpainShoppingCartServicesFactory : IShoppingCartServicesFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new SpainDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new SpainShippingService();
        }
    }

    /// <summary>
    /// Concrete Factory
    /// </summary>
    public class ColombiaShoppingCartServicesFactory : IShoppingCartServicesFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new ColombiaDiscountService();
        }

        public IShippingCostService CreateShippingCostService()
        {
            return new ColombiaShippingService();
        }
    }



    /// <summary>
    /// Client: Should always use the Abstract Factory to get services
    /// </summary>
    public class ShoppingCart
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostService _shippingCostService;

        public ShoppingCart(IShoppingCartServicesFactory shoppingCartPurchaseFactory)
        {
            _discountService = shoppingCartPurchaseFactory.CreateDiscountService();
            _shippingCostService = shoppingCartPurchaseFactory.CreateShippingCostService();
        }

       public void CalculateCost(double orderCost)
       {
           Console.WriteLine($"Sub Total: {orderCost}");
           Console.WriteLine($"Total Shipment (+): {_shippingCostService.Cost}");
           Console.WriteLine($"Total Discount (-): {(orderCost / 100 * _discountService.Discount) }");
           Console.WriteLine($"Total: {orderCost - (orderCost / 100 * _discountService.Discount) + _shippingCostService.Cost}");
       }
    }



}
