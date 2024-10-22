namespace Todo_List
{
    public class Todo
    {
        public const string GREETING = "Todo List Menu:";
        public const string PROMPT_START = "Enter your choice: ";
        public const string PROMPT_ADD = "Enter a new task: ";
        public const string PROMPT_REMOVE = "Enter the task number: ";
        public const string ERROR_INPUT = "Invalid input!";
        public const string ERROR_REMOVE = "Invalid task!";
        public const string ERROR_TASK_EMPTY = "No tasks to delete!";
        public const string EMPTY_LIST = "No tasks in the list.";
        public const string TASK_DECO = "---------------";
        private readonly string MENU = $"{GREETING}\n1. View Tasks\n2. Add a Task\n3. Remove a Task\n4. Exit";

        public List<string> tasks;

        public Todo()
        {
            tasks = new List<string>();
        }

        public void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine(MENU);
            Console.WriteLine();
        }

        public int GetChoice()
        {
            Console.WriteLine(PROMPT_START);
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine(ERROR_INPUT);
                return -1;
            }
            if (int.TryParse(input, out int choice))
            {
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine(ERROR_INPUT);
                    return -1;
                }
                return choice;
            }
            else
            {
                Console.WriteLine(ERROR_INPUT);
                return -1;
            }
        }

        public List<string> ViewTasks(List<string> tasks)
        {
            if (!tasks.Any())
            {
                Console.WriteLine(EMPTY_LIST);
                return new List<string>();
            }

            Console.WriteLine(TASK_DECO);
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            Console.WriteLine(TASK_DECO);
            return tasks;
        }

        public List<string> AddTask(List<string> tasks)
        {
            Console.WriteLine(PROMPT_ADD);
            string task = Console.ReadLine();
            if (string.IsNullOrEmpty(task))
            {
                Console.WriteLine(ERROR_REMOVE);
                return tasks;
            }
            tasks.Add(task);
            return tasks;
        }

        public List<string> RemoveTask(List<string> tasks)
        {
            Console.WriteLine(PROMPT_REMOVE);
            string task = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(task))
            {
                Console.WriteLine(ERROR_TASK_EMPTY);
                return tasks;
            }

            if (int.TryParse(task, out int taskNum))
            {
                if (taskNum < 1 || taskNum > tasks.Count)
                {
                    Console.WriteLine(ERROR_REMOVE);
                    return tasks;
                }
                tasks.RemoveAt(taskNum - 1);
                return tasks;
            }
            else
            {
                Console.WriteLine(ERROR_REMOVE);
                return tasks;
            }
        }
    }
}
