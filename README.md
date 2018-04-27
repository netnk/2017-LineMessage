# 2017-LineMessage
//LINE BOT for C#


 /*
             *              
            LineMessage函數說明：

            1) pushtext()  --> 發送文字訊息
            必要參數：
                1.authkey：申請的LINE帳號會提供
                2.userid：讀者的UserId
                3.msg：所要發送的資訊文字內容

            2) pushimg()  --> 發送圖片
            必要參數：
                1.authkey：申請的LINE帳號會提供
                2.userid：讀者的UserId
                3.imgurl：圖片網址(目前只支援HTTPS的網址)

            3) pushsticker()  --> 發送貼圖
            必要參數：
                1.authkey：申請的LINE帳號會提供
                2.userid：讀者的UserId
                3.packid：貼圖參數
                4.stickid：貼圖樣式參數
            貼圖參數文件參考：https://devdocs.line.me/files/sticker_list.pdf

            4) grouppushtext()  -->群發文字訊息
            必要參數：
                1.authkey：申請的LINE帳號會提供
                2.userid：多個讀者的UserId，用陣列表示。 ["aaaaaa" , "bbbbbb" , "cccccc"]
                3.msg：所要發送的資訊文字內容
             */
