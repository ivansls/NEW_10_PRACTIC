using System.Reflection.Metadata;

namespace PR10;

public class admin
{
    //Dictionary<string, List<string>> dict;

    /*public admin(Dictionary<string, List<string>> dictionary)
    {
        dict = dictionary;

    }*/
    vhod tst = new vhod();
    private start st = new start();
    int pos = 1;

    public void Admin(List<MyType> type)
    {
        Console.Clear();
        foreach (var i in type)
        {
            Console.SetCursorPosition(2, 0);
            Console.WriteLine("ID");
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("Роль");
            Console.SetCursorPosition(40, 0);
            Console.WriteLine("Логин");
            Console.SetCursorPosition(70, 0);
            Console.WriteLine("Пароль");

            Console.SetCursorPosition(2, pos);
            Console.Write(i.ID);
            Console.SetCursorPosition(5, pos);
            Console.Write(i.Role);
            Console.SetCursorPosition(40, pos);
            Console.Write(i.Login);
            Console.SetCursorPosition(70, pos);
            Console.Write(i.Password);
            pos++;
        }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.R)
            {
                Write(tst, key);
            }
    }



public void Write(vhod tst, ConsoleKeyInfo key)
    {
        Console.Clear();
        
        MyType pers = new MyType();
        Console.WriteLine("ID: ");
        pers.ID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Log: ");
        pers.Login = Console.ReadLine();
        Console.WriteLine("Pass: ");
        pers.Password = Console.ReadLine();
        Console.WriteLine("Rol: ");
        pers.Role = Console.ReadLine();
        Console.WriteLine("RollID");
        pers.RoleID = Console.ReadLine();
        tst.type.Add(pers);
        Des_or_Ser.MySerialeze(tst.type);
        Admin(tst.type);
        //string Login = Console.ReadLine();
        //tst.open(key);
        
    }
}