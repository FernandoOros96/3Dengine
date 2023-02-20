using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Dengine
{
    public class Vertex
    {
        public float x, y, z;
        public float[,] point3D;

        public Vertex(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            point3D = new float[,] { { x }, { y }, { z } };
        }
    }
}
