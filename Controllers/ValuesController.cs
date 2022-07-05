using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controllers
{
   
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("api/get-all")]
        [Route("getall")]
        [Route("get-all")]
        public string GetAll()
        {
            return "Hello from get all";
        }

        [Route("api/get-all-authors")]
        public string GetAllAuthors()
        {
            return "Helllo from get All Authors";
        }

        [Route("books/{id}")]
        public string GetById(int id)
        {
            return "hello " + id;
        }

        [Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "hello author address" + id + " " + authorId;
        }

        [Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "hello from search";
        }
    }
}
