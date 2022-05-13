
struct dot
{ 
    int x,y,z;
    double modulo()
    { 
        return Math.Sqrt(x*x+y*y+z*z);
    }
}