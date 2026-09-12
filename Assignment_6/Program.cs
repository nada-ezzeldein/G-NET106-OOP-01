namespace Assignment_6
{
    internal class Program
    {
       // public struct DeliveryAddress
        // {
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
