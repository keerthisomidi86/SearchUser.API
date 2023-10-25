using API.Services;
using Search.API.Common.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserAPI.Tests.Users
{
    /// <summary>
    /// This class has unit tests for User searh criteria
    /// </summary>
    public class UserTests
    {
        [Theory]
        [InlineData("James")]
        public void FirstName_Mapping(string name)
        {
            var service = new UserService();

            var criteria = service.SearchUser(name);

            Assert.NotNull(criteria);
            Assert.Equal(2, criteria?.ToList().Count);
        }

        [Theory]
        [InlineData("Jam")]
        public void Email_string_Mapping(string name)
        {
            var service = new UserService();

            var criteria = service.SearchUser(name);

            Assert.NotNull(criteria);
            Assert.Equal(3, criteria?.ToList().Count);
        }

        [Theory]
        [InlineData("Katey Soltan")]
        public void First_And_Last_Names_Mapping(string name)
        {
            var service = new UserService();

            var criteria = service.SearchUser(name);

            Assert.NotNull(criteria);
            Assert.Single(criteria);
        }

        [Theory]
        [InlineData("Jasmine Duncan")]
        public void No_Match(string name)
        {
            var service = new UserService();

            var criteria = service.SearchUser(name);

            Assert.NotNull(criteria);
            Assert.Empty(criteria);
        }

        [Theory]
        [InlineData("")]
        public void No_Data_Provided(string name)
        {
            var service = new UserService();

            var criteria = service.SearchUser(name);

            Assert.Null(criteria);
        }
    }
}