using System;

namespace TaskMaster
{
    //// Made by: Milfred Kilaton
    struct TaskPriority
    {
        public int TaskPriorityLevel;
    }
    class UserTask
    {
        public string taskName;
        public string taskDescription;
        public string taskDeadline;
        public string taskStatus;
        public TaskPriority Priority;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int taskCount;

            while (true)
            {
                Console.WriteLine("---Task Master---");
                Console.Write("How many tasks would you like to enter? ");
                if (!int.TryParse(Console.ReadLine(), out taskCount) || taskCount <= 0)
                {
                    Console.WriteLine("Please enter a valid number.\nPress any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

            UserTask[] taskList = new UserTask[taskCount];

            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine($"\nRegistering Task #{i + 1}: ");

                taskList[i] = new UserTask();

                Console.Write("\nTask Name: ");
                taskList[i].taskName = Console.ReadLine();

                Console.Write("\nTask Description: ");
                taskList[i].taskDescription = Console.ReadLine();

                Console.Write("\nTask Deadline(E.g Jan 20): ");
                taskList[i].taskDeadline = Console.ReadLine();

                Console.Write("\nPriority Level (1 - 10): ");
                while (true) 
                {
                    if (!int.TryParse(Console.ReadLine(), out taskList[i].Priority.TaskPriorityLevel) || taskList[i].Priority.TaskPriorityLevel <= 0 || taskList[i].Priority.TaskPriorityLevel > 10)
                    {
                        Console.Write("Please enter a number from 1 to 10.\n - ");
                    }
                    else
                    {
                        break;
                    }
              
                }

                Console.Write("\nIs task completed? (Y/N)");
                char taskInput = Convert.ToChar(Console.ReadKey());
                taskInput.ToLower();
                if (taskInput == 'Y')
                {

                }
            }

            Console.WriteLine("------------- Current Tasks -------------");
            int count = 0;
            foreach (UserTask task in taskList)
            {
                Console.WriteLine($"-------------- Task #{count} -----------------");
                Console.WriteLine($"Task Name: {task.taskName}");
                Console.WriteLine($"Task Description:\n - {task.taskDescription}");
                Console.WriteLine($"Task Deadline: {task.taskDeadline}");
                Console.WriteLine($"Task Priority: {task.Priority.TaskPriorityLevel}");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"STATUS : {count} -----------------------");
                count++;
            }
        }
    }
}