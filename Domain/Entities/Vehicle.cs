namespace OS.WpfDevExpress.Domain.Entities
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public AutomobileType Type { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public AutomobileComment Comment { get; set; }
    }

    public class AutomobileComment
    {
        public string Comment { get; set; }
    }

    public enum AutomobileType
    {
        None,
        Car,
        Truck,
        Motorbike
    }
}
