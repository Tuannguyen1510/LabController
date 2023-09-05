using Lession1.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lession1.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {

            List<SanPham> sp = new List<SanPham>()
             {
                  new SanPham()
                {
                    Id = 1,
                    Name="Bộ đồ bơi cho trẻ em nam",
                    Description="Lorem",
                    TrangThai="Còn Hàng",
                    Price=35000,
                    Date="15/07/2021"
                },
                  new SanPham()
                {
                    Id = 2,
                    Name="Bộ đồ bơi cho trẻ em nữ",
                    Description="Lorem",
                    TrangThai="Còn Hàng",
                    Price=35000,
                    Date="15/07/2021"
                },
                  new SanPham()
                {
                    Id = 3,
                    Name="Bộ đồ bơi cho trẻ em từ 3-5 tuổi",
                    Description="Lorem",
                    TrangThai="Còn Hàng",
                    Price=35000,
                    Date="15/08/2021"
                }
             };
            ViewBag.SanPhams = sp;
            return View();
        }


        [Route("details", Name = "Details")]

        public IActionResult Details(int id)
        {
            List<SanPham> spDetails = new List<SanPham>()
             {
                  new SanPham()
                {
                    Id = 1,
                    Name="Bộ đồ bơi cho trẻ em nam",
                    Description="Lorem",
                    TrangThai="Còn Hàng",
                    Price=35000,
                    Date="15/07/2021"
                },
                  new SanPham()
                {
                    Id = 2,
                    Name="Bộ đồ bơi cho trẻ em nữ",
                    Description="Lorem",
                    TrangThai="Còn Hàng",
                    Price=35000,
                    Date="15/07/2021"
                },
                  new SanPham()
                {
                    Id = 3,
                    Name="Bộ đồ bơi cho trẻ em từ 3-5 tuổi",
                    Description="Lorem",
                    TrangThai="Còn Hàng",
                    Price=35000,
                    Date="15/08/2021"
                }
             };
            SanPham sanpham = spDetails.FirstOrDefault(sp => sp.Id == id);

            ViewBag.sanpham = sanpham;
            return View();
        }
    }
}
