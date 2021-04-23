using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealtorApp.Data;
using RealtorApp.Models;
namespace RealtorApp.Controllers
{
    public class PropertyController : Controller
    {
        private readonly PropertyContext _context;

        public PropertyController(PropertyContext context)
        {
            _context = context;
        }

        // GET: Property
        public async Task<IActionResult> Index(string dropDownVal, string searchString)
        {
            var properties = from m in _context.Property
                                select m;
            Console.WriteLine($"drop down val {dropDownVal} search string: {searchString}");
            if (!String.IsNullOrEmpty(searchString))
            {
                int match = 0;
                try 
                {
                    match = Int32.Parse(searchString);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                switch(dropDownVal)
                {
                    case "YearBuilt":
                        properties = properties.Where(s => s.YearBuilt == match);
                        break;
                    case "Address":
                        properties = properties.Where(s => s.Address.Contains(searchString));
                        break;
                    case "City":
                        properties = properties.Where(s => s.City.Contains(searchString));
                        break;
                    case "Zip": 
                        properties = properties.Where(s => s.Zip == match);
                        break;
                    case "Price": 
                        decimal decimalMatch = 0;
                        try 
                        {
                            decimalMatch = Decimal.Parse(searchString);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        properties = properties.Where(s => s.Price == decimalMatch);
                        break;
                    case "PropertType": 
                        properties = properties.Where(s => s.PropertyType.Contains(searchString));
                        break;
                    case "SquareFeet": 
                        properties = properties.Where(s => s.SquareFeet == match);
                        break;
                    case "Bedrooms": 
                        properties = properties.Where(s => s.Bedrooms == match);
                        break;
                    case "Bathrooms": 
                        double doubleMatch = 0;
                        try 
                        {
                            doubleMatch = Double.Parse(searchString);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        properties = properties.Where(s => s.Bathrooms == doubleMatch);
                        break;
                    case "GarageCapacity": 
                        doubleMatch = 0;
                        try 
                        {
                            doubleMatch = Double.Parse(searchString);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        properties = properties.Where(s => s.GarageCapacity == doubleMatch);
                        break;
                    default:
                        break;
                }
            }
            
            return View(await properties.ToListAsync());
        }

        // GET: Property/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Property
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // GET: Property/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Property/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Price,Address,City,Zip,YearBuilt,PropertyType,SquareFeet,Bedrooms,Bathrooms,GarageCapacity,RelatorName,RelatorPhone,RelatorEmail")] Property @property)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@property);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@property);
        }

        // GET: Property/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Property.FindAsync(id);
            if (@property == null)
            {
                return NotFound();
            }
            return View(@property);
        }

        // POST: Property/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Price,Address,City,Zip,YearBuilt,PropertyType,SquareFeet,Bedrooms,Bathrooms,GarageCapacity,RelatorName,RelatorPhone,RelatorEmail")] Property @property)
        {
            if (id != @property.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@property);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertyExists(@property.Id))
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
            return View(@property);
        }

        // GET: Property/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @property = await _context.Property
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@property == null)
            {
                return NotFound();
            }

            return View(@property);
        }

        // POST: Property/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @property = await _context.Property.FindAsync(id);
            _context.Property.Remove(@property);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyExists(int id)
        {
            return _context.Property.Any(e => e.Id == id);
        }
    }
}
