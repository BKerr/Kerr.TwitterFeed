namespace Kerr.TwitterFeed.Utilities
{
    using System.Configuration;
    using System.Threading.Tasks;

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
        public async Task<IAuthorizer> GetApplicationOnlyAuthorizer()
        {
            var authorizer = new ApplicationOnlyAuthorizer
                {
                    CredentialStore = new InMemoryCredentialStore
                                          {
                                              ConsumerKey = ConfigurationManager.AppSettings[ApplicationKey.TwitterConsumerKey],
                                              ConsumerSecret = ConfigurationManager.AppSettings[ApplicationKey.TwitterConsumerSecret]
                                          }
                };

            await authorizer.AuthorizeAsync();
                
            return authorizer;
        }

        #endregion
    }
}