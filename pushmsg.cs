using System;
using System.Collections.Generic;
using System.Web;
using System.Net;
using Newtonsoft.Json;
using LineMessage;

namespace LineMessage
{
    public class pushmsg
    {
        //push url：https://api.line.me/v2/bot/message/push
        //Multicast url：https://api.line.me/v2/bot/message/multicast
        //Authkey：12345
        //userid：12345
        public string pushtext(string authkey,string userid,string msg)  //send message 
        {
            string url = string.Format(@"https://api.line.me/v2/bot/message/push");
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Set("Content-Type", "application/json");
                wc.Headers.Set("Authorization", "Bearer " + authkey);
                List<Message> lm = new List<Message>();
                lm.Add(new Message()
                {
                    type = "text",
                    text = msg
                });
                RootObjectText result = new RootObjectText()
                {
                    to = userid,
                    messages = lm
                };
                string json = JsonConvert.SerializeObject(result);
                wc.Encoding = System.Text.Encoding.UTF8;  //用web client 有編碼的問題，要轉換
                string state = wc.UploadString(url, json);
                return state;
            }
        }

        public string pushimg(string authkey,string userid,string imgurl)  //send img , only HTTPS
        {
            string url = string.Format(@"https://api.line.me/v2/bot/message/push");
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Set("Content-Type", "application/json");
                wc.Headers.Set("Authorization", "Bearer " + authkey);
                List<image> lm = new List<image>();
                lm.Add(new image()
                {
                    type = "image",
                    originalContentUrl = imgurl,
                    previewImageUrl = imgurl
                });
                RootObjectImage result = new RootObjectImage()
                {
                    to = userid,
                    messages = lm
                };
                string json = JsonConvert.SerializeObject(result);
                wc.Encoding = System.Text.Encoding.UTF8;  //用web client 有編碼的問題，要轉換
                string state = wc.UploadString(url, json);
                return state;
            }
        }
       
        public string pushsticker(string authkey,string userid,string packid,string stickid)  //push sticker
        {
            // https://devdocs.line.me/files/sticker_list.pdf  Sticker Code Reference

            string url = string.Format(@"https://api.line.me/v2/bot/message/push");
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Set("Content-Type", "application/json");
                wc.Headers.Set("Authorization", "Bearer " + authkey);
                List<sticker> lm = new List<sticker>();
                lm.Add(new sticker()
                {
                    type = "sticker",
                    packageId = packid,
                    stickerId = stickid
                    
                });
                RootObjectSticker result = new RootObjectSticker()
                {
                    to = userid,
                    messages = lm
                };
                string json = JsonConvert.SerializeObject(result);
                wc.Encoding = System.Text.Encoding.UTF8;  //用web client 有編碼的問題，要轉換
                string state = wc.UploadString(url, json);
                return state;
            }
        }

        public string grouppushtext(string authkey,string[] userid,string msg)  //group send message
        {
            string url = string.Format(@"https://api.line.me/v2/bot/message/multicast");
            using (WebClient wc = new WebClient())
            {                
                wc.Headers.Set("Content-Type", "application/json");
                wc.Headers.Set("Authorization", "Bearer " + authkey);              
                List<string> ls = new List<string>(userid);
                List<Message> lm = new List<Message>();
                lm.Add(new Message()
                {
                    type = "text",
                    text = msg
                });
                
                RootObjectGroupSend result = new RootObjectGroupSend()
                {
                    to = ls,
                    messages = lm
                };
                string json = JsonConvert.SerializeObject(result);
                wc.Encoding = System.Text.Encoding.UTF8;  //用web client 有編碼的問題，要轉換
                string state = wc.UploadString(url, json);
                return state;
            }
        }

    }
}
