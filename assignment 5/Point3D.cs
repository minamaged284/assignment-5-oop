namespace assignment_5
{
    public class Point3D : IComparable,ICloneable
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {

        }
        public Point3D(int x,int y ,int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(int x,int y) : this(x,y,0) {}
        public Point3D(int x) : this(x, 0, 0) { }


        override public string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})"; 
        }

        public static void areEqual(Point3D a, Point3D b)
        {
            if (a == b)
            {
                Console.WriteLine("equal");
            }



            else
            {
                Console.WriteLine("not equal");
            }
        }

        public int CompareTo(object? obj)
        {

            Point3D p = (Point3D)obj;
            if (this.X > p.X)
            {
                return +1;
            }

            else if (this.X < p.X)
            {
                return -1;
            }
            else {

                if (this.Y > p.Y)
                {
                    return +1;
                }

                else if (this.Y < p.Y)
                {
                    return -1;
                }

                else return 0;
            }
        }

        public static void swab(ref Point3D a, ref Point3D b)
        {
            Point3D temp = a;
            a = b;
            b = temp;
        }

        public object Clone()
        {
            return
        new Point3D()
        {
            X = this.X,
            Y = this.Y,
            Z = this.Z
        };
        }
    }
}
