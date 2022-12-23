using System.Collections.Specialized;

namespace PR10;

public class Menu
{

    public int position = 0;
    

    public void str(ConsoleKeyInfo key)
    {
        //start st = new start();
        if (key.Key == ConsoleKey.UpArrow)
        {
            position--;
            Console.SetCursorPosition(0, (position + 1));
            Console.WriteLine("  ");
        }
        else if (key.Key == ConsoleKey.DownArrow)
        {
            position++;
            Console.SetCursorPosition(0, (position - 1));
            Console.WriteLine("  ");
        }
        
    }

}