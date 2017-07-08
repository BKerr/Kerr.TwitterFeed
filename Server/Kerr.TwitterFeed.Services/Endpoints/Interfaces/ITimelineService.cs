namespace Kerr.TwitterFeed.Services.Endpoints
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Kerr.TwitterFeed.Shared.Domain;

    /// <summary>
    ///     The TimelineService interface.
    /// </summary>
    public interface ITimelineService
    {
        #region ///  Methods  ///

        /// <summary>
        ///     The get timeline async.
        /// </summary>
        /// <param name="screenname">
        ///     The screenname.
        /// </param>
        /// <param name="count">
        ///     The count.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<IEnumerable<Tweet>> GetTimelineAsync(string screenname, int count);

        #endregion
    }
}