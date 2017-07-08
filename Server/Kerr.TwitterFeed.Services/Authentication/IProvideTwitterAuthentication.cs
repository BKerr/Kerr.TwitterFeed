namespace Kerr.TwitterFeed.Services.Authentication
{
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
        IAuthorizer GetApplicationOnlyAuthorizer();

        #endregion
    }
}