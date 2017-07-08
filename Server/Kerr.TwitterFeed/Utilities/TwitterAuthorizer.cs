namespace Kerr.TwitterFeed.Utilities
{
    using System.Configuration;

    using Kerr.TwitterFeed.Services.Authentication;
    using Kerr.TwitterFeed.Shared.Constants;

    using LinqToTwitter;

    /// <summary>
    ///     The twitter authorizer.
    /// </summary>
    public class TwitterAuthorizer : IProvideTwitterAuthentication
    {
        #region ///  Methods  ///

        /// <inheritdoc />
        public IAuthorizer GetApplicationOnlyAuthorizer()
        {
            return new ApplicationOnlyAuthorizer
                       {
                           CredentialStore = new InMemoryCredentialStore
                                                 {
                                                     ConsumerKey = ConfigurationManager.AppSettings[ApplicationKey.TwitterConsumerKey],
                                                     ConsumerSecret = ConfigurationManager.AppSettings[ApplicationKey.TwitterConsumerSecret]
                                                 }
                       };
        }

        #endregion
    }
}