using System;

namespace ClassLibrary1
{
    public class DeveloperInfoAttributes

    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
        public class DeveloperInfo : Attribute
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

            public DeveloperInfo(string developerName)
            {
                this.developerName = developerName;
            }
        }
    }
}
