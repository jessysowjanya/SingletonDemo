using System;
namespace SingletonDemo
{
    public class Counter
    {
        public int count=0;
        private Counter()
        { }
        
        private static Counter instance;
        public static Counter getInstance()
        {
            if (instance == null)
                instance = new Counter();
            return instance;
        }
        public void Increment()
        {
            this.count++;
        }
        public void Decrement()
        {
            this.count--;
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            Counter c1=Counter.getInstance();
            Counter c2=Counter.getInstance();
            c1.Increment();
            c1.Increment();
            c1.Increment();
            c1.Increment();
            Console.WriteLine("After calling Increment Method four times, c1 count= "+c1.count);
            c1.Decrement();
            Console.WriteLine("After calling Decrement Method once, c1 count= " + c1.count);
            Console.WriteLine(" c2 count= " + c2.count);
            Console.WriteLine("Only one instance of Singleton class can be created So, c1= " +c1.count +" , c2= " +c2.count);
        }
    }
}