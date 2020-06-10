using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class Comment
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("reply_id")]
        public long ReplyId { get; set; }

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("multi")]
        public object[] Multi { get; set; }

        [JsonProperty("ctime")]
        public long Ctime { get; set; }

        [JsonProperty("like_count")]
        public long LikeCount { get; set; }

        [JsonProperty("user_liked")]
        public bool UserLiked { get; set; }

        [JsonProperty("at_users")]
        public object[] AtUsers { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("uname")]
        public string Uname { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("utags")]
        public object[] Utags { get; set; }

        [JsonProperty("value_user")]
        public long ValueUser { get; set; }

        [JsonProperty("vu_description")]
        public string VuDescription { get; set; }

        [JsonProperty("rights")]
        public Right[] Rights { get; set; }

        [JsonProperty("relation")]
        public long Relation { get; set; }

        [JsonProperty("comment_to_user_id")]
        public long CommentToUserId { get; set; }

        [JsonProperty("comment_to_comment_id")]
        public long CommentToCommentId { get; set; }
    }
}
