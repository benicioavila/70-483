using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            EstudosReflexion();
        }

        private static void EstudosReflexion()
        {
            var Dog = new Dog { NumberOfLegs = 4 };

            //Em tempo de compilacao
            Type t1 = typeof(Dog);

            //Tempo de execucao
            Type t2 = Dog.GetType();

            //Output: Dog
            Console.WriteLine(t2.Name);
            Console.WriteLine(t2.Assembly);

            //Crianado dinamicamente

            var newDog = (Dog)Activator.CreateInstance(typeof(Dog));
            Dog dogGeneric = Activator.CreateInstance<Dog>();

            var dogConstructor = typeof(Dog).GetConstructors()[0];

            var advacedDog = (Dog)dogConstructor.Invoke(null);
            Console.WriteLine(advacedDog.NumberOfLegs);

            Property();
            Property2();
            Method();
            Method2();
            Console.ReadKey();
        }

        public static void Property()
        {
            var horse = new Animal() { Name = "Ed"};
            var type = horse.GetType();
            var property = type.GetProperty("Name");
            var value = property.GetValue(horse, null);
            Console.WriteLine("Nome do Animal é :{0}", value);

        }

        public static void Method()
        {
            var horse = new Animal();
            var type = horse.GetType();
            var method = type.GetMethod("Speak");
            object[] arguments = new object[1] { "test" };
            var value = (string)method.Invoke(horse, arguments);
            Console.WriteLine("Retorno do método Speak: {0}", value);
        }


        public static void Property2()
        {
            var duck = new Animal() { Name = "Donal" };
            var property = duck.GetType().GetProperty("Name");
            var value = (string)property.GetValue(duck,null);
            Console.WriteLine("Valor property WTIF:" + value);
        }

        public static void Method2()
        {
            //Animal animal = (Animal)Activator.CreateInstance<Animal>();
            var animal = Activator.CreateInstance(typeof(Animal));
            var type = animal.GetType();
            var method = type.GetMethod("Speak");

            object[] parametro = new object[1] { "AnimalDinamico"};
            var valuew = (string)method.Invoke(animal, parametro);
            Console.WriteLine("Chamado de metodo por reflexao do um objeto dinamico:" + valuew);
            
        }
    }
}
