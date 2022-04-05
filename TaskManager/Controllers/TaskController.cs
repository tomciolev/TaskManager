﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        private static IList<TaskModel> tasks = new List<TaskModel>()
        {
            new TaskModel(){TaskId = 1, Name = "Wizyta u mechanika", Description = "Godzina 17:00", Done = false},
            new TaskModel(){TaskId = 2, Name = "Kolacja ze znajomymi", Description = "Rynek w Krakowie, Godzina 20:00", Done = false}
        };
        // GET: TaskController
        public ActionResult Index()
        {
            return View(tasks);
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            return View(new TaskModel());
        }

        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModel taskModel)
        {
            taskModel.TaskId = tasks.Count + 1;
            tasks.Add(taskModel);
            return RedirectToAction(nameof(Index)); //przekierowywuje do akcji po nazwie akcji
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
