using System;
enum Menu{
    RegisterNewStudent = 1,
    RegisterNewTeacher,
    GetListPersons
}
namespace Hw2_1{
    class Program{
        static PersonList personList;
        static void Main(string[] args){
            PreparePersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }

        static void PreparePersonListWhenProgramIsLoad(){
            Program.personList = new PersonList();
        }

        static void PrintMenuScreen() {
            Console.Clear();
            PrintHeaderAndMenu();
            InputMenuFromKeyboard();
        }

        static void PrintHeaderAndMenu(){
            Console.WriteLine("Welcome to registration new user school application.");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1. Register new student.");
            Console.WriteLine("2. Register new Teacher.");
            Console.WriteLine("3. Get List Persons.");
        }

        static void PresentMenu(Menu menu){
            if (menu == Menu.RegisterNewStudent){
                //ShowInputRegisterNewStudentScreen
                Console.Clear();
                PrintHeaderRegisterStudent();

                int totalStudent = TotalNewStudents();
                InputNewStudentFromKeyboard(totalStudent);
            }
            else if (menu == Menu.RegisterNewTeacher) {
                //ShowInputRegisterNewTeacherScreen
                Console.Clear();
                PrintHeaderRegisterTeacher();

                int totalTeacher = TotalNewTeacher();
                InputNewTeacherFromKeyboard(totalTeacher);
            }
            else if (menu == Menu.GetListPersons) {
                //ShowGetListPersonScreen
                Console.Clear();
                Program.personList.FetchPersonsList();
                InputExitFromKeyboard();
            }
            else {
                //ShowMessageInputMenuIsInCorrect
                Console.Clear();
                Console.WriteLine("Menu Incorrect Please try again.");
                InputMenuFromKeyboard();
            }
        }

        static void InputMenuFromKeyboard() {
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void InputExitFromKeyboard() {
            string text = "";
            while (text != "exit")
            {
                Console.WriteLine("Input: ");
                text = Console.ReadLine();
            }
            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewTeacherFromKeyboard(int totalTeacher) {
            for (int i = 0; i < totalTeacher; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();

                Teacher teacher = CreateNewTeacher();
                Program.personList.AddNewPerson(teacher);
            }
            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewStudentFromKeyboard(int totalStudent) {
            for (int i = 0; i < totalStudent; i++) {
                Console.Clear();
                PrintHeaderRegisterStudent();

                Student student = CreateNewStudent();
                Program.personList.AddNewPerson(student);
            }
            Console.Clear();
            PrintMenuScreen();
        }

        static Student CreateNewStudent() {
            return new Student(InputName(),
             InputAddress(),
             InputCitizenID(),
             InputStudentID());
        }

        static Teacher CreateNewTeacher() {
            return new Teacher(InputName(),
            InputAddress(),
            InputCitizenID(),
            InputEmployeeID());
        }

        static string InputName() {
            Console.Write("Name: ");

            return Console.ReadLine();
        }

        static string InputStudentID(){
            Console.Write("Student ID: ");

            return Console.ReadLine();
        }

        static string InputAddress(){
            Console.Write("Address: ");

            return Console.ReadLine();
        }

        static string InputCitizenID(){
            Console.Write("Citizen ID: ");

            return Console.ReadLine();
        }

        static string InputEmployeeID(){
            Console.Write("Employee ID: ");

            return Console.ReadLine();
        }

        static int TotalNewStudents(){
            Console.Write("Input Total new Student: ");

            return int.Parse(Console.ReadLine());
        }

        static int TotalNewTeacher() {
            Console.Write("Input Total new Teacher: ");

            return int.Parse(Console.ReadLine());
        }

        static void PrintHeaderRegisterStudent(){
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderRegisterTeacher(){
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }
    }
}
