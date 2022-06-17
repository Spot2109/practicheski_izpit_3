using DataLayer;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer
{
    public static class DBContextManager
    {
        public static BookContext GetBookContext() => new BookContext();
        public static UserContext GetUserContext() => new UserContext();
        public static AuthorContext GetAuthorContext() => new AuthorContext();

    }
}