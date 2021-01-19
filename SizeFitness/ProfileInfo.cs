using System;
using System.Text.Json;

namespace SizeFitness
{
    [Serializable]
    public class ProfileInfo
    {
        public string ProcessName { get; set; }

        public string Path { get; set; }

        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public bool Enable { get; set; }
    }
}
