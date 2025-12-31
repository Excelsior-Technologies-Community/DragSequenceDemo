using DragSequenceDemo.Data;
using Microsoft.AspNetCore.Mvc;

namespace DragSequenceDemo.Controllers
{
    public class DragController : Controller
    {
        private readonly AppDbContext _db;
        public DragController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Items.OrderBy(x => x.Sequence).ToList());
        }

        [HttpPost]
        public IActionResult SaveOrder(int[] ids)
        {
            for (int i = 0; i < ids.Length; i++)
                _db.Items.Find(ids[i]).Sequence = i + 1;

            _db.SaveChanges();
            return Ok();
        }

    }
}
