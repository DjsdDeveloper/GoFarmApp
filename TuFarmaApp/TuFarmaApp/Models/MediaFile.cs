using System;
using System.Collections.Generic;
using System.Text;
using TuFarmaApp.Interfaces;

namespace TuFarmaApp.Models
{
    public class MediaFile
    {
        public string PreviewPath { get; set; }
        public string Path { get; set; }
        public string Texto { get; set; }
        public MediaFileType Type { get; set; }
    }
}
