
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
    public class classC:classP
    {
      public  int z;
       override  public void show()
        {
            Console.WriteLine("show from classC *******");
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

            nsp1.classP obj3 = new nsp1.classC();
            //ref obj3 classP(parent)  object child
            obj3.show();
            //obj3.display();
          
        }
    }
    
}
