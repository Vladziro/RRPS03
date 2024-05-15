namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;

            while (exit)
            {
                Menu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SingletonPatern();
                        break;
                    case "2":
                        FactoryPatern();
                        break;
                    case "3":
                        AdapterPatern();
                        break;
                    case "4":
                        BridgePatern();
                        break;
                    case "5":
                        MediatorPatern();
                        break;
                    case "0":
                        exit = false;
                        Console.WriteLine("Вихiд з програми...");
                        break;
                    default:
                        Console.WriteLine("Невiрний вибiр. Спробуйте ще раз.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void Menu()
        {
            Console.WriteLine("=== Головне меню ===");
            Console.WriteLine("1. Патерн 'Одинак'");
            Console.WriteLine("2. Патерн 'Фабрика'");
            Console.WriteLine("3. Патерн 'Адаптер'");
            Console.WriteLine("4. Патерн 'Мiст'");
            Console.WriteLine("5. Патерн 'Посередник'");
            Console.WriteLine("0. Вихiд");
            Console.Write("Введiть свiй вибiр: ");
        }

        static void SingletonPatern()
        {
            Singleton singleton1 = Singleton.GetInstance;
            Singleton singleton2 = Singleton.GetInstance;

            if (singleton1.Equals(singleton2))
                Console.WriteLine("Singleton works");
            else
                Console.WriteLine("Singleton is not working");
        }

        static void FactoryPatern()
        {
            new FactoryClient().Main();
        }

        static void AdapterPatern()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine(target.GetRequest());
        }

        static void BridgePatern()
        {
            BridgeClient bridgeclient = new BridgeClient();

            Abstraction abstraction;

            abstraction = new Abstraction(new ConcreteImplementationA());
            bridgeclient.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            bridgeclient.ClientCode(abstraction);
        }

        static void MediatorPatern()
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();
        }
    }
}
