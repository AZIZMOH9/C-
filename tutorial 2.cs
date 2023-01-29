
string[] isims = { "aziz","ghaith","mustafa","mohammed","suhad" };
int[] numbers = { 15, 645, 23, 76, 15,86, 23, 56, 78, 99 };

var result = from number in numbers
             where number > 23
             select number;
var result1 = numbers.Where(p => p > 23);
List<IEnumerable<int>> s=new List<IEnumerable<int>>();
s.Add(result);
s.Add(result1);
foreach(IEnumerable<int> a in s)
{
    foreach(int k in a)
   {
        Console.WriteLine(k);
    }

}
var z = s.SelectMany(p=>p);
foreach(var k in z)
{
    Console.WriteLine(k);
}
var persons = generate.generating();
foreach (var z in persons)
   Console.WriteLine(z );

var resulta = from pes in persons
              where pes.id > 1
             select pes;

foreach(var t in resulta)
{
    Console.WriteLine(t);
}
Console.WriteLine("*********contains***********");
Console.WriteLine(persons.Contains(new person(12,"aziz","world")));
Console.WriteLine("////////////////*//////////////////////");
Console.WriteLine(numbers.Any(p=>p-23>0));//any()
Console.WriteLine(numbers.All(p => p - 23 > 0));//all()
Console.WriteLine("/////////*///////////////");
Console.WriteLine(persons.Any(p => p == new student(12, "aziz", "dsfsfds",2113,"cd")));
Console.WriteLine("/////////*///////////////");
Console.WriteLine(persons.All(p => p == new student(12, "aziz", "dsfsfds", 2113, "cd")));
Console.WriteLine("/////////*///////////////");
var z = isims.Where(p => p.StartsWith("a"));
foreach (string i in z)
    Console.WriteLine(i);
var kl = persons.Select(p => p).OrderBy(p=>p.first_name).ThenByDescending(p=>p.id);
foreach (var i in kl)
    Console.WriteLine(i);
Console.WriteLine("21312312312312312313132123131");
var sz = persons.Distinct();
foreach (var i in sz)
    Console.WriteLine(i);
Console.WriteLine("21312312312312312313132123131");
var ba = numbers.Distinct();
foreach (var i in ba)
    Console.WriteLine(i);
Console.WriteLine("dfsdfdsfdsfdsfdsfdsfsddsfds");
var ss = persons.Distinct();
foreach (var k in ss)
    Console.WriteLine(k);













public class person : IEquatable<person>
{
    public string first_name { get; set; }
    public string last_name { set; get; }
    public  int id { set; get; }
    
    public person(int id,string first,string last)
    {
        this.first_name = first;
        this.id = id;
        this.last_name = last;

    }
    public static bool operator ==(person obj1, person obj2)
    {
        return obj1.first_name == obj2.first_name;
    }
    public static bool operator !=(person obj1, person obj2) => !(obj1 == obj2);
    public bool equal(person o)
    {
        return this.first_name==o.first_name;
    }
    public bool Equals(person? other)=>this.equal(other);
    public virtual string get_info()
    {
        return first_name + "       " + last_name + "     " + id;
    }
    public override string ToString() => get_info();
}
class student : person
{
    private string v;

    int student_id { set; get; }
    string department { set; get; }
    public student(int id, string first, string last,int student_id,string dep) : base(id, first, last)
    {
        this.student_id = student_id;
        this.department = dep; 
    }

  
 
    public override string get_info()
    {
        return  base.get_info()+"   "+ department;

    }
    public override string ToString() =>get_info();


}

class officer : person
{
    string job;
    
    public officer(string job,int id ,string first,string last):base(id,first,last)
    {
        this.job = job;

    }

   

    public override string get_info()=>base.get_info() + "     " + job;
    
}
static class generate 
{
    public static List<person> generating()
    {
        List<person> persons = new List<person>();
        persons.Add(new person(23, "za", "mohammed"));
        persons.Add(new person(23, "za", "mohammed"));
        persons.Add(new person(32, "mustafa", "mohammed"));
        persons.Add(new person(64, "suhad", "mohammed"));
        persons.Add(new student(23, "aziz", "mohammed",1910205535,"computer engineering"));
        persons.Add(new student(23, "aziz", "mohammed", 1910205525, "machine engineering"));
        persons.Add(new student(23, "aziz", "mohammed", 1910205523, "elicitrical engineering"));
        persons.Add(new student(23, "aziz", "mohammed", 19105535, "indisturial engineering"));
        persons.Add(new officer("programmer", 22, "aziz", "mohammed"));
        return persons;

    }

}
