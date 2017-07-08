namespace Kerr.TwitterFeed.Services.Endpoints.Interfaces
{
    using System.Threading.Tasks;

    using Kerr.TwitterFeed.Shared.Domain;

    /// <summary>
    ///     The UserService interface.
    /// </summary>
    public interface IUserService
    {
        #region ///  Methods  ///

        /// <summary>
        ///     The get user.
        /// </summary>
        /// <param name="username">
        ///     The username.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<User> GetUser(string username);

        #endregion
    }
}