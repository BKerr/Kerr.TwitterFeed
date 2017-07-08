namespace Kerr.TwitterFeed.Services.Endpoints
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Kerr.TwitterFeed.Services.Authentication;
    using Kerr.TwitterFeed.Shared.Domain;

    using LinqToTwitter;

    /// <summary>
    ///     The timeline service.
    /// </summary>
    public class TimelineService : ITimelineService
    {
        #region ///  Fields  ///

        /// <summary>
        ///     The twitter authentication provider.
        /// </summary>
        private readonly IProvideTwitterAuthentication twitterAuthenticationProvider;

        #endregion

        #region ///  Constructors  ///

        /// <summary>
        ///     Initializes a new instance of the <see cref="TimelineService" /> class.
        /// </summary>
        /// <param name="twitterAuthenticationProvider">
        ///     The twitter authentication provider.
        /// </param>
        public TimelineService(IProvideTwitterAuthentication twitterAuthenticationProvider)
        {
            this.twitterAuthenticationProvider = twitterAuthenticationProvider;
        }

        #endregion

        #region ///  Methods  ///

        /// <inheritdoc />
        public async Task<IEnumerable<Tweet>> GetTimelineAsync(string screenname, int count)
        {
            var authorization = await this.GetAuthorizedSession();

            using (var twitterContext = new TwitterContext(authorization))
            {
                var tweets = await(from tweet in twitterContext.Status
                                   where tweet.Type == StatusType.User && tweet.ScreenName == screenname && tweet.Count == count
                                   select tweet).ToListAsync();

                return tweets.Select(
                                     t => new Tweet
                                              {
                                                  Id = t.StatusID,
                                                  Text = t.Text,
                                                  ScreenName = t.ScreenName,
                                                  ProfileImageUrl = t.User.ProfileImageUrl,
                                                  RetweetCount = t.RetweetCount,
                                                  Username = t.User.Name,
                                                  Favorited = t.FavoriteCount ?? 0,
                                                  CreatedAt = t.CreatedAt
                                              });
            }
        }

        /// <summary>
        /// The get authorized session.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        private async Task<IAuthorizer> GetAuthorizedSession()
        {
            var auth = this.twitterAuthenticationProvider.GetApplicationOnlyAuthorizer();
            await auth.AuthorizeAsync();

            return auth;
        }

        #endregion
    }
}