using System;
class HelloWorld {
  static void Main() {
    int n1=0,n2=1,n3,count=10,i;
    Console.Write(n1+" "+n2);
    for(i=2;i<count;i++)
    {
        n3=n1+n2;
        Console.Write(" "+n3);
        n1=n2;
        n2=n3;
    }
}
}