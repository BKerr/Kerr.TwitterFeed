namespace Kerr.TwitterFeed.Shared.Domain
{
    /// <summary>
    ///     The tweet.
    /// </summary>
    public class Tweet
    {
        #region ///  Properties  ///

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public ulong Id { get; set; }

        /// <summary>
        ///     Gets or sets the profile image url.
        /// </summary>
        public string ProfileImageUrl { get; set; }

        /// <summary>
        ///     Gets or sets the retweet count.
        /// </summary>
        public int RetweetCount { get; set; }

        /// <summary>
        ///     Gets or sets the screen name.
        /// </summary>
        public string ScreenName { get; set; }

        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        #endregion
    }
}