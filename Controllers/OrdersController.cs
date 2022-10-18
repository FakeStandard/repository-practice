using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using repository_practice;
using repository_practice.DAL;
using repository_practice.Models;

namespace repository_practice.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IRepository<Order> _repository;

        public OrdersController(IRepository<Order> repository)
        {
            _repository = repository;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(_repository.Get());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            return View(_repository.GetByID(id));
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,Via,Freight,Name,Address,City,Region,PostalCode,Country")] Order order)
        {
            _repository.Insert(order);
            _repository.Save();

            return RedirectToAction(nameof(Index));
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var order = _repository.GetByID(id);

            return order is null ? NotFound() : View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,Via,Freight,Name,Address,City,Region,PostalCode,Country")] Order order)
        {
            _repository.Update(order);
            _repository.Save();

            return RedirectToAction(nameof(Index));
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var order = _repository.GetByID(id);

            return order is null ? NotFound() : View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = _repository.GetByID(id);

            if (order is not null)
                _repository.Delete(id);

            _repository.Save();

            return RedirectToAction(nameof(Index));
        }
    }
}
