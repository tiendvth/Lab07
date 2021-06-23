using System;
using System.Text;

namespace lap07
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var employeeManager = new EmployeeManager();

            while (true)
            {
                Console.WriteLine("\n=============================");
                Console.WriteLine("1. để thêm mới");
                Console.WriteLine("2. để hiển thị");
                Console.WriteLine("3. để thay đổi");
                Console.WriteLine("4. để xóa");
                Console.WriteLine("5. để thoát");
                Console.WriteLine("=============================\n");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employeeManager.Add();
                        break;
                    case 2:
                        employeeManager.ShowList();
                        break;
                    case 3:
                        employeeManager.Modify();
                        break;
                    case 4:
                        employeeManager.delete();
                        break;
                    case 5:
                        Console.WriteLine("Tạm Biệt hẹn gặp lại ");
                        break;
                }
                if (choice == 5)
                {
                    break;
                }
            }
        }
    }
}