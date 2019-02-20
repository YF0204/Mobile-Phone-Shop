using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApplication
{
    // base class for mobile phones
    public abstract class MobilePhone
    {
        // rate the conditions of the mobile phones
        public enum Condition
        {
            Poor,
            Fair,
            Good,
            Mint
        };

        protected string operatingSystem;
        protected string make;
        protected string model;
        protected DateTime datePurchased;
        protected decimal originalPrice;
        protected Condition condition;
        protected string colour;
        protected string storage;


        // constructor for mobile phones
        public MobilePhone(string operatingSystem, string make, string model, DateTime datePurchased, decimal originalPrice, Condition condition, string colour, string storage)
        {
            this.operatingSystem = operatingSystem;
            this.model = model;
            this.make = make;
            this.datePurchased = datePurchased;
            this.originalPrice = originalPrice;
            this.condition = condition;
            this.colour = colour;
            this.storage = storage;
        }

        // calculate the approximate age in years to calculate the overall value
        public int CalculateApproximateAgeInYears()
        {
            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(datePurchased);
            int ageInYears = ageAsTimeSpan.Days / 365;
            return ageInYears;
        }

        // calculate approximate value of the phone - method implemented in the derived class
        public abstract decimal CalculateApproximateValue();

        public virtual string Description()
        {
            // retrieve a string to describe the current phone's condition
            string conditionName = Enum.GetName(typeof(Condition), condition);
            // build a string describing the current phone
            string description = string.Format("Operating System: {0}{1}Make: {2}{3}Model: {4}{5}Condition: {6}{7}Colour: {8}{9}Storage: {10}{11}Price: {12:c}",
                operatingSystem, Environment.NewLine,
                make, Environment.NewLine,
                model, Environment.NewLine,
                conditionName, Environment.NewLine,
                colour, Environment.NewLine,
                storage, Environment.NewLine,
                CalculateApproximateValue());
            return description;
        }
    }
}
