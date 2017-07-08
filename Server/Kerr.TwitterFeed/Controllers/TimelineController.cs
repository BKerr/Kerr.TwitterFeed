namespace Kerr.TwitterFeed.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    using Kerr.TwitterFeed.Services.Endpoints;
    using Kerr.TwitterFeed.Shared.Domain;

    /// <summary>
    ///     The timeline controller.
    /// </summary>
    public class TimelineController : ApiController
    {
        #region ///  Fields  ///

        /// <summary>
        ///     The timeline service.
        /// </summary>
        private readonly ITimelineService timelineService;

        #endregion

        #region ///  Constructors  ///

        /// <inheritdoc />
        public TimelineController(ITimelineService timelineService)
        {
            this.timelineService = timelineService;
        }

        #endregion

        #region ///  Methods  ///

        /// <summary>
        ///     The get.
        /// </summary>
        /// <param name="id">
        ///     The id.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task<IEnumerable<Tweet>> Get(string id)
        {
            var tweets = await this.timelineService.GetTimelineAsync(id, 10);

            return tweets;
        }

        #endregion
    }
}