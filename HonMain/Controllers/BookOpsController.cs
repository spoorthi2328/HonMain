using HonMain.Models;
using HonMain.repos;
using Microsoft.AspNetCore.Mvc;

namespace HonMain.Controllers
{
    public class BookOpsController : Controller
    {
        public readonly IRepositoryInterface _repo;
        public BookOpsController(IRepositoryInterface repo)
        {
            _repo = repo;
        }


        public async Task<IActionResult> Index()
        {
            var res = await _repo.GetBookDetails();
            return View(res);
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookDetail bookDetail)
        {
            if (ModelState.IsValid)
            {
                var res = _repo.AddBookDetail(bookDetail);
                if (res)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(bookDetail);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var res = await _repo.GetBookDetail(id);
            if (res != null)
            {
                return View(res);
            }
            return NotFound();
        }

        [HttpPost,ActionName("DeleteBook")]
        public IActionResult DeleteBookconfirm(int id)
        {
            var res = _repo.GetBookDetail(id);
            if (res!=null)
            {
                var result = _repo.DeleteBook(id);
                if(result)
                {
                    return RedirectToAction("Index");
                }
                return View(res);
            }
            return NotFound();
        }
    }
}
