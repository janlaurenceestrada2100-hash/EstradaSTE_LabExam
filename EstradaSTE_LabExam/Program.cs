using System;
namespace EstradaSTE_LabExam
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("=========================================================");
                Console.WriteLine("            STUDENT SERVICE QUEUE SYSTEM ");
                Console.WriteLine("=========================================================");
                Console.WriteLine();
                var stq = new Queue<String>();
                var sts = new Stack<String>();
                string i = "0";
                while (i != "5")
                {
                    Console.WriteLine();
                    Console.WriteLine("[1] ADD STUDENT");
                    Console.WriteLine("[2] SHOW WAITING STUDENTS");
                    Console.WriteLine("[3] SERVE NEXT STUDENT");
                    Console.WriteLine("[4] SHOW LAST SERVED STUDENT");
                    Console.WriteLine("[5] EXIT ");
                    Console.WriteLine();
                    Console.Write("Enter choice: ");
                    i = Console.ReadLine();
                    switch (i)
                    {
                        case "1":
                    Console.WriteLine();
                            Console.Write("Enter student's name: ");
                            stq.Enqueue(Console.ReadLine());
                            Console.WriteLine("student added to waiting list! ");
                            break;
                        case "2":
                            if (stq.Count() != 0)
                            {
                                Console.WriteLine("STUDENTS WAITING: ");
                                int num = 0;
                                foreach (var stdnt in stq)
                                {
                                    num++;
                                    Console.WriteLine($"{num}. {stdnt}");
                                }
                                Console.WriteLine();
                                Console.WriteLine($"Total Waiting: {stq.Count()}");
                            }
                            else 
                            {
                                Console.WriteLine("No students currently in the waiting list...");
                            }
                            break;
                        case "3":
                            if (stq.Count() != 0)
                            {
                                Console.WriteLine($"Serving Student: {stq.Peek()}");
                                sts.Push(stq.Peek());
                                stq.Dequeue();
                                Console.WriteLine($"Student successfully served!");
                            }
                            else
                            {
                                Console.WriteLine("No student currently waiting to be served...");
                            }
                            break;
                        case "4":
                            {
                                if (sts.Count() != 0)
                                {
                                    Console.WriteLine("LAST SERVED STUDENT: ");
                                    Console.WriteLine(sts.Peek());
                                }
                                else
                                {
                                    Console.WriteLine("No students have been served...");
                                }
                            }
                            break;
                        case "5":
                            Console.WriteLine("You have left the student service queue system...");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error Encountered " + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}