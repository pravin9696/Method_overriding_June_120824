using nsp1;

namespace nsp1
{

    public class classP
    {
        public int x;
        public int y;
        public void display()
        {
        }
       virtual  public void show()
        {
            Console.WriteLine("show from classP ####");
        }
    }
    public class classC : classP
    {
        public int z;
       override public void show()
        {
            Console.WriteLine("show from classC *******");

        }
    }
    public class classD : classP
    {
        public int z;
       override public void show()
        {
            Console.WriteLine("show from classD @@@@@");
        }
    }
}

namespace Method_overriding_June_120824
{

    internal class Program
    {
        static void Main(string[] args)
        {
            nsp1.classC obj1 = new nsp1.classC();
            //ref var= obj1 class c    obj= classC

            //obj1.x = 88;

            //obj1.show();// classC show();

            //nsp1.classP obj2 = new nsp1.classP();
            //obj2.show();

            //nsp1.classP obj3 = new nsp1.classC();///////////1
            ////ref obj3 classP(parent)  object child
            //obj3.show();//
            //obj3 = new nsp1.classD(); /////////////////2
            //obj3.show();

            //obj3 = new nsp1.classP();/////////////////3

            //obj3.show();
            classP objP = new classP();
            classC objC = new classC();
            classD objD = new classD();
            temp tt = new temp();
            tt.callShow(objP);
            tt.callShow(objC);
            tt.callShow(objD);

        }
    }

}
