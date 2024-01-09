using Microsoft.AspNetCore.Mvc;
using WebBookStore.Models;

namespace WebBookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookrepository = null;
        public BookController()
        {
            _bookrepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            //var data=_bookrepository.GetAllBooks();
            return View();
        }
        public ViewResult GetBook(int id)
        {
            //var data=_bookrepository.GetBookById(id);
            return View();
        }
        public ViewResult SearchBooks(string bookName, string authorName)
        {
            //var data= _bookrepository.SearchBook(bookName, authorName);
            return View();
        }

    }
}
