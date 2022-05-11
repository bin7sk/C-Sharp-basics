namespace Library
{
    public class Player
    {
        string name;
        int id;

        public Player(string _name, int _id) 
        {
            name = _name;
            id = _id;
        }
        public void info()
        { 
            Console.WriteLine(name);
            Console.WriteLine(id);
        }

    }
}