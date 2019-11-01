using System.Collections.Generic;

namespace P04_Hospital
{
   public class Room
    {
        public Room()
        {
            BedsBisy = new List<string>();
        }

        public List<string> BedsBisy { get; set; }
    }
}
