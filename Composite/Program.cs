using Composite.Example1;
using Composite.Example2;



Component component = new Composite.Example1.Composite("Root Item",new Component[]
        {
            new Leaf ("Leaf 1"),
            new Composite.Example1.Composite("Composite1",new Component[]
            {
                new Leaf("Leaf 1-1"),
                new Leaf("Leaf 1-2"),
                new Composite.Example1.Composite("composite 1-2",new Component[]
                {
                    new Leaf ("leaf 1-1-1"),
                    new Composite.Example1.Composite("Empty Composite")
                })
            }),
            new Leaf("Leaf 2"),
            new Leaf("Leaf 3"),
            new Leaf("Leaf 4")
        });
        component.Display(1);
Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine("------------------------------------------------------------------------------");
IComponent HardDisk = new Taki("Hard Disk", 10000);
IComponent Ram = new Taki("Ram", 500);
IComponent cpu = new Taki("Ram", 20000);
IComponent Mouse = new Taki("Mouse", 20);
IComponent Keyboard = new Taki("Keyboard", 50);
IComponent Monitor = new Taki("Monitor", 4000);
Majmoe MotherBoard = new Majmoe("MotherBoard", 100000);
Majmoe Case = new Majmoe("Case", 70);
Majmoe Pheriperals = new Majmoe("Pheriperals", 0);
Majmoe Compiter = new Majmoe("Computer", 0);
MotherBoard.Add(cpu);
MotherBoard.Add(Ram);

Case.Add(MotherBoard);
Case.Add(HardDisk);
Pheriperals.Add(Mouse);
Pheriperals.Add(Keyboard);

Compiter.Add(Monitor);
Compiter.Add(Case);
Compiter.Add(Pheriperals);

Compiter.DisplayPrice();