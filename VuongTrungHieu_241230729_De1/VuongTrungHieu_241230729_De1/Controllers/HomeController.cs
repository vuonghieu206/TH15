using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VuongTrungHieu_241230729_De1.Models;

namespace VuongTrungHieu_241230729_De1.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLTaiSanContext _db;
        public HomeController(QLTaiSanContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
           var ds= _db.TaiSans.Where(t=>t.NguyenGia!=null&&t.NguyenGia>=20).ToList();
            return View(ds);
        }
        public IActionResult TaiSanTheoLoai(int id)
        {
            var ds= _db.TaiSans.Where(t=>t.MaLoai==id).ToList();
            ViewBag.TieuDe = _db.LoaiTaiSans.Find(id)?.TenLoai;
            return PartialView("_TaiSanLoai", ds);
        }

        
    }
}
