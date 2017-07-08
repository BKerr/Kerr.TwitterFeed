namespace Kerr.TwitterFeed.Shared.Domain
{
    /// <summary>
    ///     The user.
    /// </summary>
    public class User
    {
        #region ///  Properties  ///

        /// <summary>
        ///     Gets or sets the background image url.
        /// </summary>
        public string BackgroundImageUrl { get; set; }

        /// <summary>
        ///     Gets or sets the banner url.
        /// </summary>
        public string BannerUrl { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the favorite count.
        /// </summary>
        public int FavoriteCount { get; set; }

        /// <summary>
        ///     Gets or sets the followers count.
        /// </summary>
        public int FollowersCount { get; set; }

        /// <summary>
        ///     Gets or sets the following count.
        /// </summary>
        public int FollowingCount { get; set; }

        /// <summary>
        ///     Gets or sets the location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the tweet count.
        /// </summary>
        public int TweetCount { get; set; }

        #endregion
    }
}