using System;
using System.Collections.Generic;
using System.Text;

namespace TuFarmaApp.Interfaces
{
    public interface ISQLiteDB
    {
        string GetLocalFilePath(string filename);
    }
}
