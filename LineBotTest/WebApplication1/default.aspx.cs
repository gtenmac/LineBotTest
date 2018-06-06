using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        const string channelAccessToken = "6h94g9LnHeVJ9LHD/b3bnwq1KNMiOXVeLbCtG/IjVNjnMi6zIXiDJl7+sF7NPoW+hbj5hp4pu+Fshh442TfM5QAa8nMhndeOLpLFPo/gxkQiFzrcZqyhEJqVp6hBsfNeg1uo5g+nyeJR+UrH08wyQAdB04t89/1O/w1cDnyilFU=";
        const string AdminUserId= "U99cad2819e3b6a3903ca2ee9882e58a0";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, $"測試 {DateTime.Now.ToString()} ! ");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var bot = new Bot(channelAccessToken);
            bot.PushMessage(AdminUserId, 1,2);
        }
    }
}