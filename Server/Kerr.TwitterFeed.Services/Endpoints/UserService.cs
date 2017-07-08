namespace Kerr.TwitterFeed.Services.Endpoints
{
    using System.Linq;
    using System.Threading.Tasks;

    using Kerr.TwitterFeed.Services.Authentication;
    using Kerr.TwitterFeed.Services.Endpoints.Interfaces;

    using LinqToTwitter;

    using User = Kerr.TwitterFeed.Shared.Domain.User;

    /// <summary>
    ///     The user service.
    /// </summary>
    public class UserService : IUserService
    {
        #region ///  Fields  ///

        /// <summary>
        ///     The twitter authentication provider.
        /// </summary>
        private readonly IProvideTwitterAuthentication twitterAuthenticationProvider;

        #endregion

        #region ///  Constructors  ///

        /// <summary>
        ///     Initializes a new instance of the <see cref="UserService" /> class.
        /// </summary>
        /// <param name="twitterAuthenticationProvider">
        ///     The twitter authentication provider.
        /// </param>
        public UserService(IProvideTwitterAuthentication twitterAuthenticationProvider)
        {
            this.twitterAuthenticationProvider = twitterAuthenticationProvider;
        }

        #endregion

        #region ///  Methods  ///

        /// <inheritdoc />
        public async Task<User> GetUser(string username)
        {
            var authorization = await this.twitterAuthenticationProvider.GetApplicationOnlyAuthorizer();

            using (var twitterContext = new TwitterContext(authorization))
            {
                var userList = await (from user in twitterContext.User
                                      where user.Type == UserType.Lookup && user.ScreenNameList == username
                                      select user).ToListAsync();

                var twitterUser = userList.First();

                return new User
                           {
                               FavoriteCount = twitterUser.FavoritesCount,
                               BackgroundImageUrl = twitterUser.ProfileBackgroundImageUrl,
                               BannerUrl = twitterUser.ProfileBannerUrl,
                               Description = twitterUser.Description,
                               FollowersCount = twitterUser.FollowersCount,
                               FollowingCount = twitterUser.FriendsCount,
                               Location = twitterUser.Location,
                               Name = twitterUser.Name,
                               TweetCount = twitterUser.StatusesCount
                           };
            }
        }

        #endregion
    }
}