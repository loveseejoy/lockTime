using LockTime.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LockTime.Service
{
    public class JobService
    {
        [DisplayName("休息时间")]
        public static void LockTimeForRest()
        {

            UtilyHttp.Post("https://oapi.dingtalk.com/robot/send?access_token=0918e1df6d3f8fd8543408ce201015e665f8a4b957e0a8e0cee806181bed0a9a", new
            {
                msgtype = "text",
                text =
                new
                {
                    content = "久坐两小时啦，起来运动一下咯~"
                }
                ,
                at = new
                {
                    atMobiles = new string[]
                {
                    "18356050905",
                }
                },
                isAtAll = true
            });
        }


        [DisplayName("早上喝茶时间")]
        public static void LockTimeForTeaMoring()
        {

            UtilyHttp.Post("https://oapi.dingtalk.com/robot/send?access_token=0918e1df6d3f8fd8543408ce201015e665f8a4b957e0a8e0cee806181bed0a9a", new
            {
                msgtype = "text",
                text =
                new
                {
                    content = "早上喝茶时间到咯~"
                }
                ,
                at = new
                {
                    atMobiles = new string[]
                {
                    "18356050905",
                }
                },
                isAtAll = true
            });
        }

        [DisplayName("中午喝茶时间")]
        public static void LockTimeForTeaAfternoon()
        {

            UtilyHttp.Post("https://oapi.dingtalk.com/robot/send?access_token=0918e1df6d3f8fd8543408ce201015e665f8a4b957e0a8e0cee806181bed0a9a", new
            {
                msgtype = "text",
                text =
                new
                {
                    content = "中午喝茶时间到咯~"
                }
                ,
                at = new
                {
                    atMobiles = new string[]
                {
                    "18356050905",
                }
                },
                isAtAll = true
            });
        }

        [DisplayName("晚上喝茶时间")]
        public static void LockTimeForTeaEving()
        {

            UtilyHttp.Post("https://oapi.dingtalk.com/robot/send?access_token=0918e1df6d3f8fd8543408ce201015e665f8a4b957e0a8e0cee806181bed0a9a", new
            {
                msgtype = "text",
                text =
                new
                {
                    content = "晚上喝茶时间到咯~"
                }
                ,
                at = new
                {
                    atMobiles = new string[]
                {
                    "18356050905",
                }
                },
                isAtAll = true
            });
        }
    }
}
