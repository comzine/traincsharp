List<ToDo> toDoList = new List<ToDo>();

ToDoListUI toDoListUI = new ToDoListUI();

ToDo task;

int auswahl = 0;

while(auswahl != 6)
{
    Console.WriteLine("1. Aufgabe hinzufügen");
    Console.WriteLine("2. Aufgabe löschen");
    Console.WriteLine("3. Aufgabe erledigt");
    Console.WriteLine("4. Aufgaben anzeigen");
    Console.WriteLine("5. Aufgaben sortieren");
    Console.WriteLine("6. Beenden");

    string eingabe = Console.ReadLine();
    auswahl = Convert.ToInt32(eingabe);

    switch(auswahl)
    {
        case 1:
            Console.WriteLine("Aufgabe hinzufügen");
            eingabe = Console.ReadLine();
            Console.WriteLine("Fälligkeitsdatum eingeben");
            string dueDate = Console.ReadLine();
            ToDo toDo = new ToDo(eingabe);
            toDo.DueDate = Convert.ToDateTime(dueDate);
            toDoList.Add(toDo);
            break;
        case 2:
            Console.WriteLine("Aufgabe löschen");
            task = toDoListUI.ChooseToDo(toDoList);
            toDoList.Remove(task);
            break;
        case 3:
            Console.WriteLine("Aufgabe erledigt");
            task = toDoListUI.ChooseToDo(toDoList);
            task.IsDone = true;
            break;
        case 4:
            Console.WriteLine("Aufgaben anzeigen");
            int longest = toDoListUI.LongestDescription(toDoList);
            foreach(ToDo aufgabe in toDoList)
            {
                toDoListUI.PrintTask(aufgabe, longest);
            }
            break;
        case 5:
            Console.WriteLine("Aufgaben sortieren");
            toDoList.Sort();
            break;
       case 6:
            Console.WriteLine("Beenden");
            break;
        default:
            Console.WriteLine("Falsche Eingabe");
            break;
    }

}