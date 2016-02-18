﻿using System;

namespace Hypermedia.Sample
{
    public sealed class Post : Resource
    {
        /// <summary>
        /// The post type.
        /// </summary>
        public int PostTypeId { get; set; }

        /// <summary>
        /// The body contents for the post.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The overall score for the post.
        /// </summary>
        public int Score { get; set; }
        
        /// <summary>
        /// The number of views that the post has had.
        /// </summary>
        public int ViewCount { get; set; }

        /// <summary>
        /// The number of views that the post has had.
        /// </summary>
        public int AnswerCount { get; set; }

        /// <summary>
        /// The number of comments that the post has.
        /// </summary>
        public int CommentCount { get; set; }

        /// <summary>
        /// The number of times the post has been marked as a favourite.
        /// </summary>
        public int FavoriteCount { get; set; }

        /// <summary>
        /// The ID of the user that owns/created the post.
        /// </summary>
        public int OwnerUserId { get; set; }

        /// <summary>
        /// The user that owns/created the post.
        /// </summary>
        public User OwnerUser { get; set; }

        /// <summary>
        /// The date that the post was first created.
        /// </summary>
        public DateTimeOffset CreationDate { get; set; }
    }
}
