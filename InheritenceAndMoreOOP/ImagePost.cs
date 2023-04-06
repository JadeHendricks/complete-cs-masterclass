using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndMoreOOP
{   
    //ImagePost derices from post and adds a property (ImageURL) and two constructors
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //the following properties and GetNextId method are inherited from post
            this.ID = GetNextID();
            this.Title = title; 
            this.SendByUsername = sendByUsername;
            this.ImageURL = imageURL;
            this.IsPublic = isPublic;

            //property ImageUrl is a member of ImagePost, but not of Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {2}", this.ID, this.Title, this.ImageURL, this.SendByUsername);
        }
    }
}
