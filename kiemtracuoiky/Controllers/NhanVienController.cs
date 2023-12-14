using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kiemtracuoiky.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace kiemtracuoiky.Controllers
{
    public class NhanVienController : Controller
    {
        private QLNhanVienContext db = new QLNhanVienContext();
        public IActionResult IndexNV()
        {
            return View(db.NhanVien);
        }
        public IActionResult Create()
        {
            ViewBag.ds = new SelectList(db.NhanVien.ToList(),"Mapb","Mapb");
            ViewBag.Gioitinh = new SelectList(db.NhanVien.ToList(), "Gioitinh", "Gioitinh");
            return View();
        }
        [HttpPost]
        public IActionResult Create(NhanVien a)
        {
            db.NhanVien.Add(a);
            db.SaveChanges();
            ViewBag.ds = new SelectList(db.NhanVien.ToList(), "Mapb", "Mapb");
            ViewBag.Gioitinh = new SelectList(db.NhanVien.ToList(), "Gioitinh", "Gioitinh");
            return RedirectToAction("IndexNV");
        }
    }
}