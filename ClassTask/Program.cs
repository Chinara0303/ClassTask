using ClassTask.Models;

//upcasting
//Salmon salmon = new Salmon();
//Animal animal = salmon;
//Bird bird = new Bird();
//Animal animal1 = new Salmon();

//Animal animal = new Animal();
//Console.WriteLine(animal.Speed);

//Eagle eagle = new Eagle();

//Animal animal1 = eagle;

//animal1.Test();
//eagle.Test();
//animal1.Sound();
//animal1.Name = "Bee";
//Console.WriteLine(animal1.Name);
//salmon.Sound();
//eagle.Sound();

//Animal animal =new Animal();
//animal.Sound();
//Bird bird= new Bird();
//Fish fish= new Fish();
//Bird bird1 = fish;


//Eagle eagle = new Eagle();
//Animal animal = new Eagle();
//Fish fish = new Fish();
//Animal animal1 = fish;
//Bird bird = new Bird();
//Eagle eagle1 = (Eagle)animal1;

//Animal[] animals = {animal, eagle, fish, animal1, bird, eagle1 };
//foreach (var item in animals)
//{
//    item.Name = "xxx";
//    Console.WriteLine(item.Name);
//}

//downcasting 
//Eagle eagle= new Eagle();
//Animal animal= new Animal();
//Eagle eagle1 = (Eagle)animal;
//Console.WriteLine(eagle1.Speed);

//boxing - valuenu objecte cevirmek ve ya eksine - unboxing

//int num1 = 10;
//object obj1 = num1;
//string name = (string)obj1;

//string str = "10";
////int num1 = 55;
//object obj1 = str;

////int num2 = (int)obj1;

//var res = int.Parse(str);

//bool isMarried = false;
//object obj1 = isMarried;
//bool res = (bool)obj1;
//Console.WriteLine(res);

//implicit explicit bir biriyle elaqesi olmayan tiplerin bir birine cevrilmesi

//int num = 200;
//byte num1 = (byte)num;
//Console.WriteLine(num1);
//byte num2 = 55;
//int num3 = num2;
//Console.WriteLine(num3);

Bird bird =  new Bird();
Animal animal = new Bird();
Fish fish= new Fish();
Animal animal1 = new Fish();

Object[] objects = {false, bird, animal, fish , animal1, 1, "Salam", true };
foreach (var item in objects)
{
    //if (item is Animal)
    //{
    //    ((Animal)item).Name = "XXX";
    //    Console.WriteLine(((Animal)item).Name);
    //}
    //else
    //{
    //    Console.WriteLine(item);
    //}
    //if (item is Animal a)
    //{
    //    a.Name = "XXX";
    //    Console.WriteLine(a.Name);
    //}
    //else
    //{
    //    Console.WriteLine(item);
    //}

    Animal animal2 = item as Animal;
    if (animal2 != null)
    {
        animal2.Name = "xxx";
        Console.WriteLine(animal2.Name);
    }
    else
    {
        Console.WriteLine(item);
    }
}