using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Program
    {
        public static void Main()
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            Proverka check = new Proverka();

            Console.WriteLine("=== Задание 1, задача 3. Имена ===");
            DemonstrateName();

            Console.WriteLine("\n=== Задание 1, задача 5. Дом ===");
            DemonstrateHouse(check);

            Console.WriteLine("\n=== Задание 2, задача 4. Сотрудники и отделы ===");
            DemonstrateDepartment();

            Console.WriteLine("\n=== Задание 3, задача 4. Коллеги ===");
            DemonstrateColleagues(check);

            Console.WriteLine("\n=== Задание 4, задача 5. Создаём Имена ===");
            DemonstrateNameConstructors(check);

            Console.WriteLine("\n=== Задание 5, задача 5. Дроби ===");
            DemonstrateFraction();
        }

        // ---------- Задание 1, задача 3 ----------
        private void DemonstrateName()
        {
            Name cleopatra = new Name("Клеопатра");
            Name pushkin = new Name("Александр", "Пушкин", "Сергеевич");
            Name mayakovsky = new Name("Владимир", "Маяковский");

            Console.WriteLine(cleopatra);
            Console.WriteLine(pushkin);
            Console.WriteLine(mayakovsky);
        }

        // ---------- Задание 1, задача 5 ----------
        private void DemonstrateHouse(Proverka check)
        {
            House h1 = new House(1);
            House h5 = new House(5);
            House h23 = new House(23);

            Console.WriteLine(h1);
            Console.WriteLine(h5);
            Console.WriteLine(h23);

            Console.WriteLine("\nСоздайте свой дом:");
            int floors = check.ReadPositiveInt("Введите количество этажей (положительное): ");
            House userHouse = new House(floors);
            Console.WriteLine("Ваш дом: " + userHouse);
        }

        // ---------- Задание 2, задача 4 ----------
        private void DemonstrateDepartment()
        {
            Department it = new Department("IT");

            Employee petrov = new Employee("Петров");
            Employee kozlov = new Employee("Козлов");
            Employee sidorov = new Employee("Сидоров");

            it.AddEmployee(petrov);
            it.AddEmployee(kozlov);
            it.AddEmployee(sidorov);

            it.Head = kozlov;
            kozlov.Department = it;

            Console.WriteLine(petrov);
            Console.WriteLine(kozlov);
            Console.WriteLine(sidorov);
        }

        // ---------- Задание 3, задача 4 ----------
        private void DemonstrateColleagues(Proverka check)
        {
            Console.WriteLine("Создайте отдел:");

            string deptName = check.ReadString("Название отдела: ");

            Department dept = new Department(deptName);

            int count = check.ReadPositiveInt("Сколько сотрудников? ");
            for (int i = 1; i <= count; i++)
            {
                string name = check.ReadName("Имя сотрудника " + i + ": ");
                Employee e = new Employee(name);
                dept.AddEmployee(e);
            }

            if (dept.Employees.Count > 0)
            {
                dept.Head = dept.Employees[0];
            }

            Console.WriteLine("\nВсе сотрудники отдела " + deptName + ":");
            foreach (Employee e in dept.GetAllEmployees())
            {
                Console.WriteLine(e.Name);
            }

            if (dept.Employees.Count > 0)
            {
                Employee first = dept.Employees[0];
                Console.WriteLine("\nКоллеги " + first.Name + ":");

                List<Employee> colleagues = first.Department.GetColleagues(first);

                if (colleagues.Count == 0)
                {
                    Console.WriteLine("(нет коллег)");
                }
                else
                {
                    foreach (Employee e in colleagues)
                    {
                        Console.WriteLine(e.Name);
                    }
                }
            }
        }

        // ---------- Задание 4, задача 5 ----------
        private void DemonstrateNameConstructors(Proverka check)
        {
            Name n1 = new Name("Клеопатра");
            Name n2 = new Name("Александр", "Пушкин", "Сергеевич");
            Name n3 = new Name("Владимир", "Маяковский");
            Name n4 = new Name("Христофор", "Бонифатьевич");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("\nВведите имя вручную:");
            string first = check.ReadName("Личное имя: ");
            string last = check.ReadOptionalName("Фамилия (Enter — пропустить): ");
            string patr = check.ReadOptionalName("Отчество (Enter — пропустить): ");

            Name user;
            if (last == null && patr == null)
            {
                user = new Name(first);
            }
            else if (patr == null)
            {
                user = new Name(first, last);
            }
            else
            {
                user = new Name(first, last, patr);
            }

            Console.WriteLine("Ваше имя: " + user);
        }

        // ---------- Задание 5, задача 5 ----------
        private void DemonstrateFraction()
        {
            Fraction f1 = new Fraction(1, 3);
            Fraction f2 = new Fraction(2, 3);
            Fraction f3 = new Fraction(1, 2);

            Console.WriteLine("Исходные дроби:");
            Console.WriteLine("f1 = " + f1);
            Console.WriteLine("f2 = " + f2);
            Console.WriteLine("f3 = " + f3);
            Console.WriteLine();

            Console.WriteLine("Операции с другой дробью:");

            Fraction sum = f1.Sum(f2);
            Console.WriteLine(f1 + " + " + f2 + " = " + sum);

            Fraction minus = f1.Minus(f2);
            Console.WriteLine(f1 + " - " + f2 + " = " + minus);

            Fraction mul = f1.Multiply(f2);
            Console.WriteLine(f1 + " * " + f2 + " = " + mul);

            Fraction div = f1.Divide(f3);
            Console.WriteLine(f1 + " / " + f3 + " = " + div);
            Console.WriteLine();

            Console.WriteLine("Операции с целым числом:");

            Fraction sumInt = f1.Sum(1);
            Console.WriteLine(f1 + " + 1 = " + sumInt);

            Fraction minusInt = f1.Minus(1);
            Console.WriteLine(f1 + " - 1 = " + minusInt);

            Fraction mulInt = f1.Multiply(2);
            Console.WriteLine(f1 + " * 2 = " + mulInt);

            Fraction divInt = f1.Divide(2);
            Console.WriteLine(f1 + " / 2 = " + divInt);
            Console.WriteLine();

            Console.WriteLine("Исходные дроби после операций:");
            Console.WriteLine("f1 = " + f1);
            Console.WriteLine("f2 = " + f2);
            Console.WriteLine("f3 = " + f3);
            Console.WriteLine();

            Fraction chain = f1.Sum(f2).Divide(f3).Minus(5);
            Console.WriteLine("f1.Sum(f2).Divide(f3).Minus(5) = " + chain);
        }
    }
}
