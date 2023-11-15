class ToDoListUI 
{
    public void PrintTask(ToDo task, int longest) 
    {
        if (!task.IsDone)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        Console.Write(task.Description);
        for (int i = 0; i < longest - task.Description.Length; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(" (" + task.DueDate.ToShortDateString() + ")");
        Console.ResetColor();
    }

    public ToDo ChooseToDo(List<ToDo> toDoList)
    {
        int index = 0;
        foreach(ToDo aufgabe in toDoList)
        {
            Console.WriteLine(index + ": " + aufgabe);
            index++;
        }
        string eingabe = Console.ReadLine();
        index = Convert.ToInt32(eingabe);
        return toDoList[index];
    }

    public int LongestDescription(List<ToDo> toDoList)
    {
        int longest = 0;
        foreach(ToDo aufgabe in toDoList)
        {
            if (aufgabe.Description.Length > longest)
            {
                longest = aufgabe.Description.Length;
            }
        }
        return longest;
    }
}