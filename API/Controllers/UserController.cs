using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Search.API.Controllers
{
    /// <summary>
    /// This controller has endpoints for User operations like Search etc.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        #region search_user

        /// <summary>
        /// Performs a search and returns the matched data
        /// </summary>
        /// <param name="searchStr"></param>
        /// <returns>List of Users </returns>
        // GET: api/users/search?searchStr=ja
        [HttpGet("Search")]
        public async Task<IActionResult> Search(string searchStr)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchStr))
                {
                    throw new ArgumentNullException(nameof(searchStr));
                }

                var result = _userService.SearchUser(searchStr);

                if (result == null || !result.Any())
                {
                    _logger.LogInformation($"Search string {searchStr} in user data is not found.");
                    return NotFound(searchStr);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex} - {ex.Message}");
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.InnerException);
            }
        }

        #endregion search_user
    }
}