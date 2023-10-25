namespace Search.API.Models
{
    /// <summary>
    /// This user model contains all user properties and required user methods
    /// </summary>
    public class User
    {
        #region PUBLIC PROPERTIES

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }

        #endregion PUBLIC PROPERTIES
    }
}