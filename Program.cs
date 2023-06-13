namespace LearnInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Create Instance */
            Dog dog = new Dog("Blecky");
            dog.Bark();

            /* Calls SuperClass Method - Since Eat() & Sleep() Method is static */
            /* then calls from the Object Instead/Not Calls from the Instance   */
            Dog.Eat();
            Dog.Sleep();

            /* Create Instance */
            Cat cat = new Cat("Miko");
            cat.Meow();

            /* Calls SuperClass Method - Since Eat() & Sleep() Method is static */
            /* then calls from the Object Instead/Not Calls from the Instance   */
            Cat.Eat();
            Cat.Sleep();
        }
    }
}