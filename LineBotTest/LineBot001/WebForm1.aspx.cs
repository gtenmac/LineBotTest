using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBot001
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private isRock.LineBot.Bot bot = new isRock.LineBot.Bot("6h94g9LnHeVJ9LHD/b3bnwq1KNMiOXVeLbCtG/IjVNjnMi6zIXiDJl7+sF7NPoW+hbj5hp4pu+Fshh442TfM5QAa8nMhndeOLpLFPo/gxkQiFzrcZqyhEJqVp6hBsfNeg1uo5g+nyeJR+UrH08wyQAdB04t89/1O/w1cDnyilFU=");
        private string UserID = "U99cad2819e3b6a3903ca2ee9882e58a0";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bot.PushMessage(UserID, "testxxxxxxxxxx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bot.PushMessage(UserID, new Uri("https://img.appledaily.com.tw/images/ReNews/20160418/640_e30054f5853ecc3409611a0f3f3ab25f.jpg"));
            bot.PushMessage(UserID, 1, 3);
        }
    }
}