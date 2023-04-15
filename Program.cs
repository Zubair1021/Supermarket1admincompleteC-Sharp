using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace supermarketsystem_c_sharp_
{
class items
    {
        public string itemname;
        public int itemprice;
        public string itemrack;

    }
    class employee
    {
        public string employeename;
        public int employeesalary;
        public string employeeshift;
        public int employeephone; 
    }
    class userCr
    {
        public string username;
        public string password;
    }
    class employeeCr
    {
        public string Eusername;
        public string Epassword;
    }

    class Program
    {
        static string discday = "sunday";
        static int discrate = 10;
        static List<items> data = new List<items>();
        static List<employee> record = new List<employee>();
        static List<userCr> identity = new List<userCr>();
        static List<employeeCr> identityE = new List<employeeCr>();

        static void Main(string[] args)
        {
            /*Stock Dummy data (Hard Code)*/
            items it = new items();
            items it1 = new items();
            it.itemname = "cake";
            it.itemprice = 100;
            it.itemrack = "C3";
            data.Add(it);
            it1.itemname = "Lays";
            it1.itemprice = 60;
            it1.itemrack = "l2";
            data.Add(it1);
            /*Employee Dummy data (Hard Code)*/
            employee em = new employee();
            employee em1 = new employee();
            em.employeename = "Hamza";
            em.employeesalary = 10000;
            em.employeeshift = "Night";
            em.employeephone = 1123467;
            record.Add(em);
            em1.employeename = "Ali";
            em1.employeesalary = 3000;
            em1.employeeshift = "Night";
            em1.employeephone = 167567;
            record.Add(em1);
            /* User Credentials (Hard Code)*/
            userCr cr = new userCr();
            cr.username = "zubair";
            cr.password = "1234";
            identity.Add(cr);
            /* employee Credentials (Hard Code)*/
            employeeCr emCr1 = new employeeCr();
            employeeCr emCr2 = new employeeCr();
            emCr1.Eusername = "hamza";
            emCr1.Epassword = "1122";
            identityE.Add(emCr1);
            emCr2.Eusername = "Ali";
            emCr2.Epassword = "0099";
            identityE.Add(emCr2);

            mainmenu();
            Console.ReadKey();
        }

        public static void mainmenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            
            string choice;

            Console.WriteLine("\t\t\t\t\t**********************************************************************************");
            Console.WriteLine("\t\t\t\t\t*                           SUPER MARKET SYSTEM                                  *");
            Console.WriteLine("\t\t\t\t\t**********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" (a) -----------------ADMINISTRATOR---------------------");
            Console.WriteLine("");
            Console.WriteLine(" (b) -----------------BUYER------------------------------");
            Console.WriteLine("");
            Console.WriteLine(" (c) -----------------EMPLOYEE---------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("ENTER YOUR LOGIN STATUS");
            Console.WriteLine("Press 'a' , 'b' & 'c'");
        a:
            Console.Write("YOUR CHOICE : ");
            choice = Console.ReadLine();
            if (choice == "a")
            {

                adminmenu();
            }
            if (choice == "b")
            {
                Console.WriteLine("WELCOME AS A BUYER! FUNCTION SOON ADDED");
            }
            if (choice == "c")
            {
                Console.WriteLine("WELCOME AS A EMPLOYEE! FUNCTION SOON ADDED");
            }
            if (choice != "a" && choice != "b" && choice != "c")
            {
                Console.WriteLine("__________________________________YOUR CHOICE IS NOT CORRECT______________________________ ");
                goto a;
            }

        }
        public static void adminmenu()
        {

           
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            adminlogo();
            userCr info = new userCr();
            int flag = 0;
            string key;
            string pass;
            string name;
           
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>Login menue");
            Console.WriteLine("");
            Console.WriteLine("HINT: USERNAME IS IN ALPHABAT & PASSWAORD IS NUMBERS");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("\t\t\t\t\t---------------USERNAME:    ");
            name = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("\t\t\t\t\t---------------PASSWORD:    ");
            pass = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

            if (name == identity[0].username && pass == identity[0].password)
            {
                flag++;
            }

            if (flag == 1)
                adminfunction();

            else
            {
                Console.WriteLine("YOUR PASSWORD & USERNAME IS INCORRECT");
                Console.WriteLine("Press any Key : ");
                key = Console.ReadLine();
                mainmenu();
            }

        }


        public static void adminlogo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t***********************************************************************************");
            Console.WriteLine("\t\t\t\t\t*                           ADMINISTRATOR MENUE                                   *");
            Console.WriteLine("\t\t\t\t\t***********************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
            
        }
        public static void adminfunction()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            adminlogo();
            string choice;
            char choice1;
            Console.ForegroundColor=ConsoleColor.Green; Console.WriteLine("\t\t\t\t\t<<<<<<<<<<<<<........USER AND STOCK REALTED WORKS ........>>>>>>>>>>>>>>"); Console.WriteLine("");

            Console.WriteLine("1--------------change login setting (change password & name)"); Console.WriteLine("");
            Console.WriteLine("2--------------Add new items"); Console.WriteLine("");
            Console.WriteLine("3--------------change product price"); Console.WriteLine("");
            Console.WriteLine("4--------------View their login password and username"); Console.WriteLine("");
            Console.WriteLine("5--------------Add discount"); Console.WriteLine("");
            Console.WriteLine("6--------------Assign a racks (Position) of differnt items"); Console.WriteLine("");
            Console.WriteLine("7--------------View total products (stocks)"); Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;  Console.WriteLine("\t\t\t\t\t<<<<<<<<<<<<<........EMPLOYEE REALTED WORKS ........>>>>>>>>>>>>>>"); Console.WriteLine("");

            Console.WriteLine("8--------------Change employee details"); Console.WriteLine("");
            Console.WriteLine("9--------------see total employee"); Console.WriteLine("");
            Console.WriteLine("10-------------Add Employee"); Console.WriteLine("");
            Console.WriteLine("11-------------See employee login password and username"); Console.WriteLine("");
            Console.WriteLine("12-------------Add employee login password and username"); Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkMagenta; 
            Console.WriteLine("13-------------Exit");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("___________________________ACCORDING TO YOUR WORKS PLEASE SELECT_______________________________");
            Console.WriteLine("");
            Console.Write("ENTER YOUR CHOICE: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                changeuser();
            }
            else if (choice == "2")
            {
                newitems();
            }
            else if (choice == "3")
            {
                changeprice();
            }
            else if (choice == "6")
            {
                assignrack();
            }
            else if (choice == "10")
            {
                addemployee();
            }
            else if (choice == "8")
            {
                changeemployee();
            }
            else if (choice == "5")
            {
                adddiscount();
            }
            else if (choice == "7")
            {

                viewstock();
            }
            else if (choice == "9")
            {
                viewemployee();
            }
            else if (choice == "4")
            {
                viewpassword();
            }
            else if (choice == "11")
            {
                viewemplPL();
            }
            else if (choice == "12")
            {
                newemployeePL();
            }
            else if (choice == "13")
            {
                mainmenu();
            }

            else
            {
                Console.WriteLine("your choice is incorrect ");
                Console.WriteLine("");
                Console.WriteLine("-------------Press any key  to go to main menu: ");
                Console.WriteLine("");
                choice1 = char.Parse(Console.ReadLine());
                mainmenu();
            }
        }
        public static void changeemployee()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            employee em = new employee();
            string name;


            char key;
            int flag = 0;
            int newsalary;
            string newshift;
            int newphone;

            Console.Clear();
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<CHANGE EMPLOYEE DETAIL ");
            Console.WriteLine("");
            Console.Write("Enter the product name of emplyee whose information you want to change:  ");
            name = Console.ReadLine();

            for (int x = 0; x < record.Count; x++)
            {
                if (name == record[x].employeename)
                {
                    Console.WriteLine("Employee Name: " + name);
                    Console.WriteLine("Salary : " + record[x].employeesalary);
                    Console.WriteLine("Shift : " + record[x].employeeshift);
                    Console.WriteLine("Phone # : " + record[x].employeephone);

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.Write("Enter the  new salary : ");
                    newsalary = int.Parse(Console.ReadLine());
                    Console.Write("Enter the  new shift: ");
                    newshift = Console.ReadLine();
                    Console.Write("Enter the  new phone: ");
                    newphone = int.Parse(Console.ReadLine());
                    em.employeename = name;
                    em.employeesalary = newsalary;
                    em.employeeshift = newshift;
                    em.employeephone = newphone;


                    record.RemoveAt(0);
                    record.Insert(x,em);
                    flag++;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("________________INFORMATION CHANGED SUCCESSFULLY ");
                Console.WriteLine("Press any key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                adminfunction();
            }
            else
            {
                Console.WriteLine("________________EMPOLOYEE NOT FOUND");
                Console.WriteLine("Press any key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                adminfunction();
            }

        }
        public static void changeuser()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            char key;
            userCr info = new userCr();
            Console.Clear();
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<LOGIN SETTING");
            Console.WriteLine("");
            Console.Write("Enter your previous username: ");
            info.username = Console.ReadLine();
            Console.Write("Enter your previous password: ");
            info.password = Console.ReadLine();
            if (info.username == identity[0].username && info.password == identity[0].password)
            {
                userCr info2 = new userCr();
                Console.WriteLine("");
                Console.Write("Enter your new username: ");
                info2.username = Console.ReadLine();
                Console.Write("Enter your new  password: ");
                info2.password = Console.ReadLine();
                identity.Insert(0, info2);
                Console.WriteLine("Password and username is successfully changed ");
                Console.WriteLine("");
                Console.Write("Press any key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                adminfunction();

            }

            else
            {
                Console.WriteLine("--------------ERROR---------------");
                Console.WriteLine("you previous username and password is incorrect so you are unable to change their password and username");
                Console.Write("Press any key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                adminfunction();
            }
        }
        public static void viewstock()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            char key;
            Console.Clear();
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<TOTAL STOCK IN SUPERMARKET");
            Console.WriteLine("");

            for (int x = 0; x < data.Count; x++)
            {

                Console.WriteLine(data[x].itemname + "\t\t\t\t\t\t" + data[x].itemprice + "\t\t\t\t\t\t" + data[x].itemrack);
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------");
            }

            Console.WriteLine("Press any key to go to main menu: ");
            key = char.Parse(Console.ReadLine());
            adminfunction();
        }
        public static void newitems()
        {


            char key;
            Console.Clear();
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<ADD ITEMS ");
            Console.WriteLine("");


        f:
            items it2 = new items();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.Write("Enter the name of item: ");
            it2.itemname = Console.ReadLine();
            Console.Write("Enter the price of item: ");
            it2.itemprice = int.Parse(Console.ReadLine());
            Console.Write("Enter the rack of product(position): ");
            it2.itemrack = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            data.Add(it2);
            Console.WriteLine("_____________ITEMS SUCCESSFULLY ADDED");
            Console.Write("Enter 'n' to add more items  and press any other key to go to main menu: ");
            key = char.Parse(Console.ReadLine());
            if (key == 'n')
                goto f;
            else
                adminfunction();
        }
        public static void addemployee()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            char key;
            Console.WriteLine("");
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<ADD EMPLOYEE ");
            Console.WriteLine("");
        f:
            employee em2 = new employee();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.Write("Enter the name of Employee: ");
            em2.employeename = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Enter the salary of Employee: ");
            em2.employeesalary = int.Parse(Console.ReadLine());
            Console.Write("Enter the shift of Employee: ");
            em2.employeeshift = Console.ReadLine();
            Console.Write("Enter the Phone no of Employee: ");
            em2.employeephone = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            record.Add(em2);

            Console.WriteLine("_____________NEW EMPLOYEE SUCCESSFULLY ADDED");
            Console.Write("Enter 'n' to add more employee and press any other key to go to main menu: ");
            key = char.Parse(Console.ReadLine());
            if (key == 'n')
                goto f;
            else
                adminfunction();
        }
        public static void adddiscount()
        {
            Console.Clear();
            adminlogo();
            char key;
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<ADD DISCOUNT ");
            Console.WriteLine("");
            Console.Write("Enter day of discount: ");
            discday = Console.ReadLine();
            Console.Write("Enter discount in percentage (%):  ");
            discrate = int.Parse(Console.ReadLine());
            Console.WriteLine("************************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("______________________________SUCCESSFULLY DISCOUNT ADDED");
            Console.WriteLine("you offered " + discrate + "% discount on " + discday);
            Console.WriteLine("-------------Press any key  to go to main menu: ");
            key = char.Parse(Console.ReadLine());


            adminfunction();
        }
        public static void viewemployee()
        {

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            char key;
            Console.Clear();
            adminlogo();

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<TOTAL EMPLOYEE WORKING IN SUPERMARKET");
            Console.WriteLine("");
            Console.WriteLine("");
            for (int x = 0; x < record.Count; x++)
            {
                Console.WriteLine(record[x].employeename + "\t\t\t\t" + record[x].employeesalary + "\t\t\t\t" + record[x].employeeshift + "\t\t\t\t" + record[x].employeephone);
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            }
            Console.WriteLine("-------------Press any key  to go to main menu: ");
            key = char.Parse(Console.ReadLine());
            adminfunction();


        }
        public static void viewpassword()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            char key;
            Console.Clear();
            adminlogo();

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<PERSONAL & SECRET DETAILS");
            Console.WriteLine("");
            Console.WriteLine("****************USERNAME*****************");
            Console.WriteLine("*\t\t" + identity[0].username + "\t\t\t*");
            Console.WriteLine("*****************************************");
            Console.WriteLine("****************PASSWORD*****************");
            Console.WriteLine("*\t\t" + identity[0].password + "\t\t\t*");
            Console.WriteLine("*****************************************");
            Console.WriteLine("");
            Console.WriteLine("___________________________________DONOT SHARE WITH OTHERS");
            Console.WriteLine("Press any key to go to main menu: ");
            key = char.Parse(Console.ReadLine());
            adminfunction();
        }
        public static void newemployeePL()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            employeeCr emCr = new employeeCr();
            char key;
            int flag = 0;
            Console.Clear();
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<ADD EMPLOYEE PASSWORD & USERNAME ");
            Console.WriteLine("");
        f:
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.Write("Enter the name of employee: ");
            emCr.Eusername= Console.ReadLine();
            Console.Write("Enter the password of employee: ");
            emCr.Epassword = Console.ReadLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            for(int x=0;x<identityE.Count;x++)
            {
                if (emCr.Eusername == identityE[x].Eusername )
                    flag++; 
            }
            if (flag == 0)
            {
                identityE.Add(emCr);
                Console.WriteLine("_____________EMPLOYEE PASSWORD & USERNAME SUCCESSFULLY ADDED");
                Console.WriteLine("");
                Console.Write("Enter 'n' to add more employee credentials and press any other key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                if (key == 'n')
                    goto f;
                else
                    adminfunction();
            }
            else
            {
                Console.WriteLine("_____________EMPLOYEE USERNMAE  already exixted please change it .....");
                Console.WriteLine("");
                Console.Write("Enter 'n' to add employee credentials and press any other key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                if (key == 'n')
                    goto f;
                else
                    adminfunction();

            }

        }
        public static void viewemplPL()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            char key;
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<EMPLOYEE PASSWORD AND THIER USERNAME");
            Console.WriteLine("");
            for (int x = 0; x < identityE.Count; x++)
            {
               
                Console.WriteLine("USERNAME: " + identityE[x]. Eusername);
                Console.WriteLine("PASSWORD: " + identityE[x].Epassword);
                Console.WriteLine("----------------------------------------------------------------------------------");

            }

    
            Console.WriteLine("-------------Press any key  to go to main menu: ");
            key = char.Parse(Console.ReadLine());
            adminfunction();
        }
        public static void changeprice()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            items it = new items();
            string name;


            char key;
            int flag = 0;
            string newprice;
            Console.Clear();
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<CHANGE PRICE  ");
            Console.WriteLine("");
            Console.Write("Enter the product name whose price you want to change:  ");
            name = Console.ReadLine();

            for (int x = 0; x < data.Count; x++)
            {
                if (name == data[x].itemname)
                {
                    Console.WriteLine("ITEM PRICE: " + data[x].itemprice);
                    Console.WriteLine("ITEM RACK : " + data[x].itemrack);

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.Write("Enter the  new price : ");
                    newprice= Console.ReadLine();
                    it.itemname = name;
                    it.itemprice = int .Parse(newprice);
                    it.itemrack = data[x].itemrack;
                    data.RemoveAt(x);
                    data.Insert(x, it);
                    flag++;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("________________PRICE CHANGED SUCCESSFULLY ");
                Console.WriteLine("Press any key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                adminfunction();
            }
            else
            {
                Console.WriteLine("________________PRODUCT NOT FOUND IN STOCK ");
                Console.WriteLine("Press any key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                adminfunction();
            }
        }

        public static void assignrack()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            items it = new items();
            string name;


            char key;
            int flag = 0;
            string newrack;
            Console.Clear();
            adminlogo();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<ASSIGN NEW RACK ");
            Console.WriteLine("");
            Console.Write("Enter the product name whose rack you want to change:  ");
           name= Console.ReadLine();

            for (int x = 0; x < data.Count; x++)
            {
                if (name == data[x].itemname)
                {
                    Console.WriteLine("ITEM PRICE: " + data[x].itemprice);
                    Console.WriteLine("ITEM RACK : " + data[x].itemrack);

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------------------------------------------------");
                    Console.Write("Enter the  new rack : ");
                    newrack = Console.ReadLine();
                    it.itemname = name;
                    it.itemprice = data[x].itemprice;
                    it.itemrack = newrack;
                    data.RemoveAt(0);
                    data.Insert(x, it);
                    flag++;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("________________RACK CHANGED SUCCESSFULLY ");
                Console.WriteLine("Press any key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                adminfunction();
            }
            else
            {
                Console.WriteLine("________________PRODUCT NOT FOUND IN STOCK ");
                Console.WriteLine("Press any key to go to main menu: ");
                key = char.Parse(Console.ReadLine());
                adminfunction();
            }  
          
        }


        

    }
}

