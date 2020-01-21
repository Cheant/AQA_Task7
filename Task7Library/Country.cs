using System;

namespace Task7Library
{
    public class Country
    {
        public string Name { get; set; }
        public bool IsTelenorSupported { get; set; }

        public override string ToString()
        {
            if (!IsTelenorSupported)
            {
                return Name.ToString() + " - " + IsTelenorSupported.ToString() + Environment.NewLine;
            }
            else
            {
                return "";
            }
        }
    }
}
