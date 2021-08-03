using System;

namespace Lab4_2_ObjectPractice
{
    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;
        public void SetName(string _Name)
        {
            if (_Name == "") _Name = "EMPTY";
            Name = _Name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetDescription(string _Description)
        {
            if (_Description == "") _Description = "EMPTY";
            Description = _Description;
        }
        public string GetDescription()
        {
            return Description;
        }
        public void SetPrice(decimal _Price)
        {
            if (_Price < 0.50m) _Price = 0.50m;
            if (_Price > 10.00m) _Price = 10.00m;
            Price = _Price;
        }
        public decimal GetPrice()
        {
            return Price;
        }
        public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = _Description;
            Price = _Price;
        }
        public MenuItem(int _ID, string _Name, decimal _Price)
        {
            ID = _ID;
            Name = _Name;
            Description = "EMPTY";
            Price = _Price;
        }
        public override string ToString()
        {
            return $"===MENU ITEM===\nID: {ID}\nName: {Name}\nDescription: {Description}\nPrice: ${Price}\n";
        }
    }
    class Rectangle
    {
        public int Length;
        public int Width;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem item1 = new MenuItem(11, "CLUB SANDIWCH", "Turkey, ham, bacon, lettuce, tomato, mayo", 9.99m);
            MenuItem item2 = new MenuItem(12, "FRENCH DIP", 11.99m);
            MenuItem item3 = new MenuItem(21, "HOUSE SALAD", "with HOUSE DRESSING", 7.99m);
            MenuItem item4 = new MenuItem(22, "SOUP OF THE DAY", "Changes daily", 3.99m);
            MenuItem item5 = new MenuItem(31, "HOUSE CHIPS", 2.99m);
            MenuItem item6 = new MenuItem(32, "HOUSE FRIES", 2.99m);

            Console.WriteLine(item1);
            Console.WriteLine(item2);
            Console.WriteLine(item3);
            Console.WriteLine(item4);
            Console.WriteLine(item5);
            Console.WriteLine(item6);


            //=============== CONCLUSIONS FROM TESTS MADE WITH CODE BELOW ===============
            //
            //  From these tests, I can conclude that objects are not considered equal
            //  when their parameters are equal. Instead, this is more like congruency.
            //  That is, while two rectangles have equal dimensions, they are considered
            //  congruent but they are still two separate, unequal rectangles.Therefore,
            //  when I declared r2 = r1, the compiler recognizes the objects equal.
            //  Furthermore, the compiler does not recognize them as equal when only
            //  their parameters are congruent.

            Rectangle r1 = new Rectangle { Length = 2, Width = 3 };
            //Rectangle r2 = new Rectangle { Length = 2, Width = 3 };
            Rectangle r2 = r1;

            if (r1 == r2) Console.WriteLine("Same");
            else Console.WriteLine("Different");
        }
    }
}
