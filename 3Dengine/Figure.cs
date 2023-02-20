using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Dengine
{
    public class Figure
    {
        public List<Vertex> vertices;
        public List<PointF> Pts;

        private List<Vertex> verticesRotated;
        private float[,] projectedMatrix = new float[,] { { 1, 0, 0 }, { 0, 1, 0 } };
        private float[,] projectedPoints = new float[2,1];
        private float[,] rotatedPoints3D = new float[3,1];

        public Figure()
        {
            vertices = new List<Vertex>();
            verticesRotated = new List<Vertex>();
            Pts = new List<PointF>();
        }

        public void projectPoints()
        {

            for (int  p = 0; p < vertices.Count; p++)
            {
                Array.Clear(projectedPoints, 0, projectedPoints.Length);

                projectedPoints = matrixMultiply(projectedMatrix, vertices[p].point3D);

                Pts.Add(new PointF(projectedPoints[0, 0]*100/(100 - vertices[p].z), projectedPoints[1, 0] * 100 / (100 - vertices[p].z)));
            }
        }

        public void rotatePoints(float angle, int option)
        {
            float cosAngle = (float)Math.Cos(angle);
            float sinAngle = (float)Math.Sin(angle);
            int size;

            float[,] rotateMatrix = new float[3,3];

            if (option == 1)
            {
                rotateMatrix = new float[,]{{1,0, 0},
                             {0,  cosAngle,sinAngle},
                             {0,  -sinAngle, cosAngle}};
            }else if(option == 2)
            {
                rotateMatrix = new float[,]{{ cosAngle,0, sinAngle},
                                            {0, 1, 0},
                                            {-sinAngle,0, cosAngle}};
            }else if(option == 3)
            {
                rotateMatrix = new float[,]{{cosAngle,-sinAngle,0},
                                            {sinAngle,  cosAngle,0},
                                            {0, 0, 1} };
            }

            for (int p = 0; p < vertices.Count; p++)
            {
                Array.Clear(rotatedPoints3D, 0, rotatedPoints3D.Length);

                rotatedPoints3D = matrixMultiply(rotateMatrix, vertices[p].point3D);

                verticesRotated.Add(new Vertex(rotatedPoints3D[0, 0], rotatedPoints3D[1, 0],rotatedPoints3D[2, 0]));
            }

            size  = vertices.Count;
            vertices.Clear();

            for (int i = 0; i < size; i++)
            {
                vertices.Add(verticesRotated.ElementAt(i));
            }

            verticesRotated.Clear();

        }

        public float [,] matrixMultiply(float[,] matrix1, float[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                throw new ArgumentException("El número de columnas de la primera matriz debe ser igual al número de filas de la segunda matriz.");
            }

            float[,] result = new float[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    float sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }
    }
}
