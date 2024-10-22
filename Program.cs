namespace Todo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Todo Todo = new Todo();
            bool running = true;

            while (running)
            {
                Todo.DisplayMenu();
                int choice = Todo.GetChoice();

                if (choice != -1)
                    switch (choice)
                    {
                        case 1:
                            Todo.ViewTasks(Todo.tasks);
                            break;
                        case 2:
                            Todo.AddTask(Todo.tasks);
                            break;
                        case 3:
                            Todo.RemoveTask(Todo.tasks);
                            break;
                        case 4:
                            running = false;
                            break;
                        default:
                            Console.WriteLine(Todo.ERROR_INPUT);
                            break;
                    };
            }
        }
    }
}

