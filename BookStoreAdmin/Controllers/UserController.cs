using BookStoreAdmin.Objects;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAdmin.Controllers
{
    public class UserController : Controller
    {
        private readonly BookManagerContext _db;

        private readonly ILogger<HomeController> _logger;



        public UserController(ILogger<HomeController> logger, BookManagerContext db)
        {
            _db = db;
            _logger = logger;
        }
        public IActionResult Index()
        {
            IEnumerable<UserAccount> ojbUserList = _db.UserAccounts;
            return View(ojbUserList);

        }

    }
}
