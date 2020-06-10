using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class ItemDetail
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("uname")]
        public string Uname { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("odin_uid")]
        public string OdinUid { get; set; }

        [JsonProperty("value_user")]
        public long ValueUser { get; set; }

        [JsonProperty("vu_description")]
        public string VuDescription { get; set; }

        [JsonProperty("follow_state")]
        public FollowState FollowState { get; set; }

        [JsonProperty("rights")]
        public Right[] Rights { get; set; }

        [JsonProperty("ctime")]
        public long Ctime { get; set; }

        [JsonProperty("type")]
        public ItemDetailType Type { get; set; }

        //
        [JsonProperty("title")]
        public string Title { get; set; }

        //
        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("plain")]
        public string Plain { get; set; }

        [JsonProperty("word_count")]
        public long WordCount { get; set; }

        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Cover { get; set; }

        [JsonProperty("multi")]
        public Multi[] Multi { get; set; }

        [JsonProperty("pic_num")]
        public long PicNum { get; set; }

        [JsonProperty("work")]
        public string Work { get; set; }

        [JsonProperty("wid", NullValueHandling = NullValueHandling.Ignore)]
        public long? Wid { get; set; }

        [JsonProperty("real_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RealName { get; set; }

        [JsonProperty("work_cover", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkCover { get; set; }

        [JsonProperty("post_tags")]
        public PostTag[] PostTags { get; set; }

        [JsonProperty("like_count")]
        public long LikeCount { get; set; }

        [JsonProperty("user_liked")]
        public bool UserLiked { get; set; }

        [JsonProperty("reply_count")]
        public long ReplyCount { get; set; }

        [JsonProperty("share_count")]
        public long ShareCount { get; set; }

        //
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public Group Group { get; set; }

        [JsonProperty("props")]
        public Prop[] Props { get; set; }

        [JsonProperty("replies")]
        public object[] Replies { get; set; }

        [JsonProperty("visible_level")]
        public long VisibleLevel { get; set; }

        [JsonProperty("user_favored")]
        public bool UserFavored { get; set; }

        [JsonProperty("image_list")]
        public ImageList[] ImageList { get; set; }

        //
        [JsonProperty("top_list_detail", NullValueHandling = NullValueHandling.Ignore)]
        public TopListDetail TopListDetail { get; set; }

        [JsonProperty("extra_properties")]
        public ExtraProperties ExtraProperties { get; set; }

        [JsonProperty("selected_status")]
        public long SelectedStatus { get; set; }

        [JsonProperty("selected_comment")]
        public string SelectedComment { get; set; }

        [JsonProperty("editor_status")]
        public EditorStatus EditorStatus { get; set; }

        //
        [JsonProperty("post_in_set", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PostInSet { get; set; }

        [JsonProperty("view_count")]
        public long ViewCount { get; set; }

        //
        [JsonProperty("set_data", NullValueHandling = NullValueHandling.Ignore)]
        public SetData SetData { get; set; }

        //
        [JsonProperty("video_info", NullValueHandling = NullValueHandling.Ignore)]
        public VideoInfo VideoInfo { get; set; }

        [JsonProperty("repostable")]
        public bool Repostable { get; set; }

        [JsonProperty("repost_count")]
        public long RepostCount { get; set; }

        //
        [JsonProperty("highlight_circle")]
        public HighlightCircle[] HighlightCircle { get; set; }

        //
        [JsonProperty("at_user_infos", NullValueHandling = NullValueHandling.Ignore)]
        public AtUserInfo[] AtUserInfos { get; set; }

        //
        [JsonProperty("collection", NullValueHandling = NullValueHandling.Ignore)]
        public Collection Collection { get; set; }

        [JsonProperty("visible_status")]
        public long VisibleStatus { get; set; }

        [JsonProperty("visible_status_msg")]
        public string VisibleStatusMsg { get; set; }
    }
}
