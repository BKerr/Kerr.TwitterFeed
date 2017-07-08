namespace Kerr.TwitterFeed.Controllers
{
    using System.Threading.Tasks;
    using System.Web.Http;

    using Kerr.TwitterFeed.Services.Endpoints.Interfaces;
    using Kerr.TwitterFeed.Shared.Domain;

    /// <summary>
    ///     The user controller.
    /// </summary>
    public class UserController : ApiController
    {
        #region ///  Fields  ///

        /// <summary>
        ///     The user service.
        /// </summary>
        private readonly IUserService userService;

        #endregion

        #region ///  Constructors  ///

        /// <summary>
        ///     Initializes a new instance of the <see cref="UserController" /> class.
        /// </summary>
        /// <param name="userService">
        ///     The user service.
        /// </param>
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        #endregion

        #region ///  Methods  ///

        /// <summary>
        ///     The get.
        /// </summary>
        /// <param name="id">
        ///     The id.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task<User> Get(string id)
        {
            var user = await this.userService.GetUser(id);

            return user;
        }

        #endregion
    }
}