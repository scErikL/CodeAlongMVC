using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeAlongMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Isbn { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }
        /*prop
        public int MyProperty { get; set; }

        //propg
        public int MyProperty { get; private set; }

        //propfull
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }*/

        
    }
}