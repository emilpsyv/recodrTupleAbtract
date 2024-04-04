using System.Threading.Channels;

namespace ABSTRACT.UNI.Models
{
    internal abstract class Animal
    {
        public abstract void eat();
    }

    #region abstract class
    abstract class Dogs : Animal
    {
        public override void eat()
        {
            Console.WriteLine( "aet meet and bread ");
        }

        public virtual void dostlari()
        { Console.WriteLine("dog and dog"); }
        
    }

    abstract class Cats : Animal
    {
        public override void eat()
        { Console.WriteLine("eat mouse"); }
    }


    abstract class Fish : Animal 
    {
        public override void eat()
        {
            Console.WriteLine("eat sea food");
        }
        
        
    }
    #endregion



    class onlyDog : Dogs
    {

    }

    class ShepherdDog : Dogs
    {
        public override void eat()
        {

            base.eat();
        }
        public override void dostlari()
        {
            Console.WriteLine( "dogs and other animals");
        }
    }


    class wildDog : Dogs 
    {
        public override void eat()
        {
            Console.WriteLine( "eat what it found");
        }
    }


    class smallFish : Fish
    {

      

    }
    class BalinaFish : Fish 
    {
        public override void eat()
        {
            Console.WriteLine("eat planctons");
            
        }
    }


    class domesticCats : Cats
    {
        public override void eat()
        {
            Console.WriteLine("sahibi vereni yeyer");
            base.eat();
        }
    }


    class wildCats : Cats
    {
        public override void eat()
        {
            Console.WriteLine("hunt and eat");
        }
    }





}
