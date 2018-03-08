// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.News.Archive.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Archive
    {
        /// <summary>
        /// Initializes a new instance of the Archive class.
        /// </summary>
        public Archive()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Archive class.
        /// </summary>
        public Archive(string id = default(string), Collection collection = default(Collection), string title = default(string), System.DateTimeOffset? dateReleased = default(System.DateTimeOffset?), string ministryText = default(string), string htmlContent = default(string), string textContent = default(string), string preview = default(string), string body = default(string))
        {
            Id = id;
            Collection = collection;
            Title = title;
            DateReleased = dateReleased;
            MinistryText = ministryText;
            HtmlContent = htmlContent;
            TextContent = textContent;
            Preview = preview;
            Body = body;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "collection")]
        public Collection Collection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dateReleased")]
        public System.DateTimeOffset? DateReleased { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ministryText")]
        public string MinistryText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "htmlContent")]
        public string HtmlContent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "textContent")]
        public string TextContent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "preview")]
        public string Preview { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

    }
}
