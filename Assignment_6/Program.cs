namespace Assignment_6
{
    internal class Program
    {
        public struct DeliveryAddress
        {
            public string City;
            public string Street;
            public int BuildingNumber;

            public DeliveryAddress(string city, string street, int buildingNumber)
            {
                City = city;
                Street = street;
                BuildingNumber = buildingNumber;
            }

            public string GetFullAddress()
            {
                return $"{BuildingNumber} {Street}, {City}";
            }
        }

        #region Ceate a Shipment struct Part2
        public struct Shipment
        {
            private string trackingCode;
            private string description;
            private double weight;
            private decimal deliveryFee;

            public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
            {

                this.trackingCode = string.IsNullOrWhiteSpace(trackingCode) ? "UNVALID" : trackingCode;
                this.description = string.IsNullOrWhiteSpace(description) ? "NVALID" : description;
                this.weight = weight > 0 ? weight : 1.0;
                this.deliveryFee = deliveryFee > 0 ? deliveryFee : 10.0m;
                Destination = destination;
            }

            public Shipment(string trackingCode)
            : this(trackingCode, "Unknown", 1.0, 50.0m, new DeliveryAddress("Default City", "Default St", 1))
            {
            }

            public string TrackingCode
            {
                get { return trackingCode; }
                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        trackingCode = value;
                    }
                }
            }

            public string Description
            {
                get { return description; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        description = value;
                    }
                }
            }

            public double Weight
            {
                get { return weight; }
                set
                {
                    if (value > 0)
                    {
                        weight = value;
                    }
                }
            }

            public decimal DeliveryFee
            {
                get { return deliveryFee; }
                private set
                {
                    if (value > 0)
                    {
                        deliveryFee = value;
                    }
                }
            }

            public DeliveryAddress Destination { get; set; }
            public decimal EstimatedCost
            {
                get
                {
                    return deliveryFee + ((decimal)weight * 5m);
                }
            }

            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                {
                    deliveryFee = newFee;
                }
            }
            public void PrintShipment()
            {
                Console.WriteLine($"Tracking Code: {TrackingCode}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Weight: {Weight}");
                Console.WriteLine($"Delivery Fee: {DeliveryFee}");
                Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
                Console.WriteLine($"Estimated Cost: {EstimatedCost}");
                Console.WriteLine(new string('-', 30));
            }
        }
        #endregion

        #region DeliveryCenter struct
        public struct DeliveryCenter
        {
            private Shipment[] shipments;
            private int count;
            public DeliveryCenter()
            {
                shipments = new Shipment[10];
                count = 0;
            }

 public Shipment this[int index]
        {
            get
            {
                if (shipments == null || index < 0 || index >= count)
                {
                    return default;
                }
                return shipments[index];
            }
                set
                {
                    if (shipments != null && index >= 0 && index < count)
                    {
                        shipments[index] = value;
                    }
                }
            }


            public Shipment this[string trackingCode]
            {
                get
                {
                    if (shipments == null || string.IsNullOrWhiteSpace(trackingCode))
                    {
                        return default;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        if (shipments[i].TrackingCode != null &&
                            shipments[i].TrackingCode.Equals(trackingCode, StringComparison.OrdinalIgnoreCase))
                        {
                            return shipments[i];
                        }
                    }

                    return default;
                }
            }

            public bool AddShipment(Shipment shipment)
            {
                if (shipments == null)
                {
                    shipments = new Shipment[10];
                }

                if (count >= 10)
                {
                    return false;
                }

                shipments[count] = shipment;
                count++;
                return true;
            }
        }
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
