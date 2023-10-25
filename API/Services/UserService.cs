using API.Services.Interfaces;
using Search.API.Models;

namespace API.Services
{
    /// <summary>
    /// This service implements the User method like Search etc.
    /// </summary>
    public class UserService : IUserService
    {
        public List<User> Users { get; set; }

        public UserService()
        {
            Users = new List<User>
            {
                new User { Id = 1, FirstName = "Antony", LastName = "fitt", EmailAddress = "afitt0@a8.net", Gender = "Male" },
                new User { Id = 2, FirstName = "Katey", LastName = "Gaines", EmailAddress = "kgaines1@bbb.org", Gender = "Female" },
                new User { Id = 3, FirstName = "Ardelle", LastName = "Soames", EmailAddress = "asoames2@google.it", Gender = "Female" },
                new User { Id = 4, FirstName = "Kalila", LastName = "Tennant", EmailAddress = "ktennant3@phpbb.com", Gender = "Female" },
                new User { Id = 5, FirstName = "Veda", LastName = "Emma", EmailAddress = "vemma4@nature.com", Gender = "Female" },
                new User { Id = 6, FirstName = "Pauli", LastName = "Isacke", EmailAddress = "pisacke5@is.gd", Gender = "Female" },
                new User { Id = 7, FirstName = "Belita", LastName = "Ruoff", EmailAddress = "bruoff6@wiley.com", Gender = "Female" },
                new User { Id = 8, FirstName = "James", LastName = "kubu", EmailAddress = "jkubu7@craigslist.org", Gender = "Male" },
                new User { Id = 9, FirstName = "Jasen", LastName = "Jiroudek", EmailAddress = "jjiroudek8@google.it", Gender = "Polygender" },
                new User { Id = 10, FirstName = "Gusty", LastName = "Tuxill", EmailAddress = "gtuxill9@illinois.edu", Gender = "Male" },
                new User { Id = 11, FirstName = "James", LastName = "Pfeffer", EmailAddress = "bpfeffera@amazon.com", Gender = "Male" },
                new User { Id = 12, FirstName = "Mignonne", LastName = "Whitewood", EmailAddress = "mwhitewood@godaddy.com", Gender = "Female" },
                new User { Id = 13, FirstName = "Moselle", LastName = "Gaize", EmailAddress = "mgaizec@tumblr.com", Gender = "Female" },
                new User { Id = 14, FirstName = "Chalmers", LastName = "Longfut", EmailAddress = "clongfujam@wp.com", Gender = "Male" },
                new User { Id = 15, FirstName = "Linnell", LastName = "Jumont", EmailAddress = "ljumonte@storify.com", Gender = "Female" },
                new User { Id = 16, FirstName = "Viole", LastName = "Eaglen", EmailAddress = "veaglenf@nytimes.com", Gender = "Female" },
                new User { Id = 17, FirstName = "Sileas", LastName = "Tarr", EmailAddress = "starrg@telegraph.co.uk", Gender = "Female" },
                new User { Id = 18, FirstName = "Katey", LastName = "Soltan", EmailAddress = "ksoltanh@simplemachines.org", Gender = "Female" },
                new User { Id = 19, FirstName = "Gar", LastName = "Motion", EmailAddress = "gmotioni@shop-pro.jp", Gender = "Male" },
                new User { Id = 20, FirstName = "Kameko", LastName = "Vanes", EmailAddress = "kvanesj@discuz.net", Gender = "Female" }
            };
        }

        /// <summary>
        /// Searches for user's with matched criteria on Name(first/last) and email address
        /// </summary>
        /// <param name="nameSubstring"></param>
        /// <returns></returns>
        public IEnumerable<User> SearchUser(string nameSubstring)
        {
            if (!string.IsNullOrWhiteSpace(nameSubstring))
            {
                return Users.Where(e =>
                         (e.FirstName.ToLower() + " " + e.LastName.ToLower() + " " + e.EmailAddress.ToLower()).IndexOf(nameSubstring.ToLower()) > -1).ToList();
            }
            return null;
        }
    }
}