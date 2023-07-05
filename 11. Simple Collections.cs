// 1. Non-Generic Arraylist –
namespace A1
{
 class MyClass1
 {
 static void DisplayArray(string[] str)
 {
 foreach (string s in str)
 {
 Console.Write(s + " ");
 }
 }
 static void DisplayArray(int[] arr)
 {
 foreach (int a in arr)
 {
 Console.Write(a + " ");
 }
 }
 static void Main(string[] args)
 {
 String[] str = { "a", "b", "c" };
 int[] arr = { 1, 2, 3, 4, 5 };
 DisplayArray(str);
 DisplayArray(arr);
 }
 }
}

// 2. Non-Generic Hashtable –
namespace A1
{
 class myclass1
 {
 static void main(string[] args)
 {
 Hashtable ht = new Hashtable();
 ht.Add("ora", "oracle");
 ht.Add("vb", "vb.net");
 ht.Add("cs", "cs.net");
 ht.Add("asp", "asp.net");
 foreach (DictionaryEntry d in ht)
 {
 Console.WriteLine(d.Key + " " + d.Value);
 }
 }
 }
}

// 3. Non-Generic Stack –
namespace A1
{
 class MyClass1
 {
 static void Main(string[] args)
 {
 Stack stk = new Stack();
 stk.Push("cs.net");
 stk.Push("vb.net");
 stk.Push("asp.net");
 stk.Push("sqlserver");
 foreach (object o in stk){
 Console.WriteLine(o);
 }
 }
 }
}

// 4. Non-Generic Queue –
namespace A1
{
 class MyClass1
 {
 static void Main(string[] args)
 {
 Queue myq = new Queue();
 myq.Enqueue("cpp");
 myq.Enqueue("php");
 myq.Enqueue("c");
 myq.Enqueue("java");
 Console.WriteLine(myq.Peek());
 Console.WriteLine(myq.Count);
 }
 }
}

// 5. Non-Generic SortedList –
namespace A1
{
 class myclass1
 {
 static void main(string[] args)
 {
 SortedList sl = new SortedList();
 sl.Add("ora", "oracle");
 sl.Add("vb", "vb.net");
 sl.Add("cs", "cs.net");
 sl.Add("asp", "asp.net");
 foreach (DictionaryEntry d in sl)
 {
 Console.WriteLine(d.Key + " " + d.Value);
 }
 }
 }
}

// 6. Generic List –
namespace A1
{
 class MyClass1
 {
 static void Main(string[] args)
 {
 List<int> myl = new List<int>();
 for (int j = 5; j < 10; j++)
{
 myl.Add(j * 3);
 }
 foreach (int items in myl)
{
 Console.WriteLine(items);
 }
 }
 }
}

// 7. Generic Dictionary –
namespace A1
{
 class myclass1
 {
 static void main(string[] args)
 {
 Dictionary<int, string> dct = new Dictionary<int, 
string>();
 dct.Add(1, "cs.net");
 dct.Add(2, "vb.net");
 dct.Add(3, "vb.net");
 dct.Add(4, "vb.net");
 foreach (KeyValuePair<int, string> kvp in dct)
 {
 Console.WriteLine(kvp.Key + " " + kvp.Value);
 }
 }
 }
}

// 8. Generic SortedList –
namespace A1
{
 class myclass1
 {
 static void main(string[] args)
 {
 SortedList<string, string> sl = new SortedList<string, 
string>();
 sl.Add("ora", "oracle");
 sl.Add("vb", "vb.net");
 sl.Add("cs", "cs.net");
 sl.Add("asp", "asp.net");
 foreach (KeyValuePair<string, string> kvp in sl)
 {
 Console.WriteLine(kvp.Key + " " + kvp.Value);
 }
 }
 }
}

// 9. Generic Stack –
namespace A1
{
 class myclass1
 {
 static void main(string[] args)
 {
 Stack<string> stk = new Stack<string>();
 stk.Push("cs.net");
 stk.Push("vb.net");
 stk.Push("asp.net");
 stk.Push("sqlserver");
 foreach (string s in stk)
{
 Console.WriteLine(s);
 }
 }
 }
}

// 10. Generic Queue -
namespace A1
{
 class myclass1
 {
 static void main(string[] args)
 {
 Queue<string> q = new Queue<string>();
 q.Enqueue("cs.net");
 q.Enqueue("vb.net");
 q.Enqueue("asp.net");
 q.Enqueue("sqlserver");
 foreach (string s in q)
 {
 Console.WriteLine(s);
 }
 }
 }
}
