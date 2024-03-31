namespace StringAndArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Telebenin adi daxil edin edin:");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Telebenin qrup nomresini daxil edin:");
            student.GroupNo = Console.ReadLine();
            Console.WriteLine("Telebenin ortalama balinin daxil edin:");
            student.AvgPoint = Convert.ToDouble(Console.ReadLine());



            Student newStudent = new Student();
            Group group = new Group();
            do
            {
                Console.WriteLine("Studentlimit deyerini daxil edin:");
                group.StudentLimit = Convert.ToByte(Console.ReadLine());

                if (group.StudentLimit < 0 || group.StudentLimit > 20)
                {
                    Console.WriteLine("Limit asilmisdir");
                }
            }
            while (group.StudentLimit < 0 || group.StudentLimit > 20);

            do
            {
                Console.WriteLine("Qrup nomresi daxil edin:");
                group.GroupNo = Console.ReadLine();
                if (group.GroupNo.Length != 5 || !char.IsUpper(group.GroupNo[0]) || !char.IsUpper(group.GroupNo[1]))
                {
                    Console.WriteLine("Qrup nomresi duzgun deyil!");
                }
            }
            while (group.GroupNo.Length != 5 || !char.IsUpper(group.GroupNo[0]) || !char.IsUpper(group.GroupNo[1]));
            group.AddStudent(student);




            int choice;
            do
            {
                Console.WriteLine("Menu:\n1.Telebe elave edilsin.\n2.Butun telebeleri gosder.\n3.Telebeler uzerinde axtaris olunsun.\n0.Proqrami bitir.");
                choice = Convert.ToInt32(Console.ReadLine());


                if (choice == 1)
                {
                    Console.WriteLine("Ad ve soyad daxil edin:");
                    string fullname = Console.ReadLine();

                    string groupno;
                    do
                    {

                        Console.WriteLine("Qrup nomresini daxil edin:");
                        groupno = Console.ReadLine();

                        if (groupno.Length != 5 || !char.IsUpper(groupno[0]) || !char.IsUpper(groupno[1]))
                        {
                            Console.WriteLine("Qrup nomresi duzgun deyil!");
                        }
                    }
                    while (groupno.Length != 5 || !char.IsUpper(groupno[0]) || !char.IsUpper(groupno[1]));


                    Console.WriteLine(" ");
                    string avgpointStr = " ";
                    byte avgpoint;

                    do
                    {
                        Console.WriteLine("Ortalama balini daxil edin:");
                        avgpointStr = Console.ReadLine();
                    }
                    while (!byte.TryParse(avgpointStr, out avgpoint));

                    Console.WriteLine("");
                    Console.WriteLine("Telebe elave edildi.");

                    newStudent = new Student(fullname, groupno, avgpoint);

                    group.AddStudent(newStudent);
                }
                else if (choice == 2)
                {
                    group.ShowAllStudentInfo();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Deyeri daxil edin:");
                    string value = Console.ReadLine();
                    Console.WriteLine("");

                    group.SearchStudent(value);
                }
            }
            while (choice != 0);

            Console.WriteLine("Proqram bitdi!");
        }
    }   
}
