using System;

namespace Geometry
{
    public class Point3d{
        private float _x;
        private float _y;
        private float _z;
        public float X => _x;
        public float Y => _y;
        public float Z => _z;
        public Point3d(float x, float y, float z){
            _x = x;
            _y = y;
            _z = z;
        }
        public void MoveAlongX(float x){
            _x+=x;
        }

        public void CastToXY(){
            _z=0;
        }
        public bool IsOnXYPlane(){
            if(_z == 0){
                return true;
            }
            return false;
        }
        public bool IsOnAxix(){
            if((_x == 0 && _y==0 )||(_z == 0 && _y==0 )||(_x == 0 && _z==0 )){
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var point =new Point3d(1,0,0);
            point.MoveAlongX(-1);
            Console.WriteLine(point.X);
            Console.WriteLine(point.IsOnXYPlane());
            Console.WriteLine(point.IsOnAxix());
            point.CastToXY();
            Console.WriteLine(point.Z);
        }
    }
}
