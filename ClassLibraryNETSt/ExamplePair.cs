using System;

namespace ClassLibraryNETSt
{
    public class ExamplePair
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public ExamplePair(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }
    };
}
