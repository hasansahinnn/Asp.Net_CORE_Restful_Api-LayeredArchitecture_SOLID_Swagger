using Dal.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dal.Concrete.EntityFramework.Repository
{
    public class EfBookRepository : EfGenericRepository<Books>, IBookRepository
    {
        public EfBookRepository():base()
        {
                   
        }

        public int addBook(Books book)
        {
            throw new NotImplementedException();
        }

        public bool ChangeComment(int commentId, string comments, double starCount)
        {
            throw new NotImplementedException();
        }

        public bool deleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public Books GetBookbyId(int userId, int bookId)
        {
            try
            {
                Books book = context.Books.Where(x => x.Id == bookId).Include(x => x.Comments).FirstOrDefault(); 
                return book;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public List<Books> GetBookWithCategory(int categoryId)
        {
            try
            {
                return context.Books.Where(x => x.categoryId == categoryId).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Books GetBookWithISBN(int userId, string ISBNNumber)
        {
            try
            {
                return context.Books.FirstOrDefault(x => x.Isbn == ISBNNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Books> GetMostPopular()
        {
            throw new NotImplementedException();
        }

        public List<Books> GetMostSold()
        {
            throw new NotImplementedException();
        }

        public Books GetRandomBook()
        {
            throw new NotImplementedException();
        }

        public int MakeComment(int bookId,int userId,string comments, double starCount)
        {
            try
            {
                Comments comment = new Comments()
                {
                    booksId = bookId,
                    usersId = userId,
                    comment = comments,
                    IsActive = true,
                    PublisDate = DateTime.Now,
                    UserStarCount = starCount
                };
                context.Comments.Add(comment);
                context.SaveChanges();
                return comment.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public List<Books> SearchBook(string name)
        {
            throw new NotImplementedException();
        }
    }
}
