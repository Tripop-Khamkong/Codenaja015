namespace ExamCode
{
    enum MainMenu
    {
        RegisterEvent = 1,
        ShowStatistics = 2,
        Login = 3
    }
    enum RegisterMenu
    {
        RegisterScholar = 1,
        RegisterStudent = 2,
        RegisterTeacher = 3
    }
    enum PassLoginMenu
    {
        RegisterEvent = 1,
        PrintinformationScholar = 2,
        PrintinformationStudent = 3,
        PrintinformationTeacher = 4,
        Logout = 5
    }
    public class Program
    {
        static PersonList personList;
        public static void Main(string[] args)
        {
            PreparePersonListWhenProgramIsLoad();
            InputMainMenuFromKeyboard();
        }
        public static void PrintMainMenuScreen()
        {
            Console.Clear();
            PrintListMainMenu();
        }
        public static void PrintListMainMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("*************************");
            Console.WriteLine("Welcome to Idia camp 2022");
            Console.WriteLine("*************************");
            Console.WriteLine("1.Register");
            Console.WriteLine("2.ShowStatistics");
            Console.WriteLine("3.Login");
            Console.WriteLine("*************************");
        }
        public static void InputMainMenuFromKeyboard()
        {
            PrintListMainMenu();
            Console.Write("Please Input Menu: ");
            MainMenu mainmenu = (MainMenu)(int.Parse(Console.ReadLine()));

            PresentMainMenu(mainmenu);
        }

        static void PresentMainMenu(MainMenu mainmenu)
        {
            switch (mainmenu)
            {
                case MainMenu.RegisterEvent:
                    InputRegistermenuFromKeyboard();
                    break;
                case MainMenu.ShowStatistics:
                    PrintStatistics();
                    break;
                case MainMenu.Login:
                    InputPassLoginMenuFromKeyboard();
                    break;
                default:
                    break;
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public static void PrintListRegistermenu()
        {
            Console.WriteLine("");
            Console.WriteLine("*******************");
            Console.WriteLine("    Register    ");
            Console.WriteLine("*******************");
            Console.WriteLine("   1.Scholar   ");
            Console.WriteLine("   2.Student   ");
            Console.WriteLine("   3.Teacher   ");
            Console.WriteLine("********************");
        }
        public static void InputRegistermenuFromKeyboard()
        {
            PrintListRegistermenu();
            Console.Write("Please Input Menu: ");
            RegisterMenu registermenu = (RegisterMenu)(int.Parse(Console.ReadLine()));

            PresentRegisterMenu(registermenu);
        }

        static void PresentRegisterMenu(RegisterMenu registermenu)
        {
            switch (registermenu)
            {
                case RegisterMenu.RegisterScholar:
                    ShowInputRegistrationNewsScholarScreen();
                    break;
                case RegisterMenu.RegisterStudent:
                    ShowInputRegistrationNewsStudentScreen();
                    break;
                case RegisterMenu.RegisterTeacher:
                    ShowInputRegistrationNewsTeacherScreen();
                    break;
                default:
                    break;
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public static void PrintLoginMenu()
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("          Login          ");
            Console.WriteLine("*************************");
            Console.WriteLine("Email :");
            string Email = Console.ReadLine();
            Console.WriteLine("Password :");
            string Password = Console.ReadLine();
        }

        public static void PrintListPassLoginMenu()
        {
            Console.Clear();
            Console.WriteLine("*************************");
            Console.WriteLine("      Welcome Admin      ");
            Console.WriteLine("*************************");
            Console.WriteLine("1.Register");
            Console.WriteLine("2.PrintinformationScholar");
            Console.WriteLine("3.PrintinformationStudent");
            Console.WriteLine("4.PrintinformationTeacher");
            Console.WriteLine("5.Logout");
            Console.WriteLine("*************************");
        }
        public static void InputPassLoginMenuFromKeyboard()
        {
            PrintListPassLoginMenu();
            Console.Write("Please Input Menu: ");
            PassLoginMenu passloginmenu = (PassLoginMenu)(int.Parse(Console.ReadLine()));

            PresentPassLoginMenu(passloginmenu);
        }

        static void PresentPassLoginMenu(PassLoginMenu passloginmenu)
        {
            switch (passloginmenu)
            {
                case PassLoginMenu.RegisterEvent:
                    InputRegistermenuFromKeyboard();
                    break;
                case PassLoginMenu.PrintinformationScholar:
                    ShowScholar();
                    break;
                case PassLoginMenu.PrintinformationStudent:
                    ShowStudent();
                    break;
                case PassLoginMenu.PrintinformationTeacher:
                    ShowTeacher();
                    break;
                case PassLoginMenu.Logout:
                    Logout();
                    break;
                default:
                    break;
            }
        }
        //---------------------------------------------------------------------------------------------------------------
        public static void ShowInputRegistrationNewsScholarScreen()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("Register Scholar");
            Console.WriteLine("----------------");

            InputNewScholarFromKeyboard();
        }
        static void InputNewScholarFromKeyboard()
        {
            bool Admin = AdminQuestion();
            Scholar scholar;
            if (Admin)
            {
                scholar = new Scholar(InputGender(), InputFirstName(), InputLestName(), InputScholarID(), InputAge(), InputAllergy(), InputReligion(), InputEmailScholar(), InputPasswordScholar());
            }
            else
            {
                scholar = new Scholar(InputGender(), InputFirstName(), InputLestName(), InputScholarID(), InputAge(), InputAllergy(), InputReligion(), "", "");
            }

            Program.personList.AddNewPerson(scholar);

            BackToMainMenu();
        }
        //---------------------------------------------------------------------------------------------------------------
        public static void ShowInputRegistrationNewsStudentScreen()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("Register Student");
            Console.WriteLine("----------------");

            InputNewStudentFromKeyboard();
        }
        static void InputNewStudentFromKeyboard()
        {
            Student student = new Student(InputGender(), InputFirstName(), InputLestName(), InputAge(), InputLevel(), InputAllergy(), InputReligion(), InputSchool());
            Program.personList.AddNewPerson(student);

            BackToMainMenu();
        }
        //---------------------------------------------------------------------------------------------------------------
        static void ShowInputRegistrationNewsTeacherScreen()
        {
            Console.Clear();
            Console.WriteLine("----------------");
            Console.WriteLine("Register Teacher");
            Console.WriteLine("----------------");

            InputNewTeacherFromKeyboard();
        }
        static void InputNewTeacherFromKeyboard()
        {
            bool Admin = AdminQuestion();
            bool HaveCar = CarQuestion();
            Teacher teacher;

            if (Admin)
            {
                string idcar = InputCarID();
                teacher = new Teacher(InputGender(), InputFirstName(), InputLestName(), InputAge(), InputAllergy(), InputReligion(), InputRank(), HaveCar, idcar, InputEmailTeacher(), InputPasswordTeacher());
            }
            else
            {
                teacher = new Teacher(InputGender(), InputFirstName(), InputLestName(), InputAge(), InputAllergy(), InputReligion(), InputRank(), false, "", InputEmailTeacher(), InputPasswordTeacher());
            }
            BackToMainMenu();
        }
        //---------------------------------------------------------------------------------------------------------------
        static void PreparePersonListWhenProgramIsLoad()
        {
            Program.personList = new PersonList();
        }
        //---------------------------------------------------------------------------------------------------------------
        public static string InputGender()
        {
            Console.Write("Gender (Mr./Mrs./Miss.): ");
            return Console.ReadLine();
        }
        public static string InputFirstName()
        {
            Console.Write("FirstName: ");
            return Console.ReadLine();
        }
        public static string InputLestName()
        {
            Console.Write("LastName: ");
            return Console.ReadLine();
        }
        public static int InputAge()
        {
            Console.Write("Age: ");
            return int.Parse(Console.ReadLine());
        }
        public static string InputAllergy()
        {
            Console.Write("Allergy: ");
            return Console.ReadLine();
        }
        public static string InputReligion()
        {
            Console.Write("Religion (Buddhist/Chris/islam): ");
            return Console.ReadLine();
        }
        public static string InputScholarID()
        {
            Console.Write("ScholarID: ");
            return Console.ReadLine();
        }
        public static string InputLevel()
        {
            Console.Write("School Level (Garde 10/11/12): ");
            return Console.ReadLine();
        }
        public static string InputSchool()
        {
            Console.Write("School: ");
            return Console.ReadLine();
        }
        public static string InputRank()
        {
            Console.Write("Rank (Dean/Department Head/Teacher): ");
            return Console.ReadLine();
        }
        //---------------------------------------------------------------------------------------------------------------
        static void BackToMainMenu()
        {
            Console.Clear();
            InputMainMenuFromKeyboard();
        }
        static void ShowScholar()
        {
            Console.Clear();
            Program.personList.FetchScholarList();
            PressToContinueAdmin();
        }
        static void ShowStudent()
        {
            Console.Clear();
            Program.personList.FetchStudentList();
            PressToContinueAdmin();
        }
        static void ShowTeacher()
        {
            Console.Clear();
            Program.personList.FetchTeacherList();
            PressToContinueAdmin();
        }
        static void PressToContinueAdmin()
        {
            Console.Write("Press enter to continue");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                InputPassLoginMenuFromKeyboard();
            }
        }
        static void PressToContinue()
        {
            Console.Write("Press enter to continue");
            string enter = Console.ReadLine();
            if (enter == "")
            {
                InputMainMenuFromKeyboard();
            }
        }
        static void Logout()
        {
            BackToMainMenu();
        }
        public static void PrintStatistics()
        {
            personList.PrintStatistics();
            PressToContinue();
        }
        //---------------------------------------------------------------------------------------------------------------
        static bool CarQuestion()
        {
            Console.WriteLine("----------------------");
            Console.Write("Did you have a car (yes/no) :");
            Console.Write("");
            string CarQuestion = Console.ReadLine();
            Console.WriteLine("----------------------");
            if (CarQuestion == "yes" || CarQuestion == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string InputCarID()
        {
            Console.Write("Car Number: ");
            return Console.ReadLine();
        }
        static bool AdminQuestion()
        {
            Console.WriteLine("----------------------");
            Console.Write("Are you an administrator? (yes/no) :");
            Console.Write("");
            string AdminQuestion = Console.ReadLine();
            Console.WriteLine("----------------------");
            if (AdminQuestion == "yes" || AdminQuestion == "Yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string InputEmailScholar()
        {
            Console.Write("Email : ");
            return Console.ReadLine();
        }
        static string InputPasswordScholar()
        {
            Console.Write("Password : ");
            return Console.ReadLine();
        }
          static string InputEmailTeacher()
        {
            Console.Write("Email : ");
            return Console.ReadLine();
        }
        static string InputPasswordTeacher()
        {
            Console.Write("Password : ");
            return Console.ReadLine();
        }
    }

}