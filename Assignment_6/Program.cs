namespace Assignment_6
{
    internal class Program
    {
        //public struct DeliveryAddress
        //{
        //    public string City;
        //    public string Street;
        //    public int BuildingNumber;

        //    public DeliveryAddress(string city, string street, int buildingNumber)
        //    {
        //        City = city;
        //        Street = street;
        //        BuildingNumber = buildingNumber;
        //    }

        //    public string GetFullAddress()
        //    {
        //        return $"{BuildingNumber} {Street}, {City}";
        //    }
        //}

        #region Ceate a Shipment struct
        //public struct Shipment
        //{
        //    private string trackingCode;
        //    private string description;
        //    private double weight;
        //    private decimal deliveryFee;

        //    public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        //    {

        //        this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNVALID" : trackingCode;
        //        this.description = string.IsNullOrWhiteSpace(description) ? "NVALID" : description;
        //        this.weight = weight > 0 ? weight : 1.0;
        //        this.deliveryFee = deliveryFee > 0 ? deliveryFee : 10.0m;
        //        Destination = destination;
        //    }

        //    public string TrackingCode
        //    {
        //        get { return trackingCode; }
        //        private set
        //        {
        //            if (!string.IsNullOrWhiteSpace(value))
        //            {
        //                trackingCode = value;
        //            }
        //        }
        //    }

        //    public string Description
        //    {
        //        get { return description; }
        //        set
        //        {
        //            if (!string.IsNullOrWhiteSpace(value))
        //            {
        //                description = value;
        //            }
        //        }
        //    }

        //    public double Weight
        //    {
        //        get { return weight; }
        //        set
        //        {
        //            if (value > 0)
        //            {
        //                weight = value;
        //            }
        //        }
        //    }

        //    public decimal DeliveryFee
        //    {
        //        get { return deliveryFee; }
        //        private set
        //        {
        //            if (value > 0)
        //            {
        //                deliveryFee = value;
        //            }
        //        }
        //    }

        //    public DeliveryAddress Destination { get; set; }
        //    public decimal EstimatedCost
        //    {
        //        get
        //        {
        //            return deliveryFee + ((decimal)weight * 5m);
        //        }
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Question 1
            // a) 
            //Modifying the copy affects only the copy and leaves the original unchanged.

            // b)
            //Modifying the object through either them affects both the original and the copy.
            #endregion


            #region Question 2
            // a)
            // The 3 fields are public, breaking data hiding by allowing external code to modify them directly.
            // No validation or constraints can be enforced on the values assigned to these fields.
            // Internal values cannot be protected as read-only or computed properties so its better to use calss instead of struct for data hiding and encapsulation.

            //b)
            // Data hiding, protection & encapsulation are important
            // input validation through properties like set & get methods
            // fliexibility and read only properties for internal values
            #endregion


            #region Part 2 Question 1
            //DeliveryAddress originalAddress = new DeliveryAddress("Cairo", "El-Tahrir St", 6);
            //DeliveryAddress copiedAddress = originalAddress;

            //copiedAddress.City = "El-Fayoum";
            //copiedAddress.BuildingNumber = 18;

            //Console.WriteLine($"Original Address: {originalAddress.GetFullAddress()}");
            //Console.WriteLine($"Copied Address: {copiedAddress.GetFullAddress()}");
            #endregion


   
            
         
        }
    }
}
