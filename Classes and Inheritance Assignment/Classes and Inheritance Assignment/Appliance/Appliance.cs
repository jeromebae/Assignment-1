
namespace Assignment1
{
    class Appliance
    {
        public string ItemNumber { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Wattage { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }

        public Appliance(string itemNum, string brand, int quantity, int wattage, string color, int price)
        {
            ItemNumber = itemNum;
            Brand = brand;
            Quantity = quantity;
            Wattage = wattage;
            Color = color;
            Price = price;
        }

        public virtual string Format()
        {
            return $"Item Number: {ItemNumber}\n" +
                $"Brand: {Brand}\n" +
                $"Quantity: {Quantity}\n" +
                $"Wattage: {Wattage}\n" +
                $"Color: {Color}\n" +
                $"Price: {Price}";
        }
    }

    class Refrigerator : Appliance
    {
        public int Doors { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Refrigerator(string itemNum, string brand, int quantity, int wattage, string color, int price, int doors, int height, int width) : base(itemNum, brand, quantity, wattage, color, price)
        {
            Doors = doors;
            Height = height;
            Width = width;
        }

        public override string Format()
        {
            return base.Format() +
                $"Number of Doors: {Doors}\n" +
                $"Height: {Height}\n" +
                $"Width: {Width}";
        }
    }

    class Vacuum : Appliance
    {
        public string Grade { get; set; }
        public int Voltage { get; set; }
        public Vacuum(string itemNum, string brand, int quantity, int wattage, string color, int price, string grade, int voltage) : base(itemNum, brand, quantity, wattage, color, price)
        {
            Grade = grade;
            Voltage = voltage;
        }

        public override string Format()
        {
            return base.Format() +
                $"Grade: {Grade}\n" +
                $"Battery voltage: {Voltage}";
        }
    }

    class Microwave : Appliance
    {
        public int Capacity { get; set; }
        public string RoomType { get; set; }
        public Microwave(string itemNum, string brand, int quantity, int wattage, string color, int price, int capacity, string roomType) : base(itemNum, brand, quantity, wattage, color, price)
        {
            Capacity = capacity;
            RoomType = roomType;
        }

        public override string Format()
        {
            return base.Format() +
                $"Capacity: {Capacity}\n" +
                $"Room Type: {RoomType}";
        }
    }

    class Dishwashers : Appliance
    {
        public string Feature { get; set; }
        public string SoundRating { get; set; }
        public Dishwashers(string itemNum, string brand, int quantity, int wattage, string color, int price, string feature, string soundRating) : base(itemNum, brand, quantity, wattage, color, price)
        {
            Feature = feature;
            SoundRating = soundRating;
        }

        public override string Format()
        {
            return base.Format() +
                $"Feature; {Feature}\n" +
                $"SoundRating: {SoundRating}";
        }
    }
}