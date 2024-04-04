using ABSTRACT.UNI.Models;

namespace ABSTRACT.UNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShepherdDog alabai = new ShepherdDog();
            
            wildDog wildDog = new wildDog();

            wildCats wildCats = new ();
            domesticCats garfild = new domesticCats ();// burda 2 dene yazi cixir base ve biz yazan 
            smallFish nemo  = new smallFish ();
            BalinaFish balina = new BalinaFish ();

            //Animal[] animals = {alabai, wildDog,wildCats , garfild, nemo, balina}; 
            //foreach (Animal animal in animals) 
            //{
            //    animal.eat();
            //}

            Dogs[] dogs = { alabai, wildDog ,new onlyDog()};
            foreach (var dog in dogs)
            {
                dog.dostlari();
            }


        }
    }
}
