string s = "The quick brown fox jumps over the lazy dog";

string[] subs = s.Split(' ');

foreach (var sub in subs)
{
char[] value = sub.ToCharArray();
Array.Reverse(value);
 string result = String.Join("", value);
Console.WriteLine(result);

 }




