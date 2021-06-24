// Written By: Aliabbas Syed

using System;

namespace CSharpAbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cannot create Abstract Class Object as in:
            // var phone = new SmartPhone();


            var android = new Android();
            android.SetPrice(1000);
            Console.WriteLine($"Android Phone costs: {android.GetPrice()}");
            Console.WriteLine($"{android.smartPhonesOS()}");
            Console.WriteLine($"{android.smartPhonesOSVersion()}");
            Console.WriteLine("=================================");
            var iphone = new Apple();
            iphone.SetPrice(1500);
            Console.WriteLine($"Android Phone costs: {iphone.GetPrice()}");
            Console.WriteLine($"{iphone.smartPhonesOS()}");
            Console.WriteLine($"{iphone.smartPhonesOSVersion()}");
            Console.ReadLine();
        }
    }

    // Abstract class (SmartPhone) is a restricted class that cannot be used to create
    // objects(to access it, it must be inherited from another class).

    // Abstract methods (smartPhonesOS and smartPhonesOSVersions) can only be used in
    // an abstract class, and it does not have a body.The body is provided by the derived
    // class (inherited from).

    abstract class SmartPhone
    {
        abstract public string smartPhonesOS();
        abstract public string smartPhonesOSVersion();

        // Abstract class can have both abstract (above) and
        // regular methods GetPrice() and SetPrice()

        private int price;

        public int GetPrice()
        {
            return price;
        }

        public void SetPrice(int value)
        {
            this.price = value;
        }
    }

    class Android : SmartPhone
    {
        public override string smartPhonesOS()
        {
            return "Android Phone OS";
        }

        public override string smartPhonesOSVersion()
        {
            return "Android Phone Version";
        }
    }

    class Apple : SmartPhone
    {
        public override string smartPhonesOS()
        {
            return "Apple Phone OS";
        }

        public override string smartPhonesOSVersion()
        {
            return "Apple Phone Version";
        }
    }
}
