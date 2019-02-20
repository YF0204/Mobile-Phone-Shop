using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApplication
{
    public class AndroidPhone : MobilePhone
    {
        public AndroidPhone(string operatingSystem, string make, string model, DateTime datePurchased, decimal originalPrice, Condition condition, string colour, string storage)
            : base(operatingSystem, make, model, datePurchased, originalPrice, condition, colour, storage)
        {
            
        }
        public override decimal CalculateApproximateValue()
        {
            decimal value = 0;
            // modify the value based on the phone's condition
            if (condition == Condition.Mint)
            {
                value = originalPrice * 0.8m; // 80% of the original value
            }
            if (condition == Condition.Good)
            {
                value = originalPrice * 0.7m; // 70% of the original value
            }
            if (condition == Condition.Fair)
            {
                value = originalPrice * 0.5m; // 50% of the original value
            }
            if (condition == Condition.Poor)
            {
                value = originalPrice * 0.4m; // 40% of the original value
            }

            // calculate the age in years
            int phoneAge = CalculateApproximateAgeInYears();
            // lose 20% of the value each year - keep 80%
            for (int i = 0; i < phoneAge; i++)
            {
                value = value * 0.8m;
            }
            // return the value
            return value;
        }
    }
}