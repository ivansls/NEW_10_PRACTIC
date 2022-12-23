namespace PR10;

public class vhod
{
    
    //Menu men = new Menu();
    
    string login;
    string password;
    int count = 0;
    List<string> elem = new List<string>() { };
    Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
    public List<MyType> type = Des_or_Ser.MyDesirialize<List<MyType>>();
    int window_value = 0;
    string a = "";
    string b = "";
    public int wondow = 0;
    //private start st = new start();
    
    internal enum MyEnum
    {
         admin = 0, 
            kass = 1,
    }

    public void show_log(int posicion, ConsoleKeyInfo key)
    {

        if (posicion == 1)
        {
            Console.SetCursorPosition(9, 1);
            login = Console.ReadLine();
        }
        else if (posicion == 2)
        {
            Pass();
        }
        else if (posicion == 3)
        {
            wondow = 1;
            open(key);
            
        }
        
        /*
        foreach (KeyValuePair<string, List<string>> s in dict)
        {

            if (s.Value[0] == login & s.Value[1] == password)
            {
                window_value = Convert.ToInt32(s.Key);

            }
        }

        Perehod();
        */
    }


    public void open(ConsoleKeyInfo key)
    {
        Console.Clear();
        type = Des_or_Ser.MyDesirialize<List<MyType>>();
        foreach (var i in type)
        {
            if (login == i.Login & password == i.Password)
            {
                string rolee = i.RoleID;
                Perehod(rolee, type, key);
            }
            
        }

    }
    public void Perehod(string rolee, List<MyType> type, ConsoleKeyInfo key)
    {
        admin ad = new admin();
        if (Convert.ToInt32(rolee) == (int)MyEnum.admin)
        {
            ad.Admin(type);
        }
    }

    void Pass()
    {
        Console.SetCursorPosition(12, 2);
        while (true)
        {
            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                break;
            }

            Console.Write("*");
            password += key.KeyChar;

        }


        Console.ReadKey();

    }
}


/*
    void menu()
    {
        if (position == 0)
        {
            Console.SetCursorPosition(8, 0);
            login = Console.ReadLine();
            Console.SetCursorPosition(8, 0);
            Console.WriteLine(login);

        }
        else if (position == 1)
        {
            Main();
        }
        else if (position == 2)
        {
            Console.Clear();
            List<string> dop_dly_dict = new List<string>();
            List<MyType> type1 = Des_or_Ser.MyDesirialize<List<MyType>>();
            foreach (var i in type1)
            {
                //d_ID = i.ID;
                //d_Login = i.Login;
                //d_Password = i.Password;
                //d_Role = i.Role;
                //dop_dly_dict.Add(i.Login);
                //dop_dly_dict.Add(i.Password);
                //dop_dly_dict.Add(i.Role);
                //dict.Add(i.ID, dop_dly_dict) ;
                //elem.Add(i.Login);
                //elem.Add(i.Password);
                //elem.Add(i.Role);
                //elem2.Add(elem);
            }



            count = 1;
            //Console.WriteLine(d_ID + "\n" + d_Login + "\n" + d_Password + "\n" + d_Role);
        }
    }
   */
 