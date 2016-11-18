using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN292_LAB03
{
    public class CD
    {
        #region Fields
        public string ID { get; set; }
        public string Album { get; set; }
        public string Singer { get; set; }
        public long Duration { get; set; }
        public List<string> Songs { get; set; }
        public CDGenre Genre { get; set; }
        #endregion

        public CD()
        {
            Songs = new List<string>();
        }
    }
}

public enum CDGenre
{
    Unknown, Rock, Rap, Country, Blue, Jazz, Dance
}