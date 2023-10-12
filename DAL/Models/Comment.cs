﻿namespace DAL.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }

        public Post Post { get; set; }
        public User User { get; set; }
    }
}