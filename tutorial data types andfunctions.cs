// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections;
using System.Security.Cryptography.X509Certificates;

ArrayList arrayList = new ArrayList();
var arrayList2 = new ArrayList();
Queue q = new Queue();
Stack s = new Stack();
s.Push(12);
s.Push("aziz");
Console.WriteLine(s.Pop());
s.Push("hello wolrd");
q.Enqueue(s);
int[] ar = { 1, 2, 3, 4, 5, 6, 7 };

foreach (var i in ar.Reverse())
{
Console.WriteLine(i);
}
Console.WriteLine("**************************************");
arrayList2.AddRange(q);
arrayList2.AddRange(ar);
arrayList2.AddRange(s);
arrayList.Reverse();
foreach (var o in arrayList2)
{
if (string.Equals("System.Collections.Stack", Convert.ToString(o.GetType())))
{
foreach (var i in (Stack)o)
{
Console.WriteLine(i);


}
}
else
{
Console.WriteLine(o);
}


}
Console.WriteLine("count:{0}", arrayList2.Count);
Console.WriteLine("capacity:{0}", arrayList2.Capacity);
Console.WriteLine("fixed:{0}", arrayList2.IsFixedSize);
Console.WriteLine("read:{0}", arrayList2.IsReadOnly);

Console.WriteLine("0000000000000000000000000000");
Console.WriteLine(arrayList2.Contains("hello wolrd"));
arrayList2.RemoveAt(0);
arrayList2.Remove("hello wolrd");
Console.WriteLine(arrayList2.Contains("hello wolrd"));
void swap(out ArrayList a,ref ArrayList b)
{
a = b;
}
swap(out arrayList,ref arrayList2);
foreach(var i in arrayList)
{
Console.WriteLine(i);
}
ArrayList a=new ArrayList();
ArrayList b=new ArrayList();
a.AddRange(new int[] { 1, 2, 3, 4, 5, 56 });
void swap(out ArrayList a, ArrayList b)
{
a = b;
}
swap(out b, a);
foreach(var J in b)
{
Console.WriteLine(J);
}
using System;
namespace Polymorphism
{
class Animal // Base class (parent)
{
public virtual void animalSound()
{
Console.WriteLine("The animal makes a sound");
}
}
class Pig : Animal // Derived class (child)
{
public override void animalSound()
{
Console.WriteLine("The pig says: wee wee");
}
}
class Dog : Animal // Derived class (child)
{
public override void animalSound()
{
Console.WriteLine("The dog says: bow wow");
}
}
class Program
{
static void Main(string[] args)
{
Animal myAnimal = new Animal(); // Create a Animal object
Animal myPig = new Pig(); // Create a Pig object
Animal myDog = new Dog(); // Create a Dog object
myAnimal.animalSound();
myPig.animalSound();
myDog.animalSound();
}
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Keyword_Application
{
class Information
{
public int x;
public int y;
public int z;


public Information(int x,int y)
{
this.x = x;
this.y = y;
}
public Information(int x, int y, int z) : this(x,y)
{


this.z = z;
}
public void Calculate()
{
Console.WriteLine("Result is: \t" + (x + y + z));
}

}
}
namespace This_Keyword_Application
{
class Program
{
static void Main(string[] args)
{
Information I = new Information(2, 3, 4);
I.Calculate();
Console.ReadLine();
}
}
}


int fac(int x)
{
if (x == 0)
return 1;
else
return x * fac(x - 1);
Console.WriteLine(fac(5));
}


void func(int x)
{
int temp = 0;
for (int i = 2; i <= x;i ++)
{
if (x % i == 0)
{
temp = 1;
for (int j = 2; j <i; j++)
{

if (i % j == 0)
{
temp = 0;
break;
}

}
if (temp == 1)
{

while (x % i == 0)
{
Console.WriteLine(i);
x = x / i;

}
}


}
}
}
func(48);

Console.WriteLine("enter firs number");
String a=Console.ReadLine();

String c = (a.Substring(0,2)=="if")? a : ("if " + a);
Console.WriteLine(a.Remove(1,1));

bool mins(String s,int start,int fin)
{
return (start >= fin) ? true : (s[start] == s[fin]) ? mins(s, ++start, --fin) : false;
}
String  a = "azza";
Console.WriteLine(mins(a, 0, 3));
int[] v = new int[10];
v[1]= 1;
var s = new List<int>();
s.Add(1);
s.Add(2);
s.Add(3);
foreach(int k in s)
{
Console.WriteLine(k);
}

var a = new Dictionary<int, string>();
a.Add(1, "hello");
a.Add(2, "world");
a.Add(3, "insallah i will take a full mark");
//a[3] = a[3] + "hello";
//Console.WriteLine(a[3]);
Hashtable xc= new Hashtable();
xc.Add(5,"ksdo");
xc.Add(4, "kdo");
xc.Add(1, "mo");
foreach(DictionaryEntry f in xc)
{
Console.WriteLine("the key:{0} the value:{1}", f.Key,f.Value);
}

var a = new Dictionary<int, int>();
a.Add(1, 100);
a.Add(2, 200);
a.Add(3, 300);

a[1] += 76765;
Console.WriteLine(a[1]);

double f(double x)
{
    return (Math.Pow(x, 3) + x - 1);

}
double f1(double x)
{
    return ((3*Math.Pow(x, 2)) + 1) ;

}
double hata = 4;
double x0 = 1;
double it = 0.1;
double x = 0;

while (hata > it)
{
    x = x0 - (f(x0) / f1(x0));
    hata = Math.Abs(x0 - x);
    Console.WriteLine(x);
    x0 = x;

}

try
{
    int a =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a);

}
catch( Exception e)
{
    Console.WriteLine(e.Message);   
}
Console.WriteLine("enter a value");
string a = Console.ReadLine();

foreach(char g in a)
{
    if (((int)g) > 97)
    {
        Console.WriteLine("wrong input");
    }

}
int s = 1;
try
{
    if (s==1)
    {
        throw new Exception("hellow world");
    }

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
int[] aziz = new int[10];
aziz[1] = 10;
aziz.Count();

Console.WriteLine(aziz.Append(1).GetType);

foreach (int i in aziz.Append(1))
{
    Console.WriteLine(i);
}
double[] x = { 1.0, 1.5, 2.0,2.5 };
double[,] y = new double[4, 4];
y[0, 0] = 2;
y[0, 1] = 3.25;        
y[0, 2] = 5;
y[0, 3] = 7.25;

for (int i=1; i < 4; i++)
{
    for (int j=0; j < 4-i; j++)
    {
        y[i, j] = (y[i - 1, j + 1] - y[i - 1, j]) / (x[j + i] - x[j]);
        Console.Write(y[i, j] + "      ");
    }
    Console.WriteLine();
    
    
}




void first_step(ref double[,]d,int n,int i,double h, double x)
{
    if (i<n)
    {
        d[i, 0] = ((Math.Cos((x + h / Math.Pow(2, i))) - Math.Cos(x - h / Math.Pow(2, i))) / (2 * (h / Math.Pow(2, i))));
        
        first_step(ref d, n,++i, h, x);
    }

    else return;
}
void second_step(int n,int m,int k,ref double[,] d)
{
    if (n == m)
    {
        m = 0;
        n++;
    }
    if (n < k)
    {
        
        d[n, m + 1] = d[n, m] + ((d[n, m] - d[n - 1, m]) / (Math.Pow(4, m+1) - 1));
        Console.WriteLine("d("+(n+1)+","+(m+2)+")   "+d[n,m+1]);
        second_step(n, ++m, k,ref d);

    }
    else return;
}
void algo(int n, ref double[,] d, double h, double x)
{
    first_step(ref d, n, 0, h, x);
    second_step(1, 0, 3, ref d);
   
}

double[,] d = new double[3, 3]   ;
double x = 0.4;
double h = 0.1;
int n = 3;
algo(n,ref d, h, x);




public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Student(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
    public bool Equals()
    {
        return false;
    }
    public static void Main()
    {
        try
        {
            LinkedList<Student> l = new LinkedList<Student>();

            l.AddLast(new Student(1, "h"));
            l.AddLast(new Student(2, "h"));
            l.AddLast(new Student(2, "h"));

            var z = l.Where(p => p.Equals());

            foreach (var q in z)
            {
                Console.WriteLine(q);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }


}























