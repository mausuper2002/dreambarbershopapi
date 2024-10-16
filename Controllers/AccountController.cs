using HairSalonBookingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HairSalonBookingApp.Controllers
{
    public class AccountController : Controller
    {
        // Phương thức GET để hiển thị form đăng nhập
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Phương thức POST để xử lý form đăng nhập
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Giả sử bạn có một phương thức kiểm tra đăng nhập (có thể từ cơ sở dữ liệu)
            bool isValidUser = ValidateUser(email, password);

            if (isValidUser)
            {
                // Nếu thông tin đăng nhập đúng, chuyển hướng đến trang Service
                return RedirectToAction("Index", "Service");
            }
            else
            {
                // Nếu sai, hiển thị thông báo lỗi trên view
                ViewBag.ErrorMessage = "Sai tài khoản hoặc mật khẩu.";
                return View();
            }
        }

        // Giả lập kiểm tra tài khoản (thay thế bằng truy vấn cơ sở dữ liệu)
        private bool ValidateUser(string email, string password)
        {
            if (email == "admin" && password == "123")
            {
                return true;
            }
            return false;
        }

        // Phương thức GET để hiển thị form đăng ký
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // Phương thức POST để xử lý form đăng ký
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Logic đăng ký người dùng mới, ví dụ lưu vào cơ sở dữ liệu
                // Bạn có thể thêm các kiểm tra như xác thực email, mật khẩu khớp nhau, v.v.

                return RedirectToAction("Index", "Home");
            }

            // Nếu có lỗi, trả về view với các thông báo lỗi
            return View(model);
        }

        // Phương thức GET để hiển thị form quên mật khẩu
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // Phương thức POST để xử lý yêu cầu quên mật khẩu
        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                // Logic xử lý yêu cầu đặt lại mật khẩu (gửi email reset password)
                // Ví dụ: gửi email với đường dẫn đặt lại mật khẩu

                return RedirectToAction("ForgotPasswordConfirmation");
            }

            return View();
        }

        // Phương thức GET để hiển thị trang xác nhận đã gửi email quên mật khẩu
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
        public IActionResult Index()
        {
            // Trả về view tương ứng với đường dẫn: /Views/Service/Index.cshtml
            return View();
        }
        // Phương thức xử lý Logout
        [HttpPost]
        public IActionResult Logout()
        {
            // Logic để xử lý đăng xuất, ví dụ: xóa thông tin xác thực người dùng
            // Nếu bạn sử dụng Identity: await _signInManager.SignOutAsync();

            // Chuyển hướng về trang chủ
            return RedirectToAction("Index", "Home");
        }
        public IActionResult BookingPage()
        {
            // Hiển thị trang booking
            return View();
        }
    }
}
