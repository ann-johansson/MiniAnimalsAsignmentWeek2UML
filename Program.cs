namespace AsignmentWeek2UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat Cat1 = new Cat(); // Create a Cat object

            // Setting attributes for Cat1
            Cat1.name = "Nyan";
            Cat1.type = "cat";
            Cat1.age = 3;
            Cat1.furPattern = "tabby";
            // Calling methods for Cat1
            Cat1.WriteOutInfo();
            Cat1.Eat();
            Cat1.Sleep();
            Cat1.MakeSound();
            Cat1.Purr();

            Console.WriteLine(); // Adds space between Cat and Dog output

            Dog Dog1 = new Dog(); // Create a Dog object

            // Setting attributes for Dog1
            Dog1.name = "Everest";
            Dog1.type = "dog";
            Dog1.age = 5;
            Dog1.breed = "Golden Retriever";
            Dog1.owner = "Ryan";
            // Calling methods for Dog1
            Dog1.WriteOutInfo();
            Dog1.Eat();
            Dog1.Sleep();
            Dog1.MakeSound();
            Dog1.Bark();

        }
    }
}
