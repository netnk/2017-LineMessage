using System.Collections.Generic;



    public class Message
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class image
    {
        public string type { get; set; }
        public string originalContentUrl { get; set; }
        public string previewImageUrl { get; set; }
    }

    public class sticker
    {
        public string type { get; set; }
        public string packageId { get; set; }
        public string stickerId { get; set; }
    }

public class RootObjectText
    {
        public string to { get; set; }
        public List<Message> messages { get; set; }
    }

    public class RootObjectImage
    {
        public string to { get; set; }
        public List<image> messages { get; set; }
    }

    public class RootObjectSticker
    {
        public string to { get; set; }
        public List<sticker> messages { get; set; }
    }

    public class RootObjectGroupSend
    {
        public List<string> to { get; set; }
        public List<Message> messages { get; set; }
    }
