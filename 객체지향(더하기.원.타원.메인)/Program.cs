class my0926
{
    protected int ix;
    protected int iy;
    /* protected는 그 클래스와 재사용하는 클래스에서도 사용가능
       private는 해당 클래스에서만 사용:정보은폐
       public은 모든 클래스에서 사용*/
    public void assign(int x, int y)
    {
        ix = x;
        iy = y;
    }
    public void add()
    {
        int iresult = ix + iy;
        System.Console.WriteLine("sum=" + iresult);

    }
}
class circle : my0926
{
    protected int iradius;
    public void setradius(int iradius)
    {
        this.iradius = iradius;
    }
    public void area()
    {
        double area = 3.14 * iradius * iradius;
        System.Console.WriteLine("area=" + area);
    }

    public void move(int x, int y)
    {
        ix = ix + x;
        iy = iy + y;
        System.Console.WriteLine("afterix=" + ix);
        System.Console.WriteLine("atteriy=" + iy);
    }

}
class ellipse : circle
{

    private int radius;
    public void setradius2(int radius)
    {

        this.radius = radius;
    }
    public new void area()
    {
        double ellipsearea = 3.14 * iradius * radius;
        System.Console.WriteLine("ellipsearea=" + ellipsearea);
    }/*원래 circle클래스에 있던 area함수가 ellipse에서는 맞지가 않는다.그래서 new를 사용해서 상속받았지만 재정의했다는 의미가 있음*/



}
class day
{
    public static void Main()

    {
        my0926 my = new my0926();
        my.assign(2, 3);
        my.add();
        circle circle = new circle();
        circle.setradius(10);
        circle.assign(5, 4);
        circle.move(1, 1);
        circle.area();
        ellipse ellipse = new ellipse();
        ellipse.setradius(10);
        ellipse.setradius2(20);
        ellipse.area();



    }
}
