using NullAbleStructEnumİndexer;

ListInt arr = new ListInt();
Console.WriteLine(arr.Contanins(2));
arr.AddRange(5, 6, 2, 56, 2, 5, 16, 62, 89);
Console.WriteLine(arr.Sum());
arr.RemoveRange(5, 6, 89, 5);
Console.WriteLine("-+++++++++++++++++++++++++++++++++++-+-++-+--+--+");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}


Console.WriteLine(arr.ToString());