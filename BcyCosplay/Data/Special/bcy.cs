using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BcyCosplay.Data
{
    public static class bcy
    {
        public static int noneLen = 64;//低于此值，实际无返回数据


        static Uri uri = new Uri("https://bcy.net");
        static CookieContainer cookie = null;
        public static void SetCookie(string set_cookie)
        {
            if (cookie == null)
            {
                cookie = new CookieContainer();
            }
            cookie.SetCookies(uri, set_cookie);
        }

        public static void ClearCookie()
        {
            cookie = null;
        }

        //_csrf_token
        static bool csrfTokenFlag = false;
        private static string CsrfToken
        {
            get
            {
                string _csrf_token = "abcdfgh";
                if (!csrfTokenFlag)
                {
                    var c = new Cookie("_csrf_token", _csrf_token, "/", "bcy.net");
                    if (cookie == null)
                    {
                        cookie = new CookieContainer();
                    }
                    cookie.Add(c);
                    csrfTokenFlag = true;
                }
                return "_csrf_token=" + _csrf_token;
            }
        }


        private static async Task<string> HttpGet(string url)
        {
            var rq = (HttpWebRequest)WebRequest.Create(url);
            rq.Method = "Get";

            if (cookie != null)
            {
                rq.CookieContainer = cookie;
            }

            WebResponse rs = await rq.GetResponseAsync();
            var set_cookie = rs.Headers["Set-Cookie"];
            SetCookie(set_cookie);
            Stream s = rs.GetResponseStream();
            StreamReader sr = new StreamReader(s, Encoding.GetEncoding("utf-8"));
            string retString = await sr.ReadToEndAsync();
            sr.Close();
            s.Close();
            return retString;
        }


        private static async Task<string> HttpPost(string url, string data = null, bool csrf = false)
        {
            if (data == null)
            {
                data = CsrfToken;
            }
            else if (csrf)
            {
                data += "&" + CsrfToken;
            }

            var rq = (HttpWebRequest)WebRequest.Create(url);
            rq.Method = "Post";

            if (cookie != null)
            {
                rq.CookieContainer = cookie;
            }

            byte[] buf = Encoding.UTF8.GetBytes(data);
            rq.ContentLength = Encoding.UTF8.GetByteCount(data);
            var p = await rq.GetRequestStreamAsync();
            await p.WriteAsync(buf, 0, buf.Length);

            WebResponse rs = await rq.GetResponseAsync();
            var set_cookie = rs.Headers["Set-Cookie"];
            SetCookie(set_cookie);
            Stream s = rs.GetResponseStream();
            StreamReader sr = new StreamReader(s, Encoding.GetEncoding("utf-8"));
            string retString = await sr.ReadToEndAsync();
            sr.Close();
            s.Close();
            return retString;
        }


        private static string getInt(object o)
        {
            long i = 0;
            try
            {
                i = (Int32)o;
            }
            catch
            {
                i = (Int64)o;
            }
            return i.ToString();
        }

        //用户信息
        public static async Task<string> info(string uid)
        {
            string url = "https://bcy.net/apiv3/user/info?uid=" + uid;
            return await HttpGet(url);
        }


        //我的消息
        public static async Task<string> message(string isPre, int page, string pageType)
        {
            string url = "https://bcy.net/apiv3/user/message";
            string data = "isPre=" + isPre;
            data += "&page=" + page.ToString();
            data += "&pageType=" + pageType;
            return await HttpPost(url, data, true);
        }

        //公告
        public static async Task<string> pcAnnounce(string since, int limit)
        {
            string url = "https://bcy.net/apiv3/user/pcAnnounce?";
            url += "since=" + since;
            url += "&limit=" + limit.ToString();
            return await HttpGet(url);
        }


        //我创建的合集
        public static async Task<string> getMyCollectionList(string since, int sort)
        {
            string url = "https://bcy.net/apiv3/collection/getMyCollectionList?";
            url += "since=" + since;
            url += "&sort=" + sort.ToString();
            return await HttpGet(url);
        }

        //我关注的合集
        public static async Task<string> getSubscribeCollectionList(string since, int sort)
        {
            string url = "https://bcy.net/apiv3/collection/getSubscribeCollectionList?";
            url += "since=" + since;
            url += "&sort=" + sort.ToString();
            return await HttpGet(url);
        }


        //关注
        //我的关注 follow_type=0
        //我的粉丝 follow_type=1
        //互相关注 follow_type=2
        //我关注的圈子 follow_type=3
        public static async Task<string> followList(string uid, int page, int follow_type)
        {
            string url = "https://bcy.net/apiv3/user/follow-list?";
            url += "uid=" + uid;
            url += "&page=" + page.ToString();
            url += "&follow_type=" + follow_type.ToString();
            return await HttpGet(url);
        }

        //黑名单
        public static async Task<string> blockList(string uid, int page = 1, string follow_type = "0")
        {
            string url = "https://bcy.net/apiv3/user/block-list?";
            url += "uid=" + uid;
            url += "&page=" + page.ToString();
            url += "&follow_type=" + follow_type;
            return await HttpGet(url);
        }

        //加入黑名单 actionType: 1
        //移出黑名单 actionType: 2
        public static async Task<string> block(int actionType, string bid)
        {
            string url = "https://bcy.net/apiv3/user/block";
            string data = "actionType=" + actionType.ToString();
            data += "&bid=" + bid;
            return await HttpPost(url, data, true);
        }



        //用户所有发布
        public static async Task<string> selfPosts(string uid, string since)
        {
            string url = "https://bcy.net/apiv3/user/selfPosts?";
            url += "uid=" + uid;
            url += "&since=" + since;
            return await HttpGet(url);
        }

        //用户分类发布
        //图片 note
        //文字 article
        //问答 ganswer
        //视频 video
        public static async Task<string> post(string mid, int page, string ptype, string uid)
        {
            string url = "https://bcy.net/apiv3/user/post";
            string data = "mid=" + mid;
            data += "&page=" + page.ToString();
            data += "&ptype=" + ptype;
            data += "&uid=" + uid;
            return await HttpPost(url, data, true);
        }

        //用户喜欢 ptype=like
        //用户收藏 ptype=collect
        public static async Task<string> favor(string uid, string ptype, string mid, string since, int size = 35)
        {
            string url = "https://bcy.net/apiv3/user/favor?";
            url += "uid=" + uid;
            url += "&ptype=" + ptype;
            url += "&mid=" + mid;
            url += "&since=" + since;
            url += "&size=" + size.ToString();
            return await HttpGet(url);
        }

        //关注用户 opt: "dofollow"
        //取消关注 opt: "unfollow"
        public static async Task<string> follow(string fid, string opt)
        {
            string url = "https://bcy.net/apiv3/user/follow";
            string data = "fid=" + fid;
            data += "&opt=" + opt;
            return await HttpPost(url, data, true);
        }

        //私信
        //意见反馈(半次元女仆长) to_uid: 1053848
        public static async Task<string> sendmessage(string content, string to_uid)
        {
            string url = "https://bcy.net/apiv3/user/sendmessage";
            string data = "content=" + content;
            data += "&to_uid=" + to_uid;
            return await HttpPost(url, data, true);
        }

        //关注动态
        public static async Task<string> friendsFeed(string since)
        {
            string url = "https://bcy.net/apiv3/user/friendsFeed?";
            url += "since=" + since;
            return await HttpGet(url);
        }

        //发现/推荐 refer=feed  cid=null
        //
        //COS refer=channel  cid=6618800694038102275
        //绘画 refer=channel cid=6618800650505421059
        //写作 refer=channel cid=6618800677680316675
        //问答 refer=channel cid=6618029913129615630
        //
        //热门视频 refer=channel_video cid=8103
        //动漫杂谈 refer=channel_video cid=6643217672664252680
        //游戏 refer=channel_video cid=6643218469594595598
        //MAD refer=channel_video cid=6643219568665821447
        //MMD refer=channel_video cid=6643220014159626510
        //手书 refer=channel_video cid=6643220558852915464
        //影视 refer=channel_video cid=6643220861601972493
        //音乐&配音 refer=channel_video cid=6643221212145123592
        //萌宠 refer=channel_video cid=6643222302139891976
        //生活 refer=channel_video cid=6643222867930530062
        //舞蹈 refer=channel_video cid=6643688975691153672     
        public static async Task<string> getFeeds(string refer, string direction = "loadmore", string cid = null)
        {
            string url = "https://bcy.net/apiv3/common/getFeeds?";
            url += "refer=" + refer;
            url += "&direction=" + direction;
            if (cid != null)
            {
                url += "&cid=" + cid;
            }
            return await HttpGet(url);
        }

        //热门圈子
        public static async Task<string> hotCircleList(int offset)
        {
            string url = "https://bcy.net/apiv3/common/hotCircleList?";
            url += "offset=" + offset.ToString();
            return await HttpGet(url);
        }

        //榜单
        //                      周榜(sub_type=week) 日榜(sub_type=lastday) 新人榜(sub_type=newPeople)
        //1.绘画榜(ttype=illust)
        //2.COS榜(ttype=cos)
        //3.写作榜(ttype=novel)
        //
        //4.视频(ttype=video) 
        //                          三日榜duration_type=3day 周榜duration_type=week 月榜duration_type=month
        //top榜sub_type=sitetop date=null
        //新人榜sub_type=newPeople date=202001
        public static async Task<string> itemInfo(int p, string ttype, string sub_type, string duration_type = null, string date = null)
        {
            string url = "https://bcy.net/apiv3/rank/list/itemInfo?";
            url += "p=" + p.ToString();
            url += "&ttype=" + ttype;
            url += "&sub_type=" + sub_type;
            if (duration_type != null)
            {
                url += "&duration_type=" + duration_type;
            }
            if (date != null)
            {
                url += "&date=" + date;
            }
            return await HttpGet(url);
        }

        //评论
        //热度顺序 sort=hot
        //发布顺序 sort=time
        public static async Task<string> list(int page, string item_id, string sort)
        {
            string url = "https://bcy.net/apiv3/cmt/reply/list?";
            url += "page=" + page.ToString();
            url += "&item_id=" + item_id;
            url += "&sort=" + sort;
            return await HttpGet(url);
        }

        //发布评论
        //???string[] imgList
        public static async Task<string> publish(string content, string item_id)
        {
            string url = "https://bcy.net/apiv3/cmt/reply/publish";
            string data = "content=" + content;
            data += "&item_id=" + item_id;
            return await HttpPost(url, data, true);
        }

        //收藏
        public static async Task<string> collect(string item_id)
        {
            string url = "https://bcy.net/apiv3/user/collect";
            string data = "item_id=" + item_id;
            return await HttpPost(url, data, true);
        }

        //取消收藏
        public static async Task<string> uncollect(string item_id)
        {
            string url = "https://bcy.net/apiv3/user/uncollect";
            string data = "item_id=" + item_id;
            return await HttpPost(url, data, true);
        }
    }
}
