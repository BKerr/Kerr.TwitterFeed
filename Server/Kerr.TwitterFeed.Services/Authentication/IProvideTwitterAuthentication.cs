namespace Kerr.TwitterFeed.Services.Authentication
{
    using System.Threading.Tasks;

    using LinqToTwitter;

    /// <summary>
    ///     The ProvideTwitterAuthentication interface.
    /// </summary>
    public interface IProvideTwitterAuthentication
    {
        #region ///  Methods  ///

        /// <summary>
        ///     The get application only authorizer.
        /// </summary>
        /// <returns>
        ///     The <see cref="IAuthorizer" />.
        /// </returns>
        Task<IAuthorizer> GetApplicationOnlyAuthorizer();

        #endregion
    }
}