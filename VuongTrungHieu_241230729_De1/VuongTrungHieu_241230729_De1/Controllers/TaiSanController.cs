using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VuongTrungHieu_241230729_De1.Models;

namespace VuongTrungHieu_241230729_De1.Controllers
{
    public class TaiSanController : Controller
    {
        private readonly QLTaiSanContext _db;
        public TaiSanController(QLTaiSanContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.DsLoai = new SelectList(_db.LoaiTaiSans, "MaLoai", "TenLoai");
            return View();
        }
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
