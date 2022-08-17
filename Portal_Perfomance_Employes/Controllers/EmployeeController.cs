﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalPerfomanceEmployees.Data;
using PortalPerfomanceEmployees.Models;

namespace PortalPerfomanceEmployees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            return Ok(await _context.Employees.ToListAsync());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var emp = await _context.Employees
                .FirstOrDefaultAsync(e => e.Id == id);
            return emp == null ? NotFound("Employee with that ID was not found") : Ok(emp) ;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Ok(await GetEmployees());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(Employee employee, int id)
        {
            var EmployeeToUpdate = await _context.Employees
                .FirstOrDefaultAsync(e => e.Id == id);
            if (EmployeeToUpdate == null) return NotFound("Employee with that ID was not found");
            EmployeeToUpdate.Name = employee.Name;
            EmployeeToUpdate.Age = employee.Age;
            EmployeeToUpdate.Level = employee.Level;
            await _context.SaveChangesAsync();
            return Ok(await GetEmployees());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var EmployeeToDelete = await _context.Employees
                .FirstOrDefaultAsync(e => e.Id == id);
            if (EmployeeToDelete == null) return NotFound("Employee with that ID was not found");
            _context.Employees.Remove(EmployeeToDelete);
            await _context.SaveChangesAsync();
            return Ok(await GetEmployees());
        }
    }
}