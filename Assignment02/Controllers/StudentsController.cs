using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab4.Data;
using Lab4.Models;
using Lab4.Models.ViewModels;

namespace Lab4.Controllers
{
    public class StudentsController : Controller
    {
        private readonly SchoolCommunityContext _context;

        public StudentsController(SchoolCommunityContext context)
        {
            _context = context;
        }

        // GET: Students
        public async Task<IActionResult> Index(int Id)
        {
            CommunityViewModel communityViewModel = new CommunityViewModel();

            communityViewModel.Students = await _context.Students
                .Include(i => i.CommunityMemberships)
                .ThenInclude(i => i.Community)
                .AsNoTracking()
                .ToListAsync();

            if (Id != 0)
            {
                ViewData["StudentID"] = Id;
                communityViewModel.CommunityMemberships = communityViewModel.Students.Where(i => i.Id == Id).Single().CommunityMemberships;
            }

            return View(communityViewModel);
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LastName,FirstName,EnrollmentDate")] Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LastName,FirstName,EnrollmentDate")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }

        // GET: Students/EditMemberships/5
        // get detail Membership values for detail area of index page
        public async Task<IActionResult> EditMemberships(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            else
            {
                CommunityViewModel communityViewModel = new CommunityViewModel();

                communityViewModel.CommunityMemberships = await _context.CommunityMemberships
                                    .Where(cm => cm.StudentId == id)
                                    .AsNoTracking()
                                    .ToListAsync();
                communityViewModel.Students = await _context.Students
                                    .Where(s => s.Id == id)
                                    .AsNoTracking()
                                    .ToListAsync();
                communityViewModel.Communities = await _context.Communities 
                                    .AsNoTracking()
                                    .ToListAsync();

                return View(communityViewModel);
            }
        }

        // GET: Students/Unregister/5
        // get student id and community id and remove row from table
        public async Task<IActionResult> Unregister(int StudentId, string CommunityId)
        {
            var removeRow = new CommunityMembership { StudentId = StudentId, CommunityId = CommunityId };

            _context.CommunityMemberships.Remove(removeRow);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        // GET: Students/Register/5
        // get student id and community id and add row from table
        public async Task<IActionResult> Register(int StudentId, string CommunityId)
        {
            var addRow = new CommunityMembership { StudentId = StudentId, CommunityId = CommunityId };

            _context.CommunityMemberships.Add(addRow);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
