using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestRepos
{
    public class PhoneNumber
    {
        // First part of a phone number: (XXX) 000-0000
        public string AreaCode { get; set; }

        // Second part of a phone number: (000) XXX-0000
        public string Exchange { get; set; }

        // Third part of a phone number: (000) 000-XXXX
        public string SubscriberNumber { get; set; }

        // override object.Equals
        //public override bool Equals(object valueV)
        //{
        //    ////valueV = null;
        //    //if (valueV==null)
        //    //{
        //    //    return false;
        //    //}

        //    PhoneNumber number = valueV as PhoneNumber;

        //    //return (number != null) && (AreaCode == number.AreaCode) && (Exchange == number.Exchange) && (SubscriberNumber == number.SubscriberNumber);

        //    return !Object.ReferenceEquals(null, number) && String.Equals(AreaCode, number.AreaCode) && String.Equals(Exchange, number.Exchange) && String.Equals(SubscriberNumber, number.SubscriberNumber);
        //}

        public override bool Equals(object value)
        {
            return Equals(value as PhoneNumber);
        }

        public bool Equals(PhoneNumber number)
        {
            if (Object.ReferenceEquals(null, number)) return false;
            if (Object.ReferenceEquals(this, number)) return true;
            if (number.GetType() != this.GetType())
                return false;
           
            return String.Equals(AreaCode, number.AreaCode)
            && String.Equals(Exchange, number.Exchange)
            && String.Equals(SubscriberNumber, number.SubscriberNumber);

            throw new NotImplementedException();
        }


        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here            
            return base.GetHashCode();
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString()+ this.AreaCode+" "+this.Exchange+" "+ this.SubscriberNumber;
        }

    }
}
