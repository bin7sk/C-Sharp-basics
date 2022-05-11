using System;
namespace OOP 
{ 
    interface game_station
    { 
        void play();

    }

    class computer : game_station
    { 
        public string origin;
        public void play()
        { 
            Console.WriteLine("PC is executing video game");
        }
    }


}