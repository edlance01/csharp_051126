using System;
using System.Collections.Generic;
using System.Text;

namespace com.ntier.Aviation
{
    internal class EnginePart : AirplanePart
    {
        public string? EngineType { get; set; }

        public new string GetPartInfo()
        {
            return base.GetPartInfo() + $"\nEngine Type: {EngineType}";
        }
    }
}
