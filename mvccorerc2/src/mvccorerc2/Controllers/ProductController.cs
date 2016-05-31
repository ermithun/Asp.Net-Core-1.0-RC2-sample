using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvccorerc2.Models;

namespace mvccorerc2.Controllers
{
    //public class ProductController : Controller
    //{
    //    private readonly DataContext _context;

    //    public ProductController(DataContext context)
    //    {
    //        _context = context;    
    //    }

    //    // GET: Product
    //    public async Task<IActionResult> Index()
    //    {
    //        return View(await _context.Products.ToListAsync());
    //    }

    //    // GET: Product/Details/5
    //    public async Task<IActionResult> Details(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var product = await _context.Products.SingleOrDefaultAsync(m => m.Id == id);
    //        if (product == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(product);
    //    }

    //    // GET: Product/Create
    //    public IActionResult Create()
    //    {
    //        return View();
    //    }

    //    // POST: Product/Create
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create([Bind("Id,Name,Price,Quantity")] Product product)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Add(product);
    //            await _context.SaveChangesAsync();
    //            return RedirectToAction("Index");
    //        }
    //        return View(product);
    //    }

    //    // GET: Product/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var product = await _context.Products.SingleOrDefaultAsync(m => m.Id == id);
    //        if (product == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(product);
    //    }

    //    // POST: Product/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Quantity")] Product product)
    //    {
    //        if (id != product.Id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(product);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!ProductExists(product.Id))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction("Index");
    //        }
    //        return View(product);
    //    }

    //    // GET: Product/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var product = await _context.Products.SingleOrDefaultAsync(m => m.Id == id);
    //        if (product == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(product);
    //    }

    //    // POST: Product/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var product = await _context.Products.SingleOrDefaultAsync(m => m.Id == id);
    //        _context.Products.Remove(product);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction("Index");
    //    }

    //    private bool ProductExists(int id)
    //    {
    //        return _context.Products.Any(e => e.Id == id);
    //    }
    //}
}
