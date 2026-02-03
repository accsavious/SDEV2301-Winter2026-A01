using PointOfSaleSystem;
namespace POSTest
{
    public class POSTest
    {
        [Fact]
        public void POSProcessTransactionReturnsCorrectNumber()
        {
            double cost = 7;
            double cash = 8;
            PointOfSale pos = new PointOfSale();
            double test = cash - cost;

            Assert.Equal(test, pos.ProcessTransaction(cost, cash));
        }

        [Fact]
        public void POSProcessTransactionInsufficientFundsThrowsArgumentOutOfRangeException()
        {
            PointOfSale pos = new PointOfSale();

            Assert.Throws<ArgumentOutOfRangeException>(() => pos.ProcessTransaction(2, 1));
        }
        [Theory]
        [InlineData("Bronze", 0.9)]
        [InlineData("Silver", 0.8)]
        [InlineData("Gold", 0.7)]
        public void ApplyDiscountReturnsCorrectValues(string loyalty, double discount)
        {
            double cost = 2;
            PointOfSale pos = new PointOfSale();
            double test = Math.Round(discount * cost, 2);
            Assert.Equal(test, pos.ApplyDiscount(loyalty, cost));
        }

        [Fact]
        public void ApplyDiscountEmptyLoyaltyThrowsArgumentNullException()
        {
            PointOfSale pos = new PointOfSale();
            Assert.Throws<ArgumentNullException>(() => pos.ApplyDiscount("", 1));
        }

        [Fact]
        public void AppliedInvalidCouponThrowsArgumentException()
        {
            Coupon invalid = new Coupon(0.1, false);
            PointOfSale pos = new PointOfSale();
            Assert.Throws<ArgumentException>(() => pos.ApplyCoupon(1, invalid));
        }
        [Fact]
        public void AppliedCouponReturnsCorrectValue()
        {
            double cost = 10;
            double discount = 0.2;

            PointOfSale pos = new PointOfSale();
            Coupon coupon = new Coupon(discount, true);
            double test = Math.Round(cost - (cost * discount));
            Assert.Equal(test, Math.Round(pos.ApplyCoupon(cost, coupon)));
        }

    }

    public class CouponTest
    {
        [Fact]
        public void CouponAttributesReturnCorrectValues()
        {
            double discount = 1;
            bool validity = true;
             
            Coupon coupon = new Coupon(discount, validity);

            Assert.Equal((discount,validity), (coupon.Discount, coupon.IsValid));
        }
    }
}
