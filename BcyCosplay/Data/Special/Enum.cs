using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BcyCosplay.Data
{
    public enum FollowState { Havefollow, Unfollow };

    public enum EditorStatus { AllPublic, MorePublic, NomorePublic, Public };

    public enum TlType { Item };

    public enum TypeType { Empty, Image };

    public enum PostTagType { Event, Tag, Team, Work };

    public enum ImageListType { Empty, Image };

    public enum TypeSetType { Drawer, Week };

    public enum ItemDetailType { Ganswer, Note, Video };

    public enum Key { AgainCheckInfo, FirstCheckInfo, MachineReview, NoModify, NoTrans, RightClick, VideoType, WarmUp, WaterMark };

    public enum TopListName { 绘画周榜, 绘画新人榜, 绘画日榜 };

    public enum Name { 周榜, 绘画榜 };
}
