using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class TodoController : Controller
{
    private static List<TodoItem> todoList = new List<TodoItem>();

    public IActionResult Index()
    {
        return View(todoList);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(TodoItem todo)
    {
        todo.Id = todoList.Count + 1;
        todoList.Add(todo);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var todo = todoList.Find(t => t.Id == id);
        return View(todo);
    }

    [HttpPost]
    public IActionResult Edit(TodoItem todo)
    {
        var existingTodo = todoList.Find(t => t.Id == todo.Id);
        existingTodo.Name = todo.Name;
        existingTodo.Deadline = todo.Deadline;
        existingTodo.Status = todo.Status;
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var todo = todoList.Find(t => t.Id == id);
        return View(todo);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        var todo = todoList.Find(t => t.Id == id);
        todoList.Remove(todo);
        return RedirectToAction("Index");
    }
}
