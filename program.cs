using System;

namespace Armstrong
{
    class Program
    {
        static bool Armstrong(int nb){
            int centaine,dizaine, unite, reste;
            centaine = nb/100;
            reste = nombre % 100;
            dizaine = reste/10;
            reste = nombre % 10;

            if(centaine * centaine * centaine + dizaine * dizaine * dizaine + unite * unite * unite == nombre){
                return true;
            }else{
                return false;}

        }

        static void Main(string[] args)
        {
            int nombre;
            Console.WriteLine("Saisire nb");
            try{
            nombre = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("pas bon");
                return 0;
            }
            Armstrong(nombre);
        }
    }
}
