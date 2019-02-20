using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneApplication
{
    public class Shop
    {
        // this class contains a list of mobile phones
        private List<MobilePhone> phonesForSale;
        private int currentlyViewedPhone = 0;

        public Shop()
        {
            phonesForSale = new List<MobilePhone>();
        }

        // currently viewed phone on the form
        public int CurrentlyViewedPhone
        {
            get { return currentlyViewedPhone; }
        }

        // count of phones
        public int NumberofPhones
        {
            get { return phonesForSale.Count; }
        }

        // display a description of the current phone
        public string DescribeCurrentPhone()
        {
            string description;
            // Display description of the currently viewed phone
            if (phonesForSale.Count > 0)
            {
                description = phonesForSale[currentlyViewedPhone].Description();
            }
            else
            {
                description = "No mobile phones in stock, we apologise for the inconvinience";
            }
            return description;
        }

        // Add phone to the list
        public void AddPhone(MobilePhone Phone)
        {
            phonesForSale.Add(Phone);
        }

        // remove phone from index point
        public void RemovePhoneAt(int index)
        {
            if (index < phonesForSale.Count)
            {
                phonesForSale.RemoveAt(index);
                // zero or currently selected phone
                LegaliseCurrrentPhoneDisplayed();
            }
        }

        // check that phone is being indexed
        private void LegaliseCurrrentPhoneDisplayed()
        {
            if (currentlyViewedPhone > (phonesForSale.Count - 1))
            {
                currentlyViewedPhone = phonesForSale.Count - 1;     

                if (currentlyViewedPhone < 0)
                {
                    currentlyViewedPhone = 0;  
                }
            }
        }
        
        // previous phone
        public bool IsPreviousPhone()
        {
            if (currentlyViewedPhone > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // next phone
        public bool IsNextPhone()
        {
            if (currentlyViewedPhone < phonesForSale.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // step to the previous phone
        public void StepToPreviousPhone()
        {
            if (IsPreviousPhone())
            {
                currentlyViewedPhone--;
            }
        }

        // step tho the next phone
        public void StepToNextPhone()
        {
            if (IsNextPhone())
            {
                currentlyViewedPhone++;
            }
        }
    }
}