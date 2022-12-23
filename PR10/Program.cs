using PR10;


Menu menuhka = new Menu();
vhod tst = new vhod();
    
//admin ad = new admin();
bool islistenning = true;

void shov()
{
    Console.WriteLine("  Login: ");
    Console.WriteLine("  Password: ");
    Console.WriteLine("  VHOD");
}




while (islistenning)
{
        
    ConsoleKeyInfo key = Console.ReadKey();
    menuhka.str(key);

    if (key.Key == ConsoleKey.Enter)
    {
        if (tst.wondow == 0)
        {
            tst.show_log(menuhka.position, key);
        }
        else
        {
            tst.open(key);
        }
        //count = 1;
    }
    else if (key.Key == ConsoleKey.R)
    {
        tst.open(key);
    }
    //tst.open(key);
    //Console.SetCursorPosition(7, 4);
    //Console.WriteLine(position);
    Console.SetCursorPosition(0, menuhka.position);
    Console.WriteLine("->");
}
