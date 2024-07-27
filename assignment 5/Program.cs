using System.Threading.Channels;

namespace assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region question 1



            int x1;
            int y1;
            int z1;
            int x2;
            int y2;
            int z2;


            do
            {

                Console.WriteLine("enter the x coordinate of p1");


            } while (!int.TryParse(Console.ReadLine(), out x1));

            do
            {

                Console.WriteLine("enter the y coordinate of p1");


            } while (!int.TryParse(Console.ReadLine(), out y1));

            do
            {

                Console.WriteLine("enter the z coordinate of p1");


            } while (!int.TryParse(Console.ReadLine(), out z1));

            do
            {

                Console.WriteLine("enter the x coordinate of p2");


            } while (!int.TryParse(Console.ReadLine(), out x2));

            do
            {

                Console.WriteLine("enter the y coordinate of p2");


            } while (!int.TryParse(Console.ReadLine(), out y2));

            do
            {

                Console.WriteLine("enter the z coordinate of p2");


            } while (!int.TryParse(Console.ReadLine(), out z2));

            Point3D p1 = new Point3D(x1, y1, z1);
            Point3D p2 = new Point3D(x2, y2, z2);
            Console.WriteLine(p1);
            Console.WriteLine(p2);



            Point3D.areEqual(p1, p2); // does not work properly as it compares the reference not the content if we need it to work properly we will need to overload the operator (==)


            Point3D[] point3Ds = new Point3D[]
            {
                 new Point3D(30,25,80),
                 new Point3D(250,48,140),
                 new Point3D(97,78,450),
                 new Point3D(30 ,35,811),
                 new Point3D(340,254,815),
                 new Point3D(130,55,700),
                 new Point3D(430,125,800),

            };

            for (int i = 0; i < point3Ds.Length; i++)
            {
                for (int j = 0; j < point3Ds.Length - 1 - i; j++)
                {
                    if (point3Ds[j].CompareTo(point3Ds[j + 1]) > 0)
                    {
                        Point3D.swab(ref point3Ds[j], ref point3Ds[j + 1]);
                    }

                }
            }

            foreach (Point3D point3D in point3Ds)
            {
                Console.WriteLine(point3D);
            }

            Point3D p3 = (Point3D)p1.Clone();
            Console.WriteLine(p3);
            #endregion

            #region question 2

            Console.WriteLine(Maths.add(5, 4));
            Console.WriteLine(Maths.subtract(5, 4));
            Console.WriteLine(Maths.multiply(5, 4));
            Console.WriteLine(Maths.divide(5, 4));

            #endregion
            #region question 3


            Duration duration = new Duration(666);
            Console.WriteLine(duration.ToString());
            #endregion
        }
    }
}
