using System;
using System.Collections.Generic;
enum Menu
{ //กำหนดเลขหน้า
    RegisterStudent = 1,
    RegisterTeacher,
    Exit
}
enum MenuForTeacher
{
    Registration = 1,
    AddActivity
}
namespace Hw2_2
{
    class Program
    {
        static PersonList personList;

        static void Main(string[] args){
            PreparPersonListWhenProgramIsLoad();
            PrintMenuScreen();
        }
        //PrintMenu&Head
        static void PreparPersonListWhenProgramIsLoad(){
            Program.personList = new PersonList();
        } 

        static void PrintHead(){
            Console.WriteLine("Registration student activities");
            Console.WriteLine("_______________________________");
            
        }

        static void PrintListMenu(){
            Console.WriteLine("[1] Register for Student.");
            Console.WriteLine("[2] Register for Teacher.");
            Console.WriteLine("[3] Register for Exit.");
        }
        
        static void PrintMenuScreen(){
            
            PrintHead();
            PrintListMenu();
            InputToSelectMenu();
        }
        static void InputToSelectMenu(){
            Console.Write("PLEASE SELECT MENU : ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }
        //Menu
        static void PresentMenu(Menu menu){
            if(menu == Menu.RegisterStudent ){
                ShowScreenInputForStudent();
            }
            else if (menu == Menu.RegisterTeacher) {
                ShowScreenInputForTeacher();
            }
            else if(menu == Menu.Exit) {
                Console.Clear();
                Console.WriteLine("THANK YOU FOR REGISTRATION!");
            }
        }
        //Student
        static void ShowScreenInputForStudent(){
            Console.Clear();
            HeadRegistrationForStudent();

            int total = TotalStudentRegister();

            InputStudentRegistrationFromKeyboard(total);
        }
        
        static void HeadRegistrationForStudent(){ 
            Console.WriteLine("Student Register");
            Console.WriteLine("________________");
        }
        
        static Student CreatStudent(){
            return new Student(InputName(),
            InputStudentID());
        }
        static void InputStudentRegistrationFromKeyboard(int total){
            for ( int i = 0; i< total; i++){
                
                Console.Clear();
                HeadRegistrationForStudent();

                Student student = CreatStudent();

                Program.personList.AddNewPerson(student);
            }

            Console.Clear();
            PrintMenuScreen();
        }
        //Teacher
        static void PrintTeacherMenuScreen()
        {
            HeadRegistrationForTeacher();
            MenuTeacher();
            IntputSelcetMenuTeacher();
        }
        static void HeadRegistrationForTeacher(){
            Console.WriteLine("Teacher Register");
            Console.WriteLine("________________");
        }
        static void MenuTeacher()
        {
            Console.WriteLine("[1] Register.");
            Console.WriteLine("[2] Add Activity");
        }
        static Teacher CreatTeacher()
        {
            return new Teacher(InputName(),
            InputEmployeeID());
        }
        //ของครู
        static void ShowScreenRegister()
        {
            Console.Clear();
            HeadRegistrationForTeacher();
            int total = TotalTeacherRegister();
            InputTeacherRegistration(total);
        }
        //ใช่ชื่อ
        static void InputTeacherRegistration(int total ){
            for(int i = 0; i< total; i++){
                
                Console.Clear();
                HeadRegistrationForTeacher();
                Teacher teacher = CreatTeacher();
                Program.personList.AddNewPerson(teacher);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        //เลือกเมนู
        static void ShowScreenInputForTeacher()
        {
            Console.Clear();
            PrintTeacherMenuScreen();
        }
        static void ShowScreenTeacher()
        {
            Console.Clear();
            ShowScreenRegister();
        }
        static void IntputSelcetMenuTeacher()
        {
            Console.Write("Select Menu : ");
            MenuForTeacher selectMenu = (MenuForTeacher)(int.Parse(Console.ReadLine()));

            PresentMenuForTeacher(selectMenu);
        }
        static void PresentMenuForTeacher(MenuForTeacher menuTeacher)
        {
            if (menuTeacher == MenuForTeacher.Registration)
            {
                ShowScreenTeacher();
            }
            else if (menuTeacher == MenuForTeacher.AddActivity)
            {
                Console.Clear();
                string text = "";
                Console.WriteLine("Add your activity");
                Console.WriteLine("_________________");

                while (text != "End")
                {
                    text = InputNameActivity();
                }
                Console.Clear();
                PrintMenuScreen();
                }
               
        }
        //Total To input
        
        static int TotalStudentRegister(){
            Console.Write("Input total Register:");
            return int.Parse(Console.ReadLine());
        }
        static int TotalTeacherRegister()
        {
            Console.Write("Input total Register:");
            return int.Parse(Console.ReadLine());
        }
        static string InputNameActivity()
        {
            Console.Write("Type Name Activity : ");
            return Console.ReadLine();
        }
        static string InputName(){
            Console.Write("Name: ");

            return Console.ReadLine();
        }

        static string InputStudentID(){
            Console.Write("StudentID: ");

            return Console.ReadLine();
        }

        static string InputEmployeeID(){
            Console.Write("EmployeeID: ");

            return Console.ReadLine();
        }
    }
}
