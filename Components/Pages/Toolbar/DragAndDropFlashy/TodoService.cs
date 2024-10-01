// using System.Collections.Generic;

// public class TodoService
// {
//     public List<TodoItem> TodoList1 { get; } = new List<TodoItem>
//     {
//         new TodoItem { Text = "Task 1" },
//         new TodoItem { Text = "Task 2" }
//     };

//     public List<TodoItem> TodoList2 { get; } = new List<TodoItem>();
//     public List<TodoItem> TodoList3 { get; } = new List<TodoItem>();

//     private TodoItem? draggedTodoItem;

//     public void AddTodo(int listNumber, string todoText)
//     {
//         var newTodo = new TodoItem { Text = todoText };
//         switch (listNumber)
//         {
//             case 1:
//                 TodoList1.Add(newTodo);
//                 break;
//             case 2:
//                 TodoList2.Add(newTodo);
//                 break;
//             case 3:
//                 TodoList3.Add(newTodo);
//                 break;
//         }
//     }

//     public void StartDrag(TodoItem todo)
//     {
//         draggedTodoItem = todo;
//     }

//     public void DropTodoItem(int targetListNumber)
//     {
//         if (draggedTodoItem != null)
//         {
//             // Remove the dragged item from all lists
//             TodoList1.Remove(draggedTodoItem);
//             TodoList2.Remove(draggedTodoItem);
//             TodoList3.Remove(draggedTodoItem);

//             // Add it to the new list
//             switch (targetListNumber)
//             {
//                 case 1:
//                     TodoList1.Add(draggedTodoItem);
//                     break;
//                 case 2:
//                     TodoList2.Add(draggedTodoItem);
//                     break;
//                 case 3:
//                     TodoList3.Add(draggedTodoItem);
//                     break;
//             }

//             draggedTodoItem = null; // Clear the dragged item
//         }
//     }
// }

// public class TodoItem
// {
//     public string? Text { get; set; }
// }

public class TodoService
{
    public List<TodoItem> TodoList1 { get; } = new();
    public List<TodoItem> TodoList2 { get; } = new();
    public List<TodoItem> TodoList3 { get; } = new();

    private TodoItem? draggedTodoItem;

    public void AddTodo(int listNumber, string text)
    {
        var newTodo = new TodoItem { Text = text };
        switch (listNumber)
        {
            case 1:
                TodoList1.Add(newTodo);
                break;
            case 2:
                TodoList2.Add(newTodo);
                break;
            case 3:
                TodoList3.Add(newTodo);
                break;
        }
    }

   public void RemoveTodo(TodoItem todo)
{
    TodoList1.Remove(todo);
    TodoList2.Remove(todo);
    TodoList3.Remove(todo);
}


    public void StartDrag(TodoItem todo)
    {
        draggedTodoItem = todo;
    }

    public void DropTodoItem(int targetListNumber)
    {
        if (draggedTodoItem != null)
        {
            TodoList1.Remove(draggedTodoItem);
            TodoList2.Remove(draggedTodoItem);
            TodoList3.Remove(draggedTodoItem);

            switch (targetListNumber)
            {
                case 1:
                    TodoList1.Add(draggedTodoItem);
                    break;
                case 2:
                    TodoList2.Add(draggedTodoItem);
                    break;
                case 3:
                    TodoList3.Add(draggedTodoItem);
                    break;
            }
            draggedTodoItem = null;
        }
    }
}

public class TodoItem
{
    public string? Text { get; set; }
    public bool IsEditing { get; set; } = false; // Håller reda på om uppgiften redigeras
    public bool ShowEditButton { get; set; } = false; // Håller reda på om "Ändra"-knappen visas
}

