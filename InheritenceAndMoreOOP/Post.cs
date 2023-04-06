using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndMoreOOP
{
    internal class Post
    {
        private static int currentPostId;

        //properties
        //protect means that it can only be used by this class and classed derived from this class
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //default constructor. If a derived class does not invoke a base class constructor explicity, the default constructor is called implicity
        //this is a default constructor, just incase the child dos not have a constructor
        public Post()
        {
            this.ID = 0;
            this.Title = "My First Post";
            this.IsPublic = true;
            this.SendByUsername = "Jade Hendricks";
        }

        //instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = this.GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //virtual method override of the toString method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
