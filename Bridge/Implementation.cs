namespace Bridge
{
    /// <summary>
    /// Abstraction
    /// </summary>
    public abstract class Cart
    {
        protected readonly ICoupon _coupon;
        protected double Amount { get; }
        protected double Total { get; set; }

        protected Cart(ICoupon coupon)
        {
            _coupon = coupon;
            Amount = 200;
        }

        public abstract void CalculateTotal();
    }

    /// <summary>
    /// Implementor
    /// </summary>
    public interface ICoupon
    {
        double CouponValue { get; }
    }

    /// <summary>
    /// Redefined Abstraction
    /// </summary>
    public class SpainCart : Cart
    {
        public SpainCart(ICoupon coupon) : base(coupon)
        {
        }
        public override void CalculateTotal()
        {
            Total = Amount - (Amount * (_coupon.CouponValue / 100));

            Console.WriteLine($"SPAIN CART");
            Console.WriteLine($"Sub Total: ${Amount}");
            Console.WriteLine($"Discount: {(_coupon.CouponValue)}%");
            Console.WriteLine($"Total: ${Total}");
        }
    }
    /// <summary>
    /// Redefined Abstraction
    /// </summary>
    public class ItalyCart : Cart
    {
        public ItalyCart(ICoupon coupon) : base(coupon)
        {
        }
        public override void CalculateTotal()
        {
            Total = Amount - (Amount * (_coupon.CouponValue / 100));
            Console.WriteLine($"ITALY CART");
            Console.WriteLine($"Sub Total: ${Amount}");
            Console.WriteLine($"Discount: {(_coupon.CouponValue)}%");
            Console.WriteLine($"Total: ${Total}");
        }
    }
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class NoCoupon : ICoupon
    {
        public double CouponValue => 0;
    }
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class FivePercentCoupon : ICoupon
    {
        public double CouponValue => 5;
    }
    /// <summary>
    /// Concrete Implementor
    /// </summary>
    public class TenPercentCoupon : ICoupon
    {
        public double CouponValue => 10;
    }


}
