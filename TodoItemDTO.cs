using System;
using Microsoft.EntityFrameworkCore;

// namespace TodoApi
    public class TodoItemDTO
{
    public int Id { get; set; }
    public string? FName { get; set; }
    public bool IsComplete { get; set; }

    public TodoItemDTO() { }
    public TodoItemDTO(Todo todoItem) =>
    (Id, FName, IsComplete) = (todoItem.Id, todoItem.FName, todoItem.IsComplete);

}
