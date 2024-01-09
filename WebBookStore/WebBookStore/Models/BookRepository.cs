namespace WebBookStore.Models
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title)&&x.Author.Contains(authorName)).ToList();
        }
        // we take data from database using sql and my sql but currenty we take data from private model

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id =1, Title ="MVC", Author= "Nikita"},
                new BookModel(){Id =2, Title ="Dot Net", Author= "Pankaj"},
                new BookModel(){Id =3, Title ="Java", Author= "Megha"},
                new BookModel(){Id =4, Title ="C#", Author= "Ujjawl"},
                new BookModel(){Id =5, Title ="PHP", Author= "Anshika"},
                new BookModel(){Id =6, Title ="JavaScript", Author= "Diwan"},
                new BookModel(){Id =7, Title ="DataBase", Author= "Asha"},
            };
        }

    }
}
