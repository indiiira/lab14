using System;

namespace CustomAttribute
{
   

        [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class DeveloperInfoAttribute : System.Attribute
    {
            private string developerName;
            private string dateCreated;
            public string Developer
            {
                get { return developerName; }
            }
            public string Date
            {
                get { return dateCreated; }
                set { dateCreated = value; }
            }

            public DeveloperInfoAttribute(string developerName)
            {
                this.developerName = developerName;
            }
        }
    
}
