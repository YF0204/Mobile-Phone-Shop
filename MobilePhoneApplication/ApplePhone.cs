using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApplication
{
    public class ApplePhone : MobilePhone
    {
        public ApplePhone(string operatingSystem, string make, string model, DateTime datePurchased, decimal originalPrice, Condition condition, string colour, string storage)
            : base(operatingSystem, make, model, datePurchased, originalPrice, condition, colour, storage)
        {
            
        }

        // this calculation is overriden in both the inheriting classes
        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;
            // modifty the value of the phones based on the condition
            if (condition == Condition.Mint)
            {
                value = originalPrice * 0.9m; // 90% of original value
            }
            else if (condition == Condition.Good)
            {
                value = originalPrice * 0.8m; // 80% of original value
            }
            else if (condition == Condition.Fair)
            {
                value = originalPrice * 0.7m; // 70% of original value
            }
            else if (condition == Condition.Poor)
            {
                value = originalPrice * 0.5m; // 50% of original value
            }
            int age = CalculateApproximateAgeInYears();
            // lose 10% of the value each year - keep 90%
            for (int i = 0; i < age; i++)
            {
                value = value * 0.9m;
            }
            // return the value
            return value;
        }
    }
}
