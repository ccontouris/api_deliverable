using System;
using Microsoft.EntityFrameworkCore;


namespace TodoApi
{
    public class TodoItemDTO

    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem) =>
    (Id, Name, IsComplete) = (todoItem.Id, todoItem.FName, todoItem.IsComplete);

}
