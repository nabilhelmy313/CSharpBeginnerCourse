char[] letters = 
    { 'N', 'a', 'b', 'i', 'l',' ', 
    'H', 'e', 'l', 'm', 'y' };
string name = "";
int[] a = new int[11];
for (int i = 0; i < letters.Length; i++)
{
    name += letters[i];
    a[i] = i + 1;
    SendMessage(name, a[i]);
}
static void SendMessage(string name, int msg)
{
    Console.WriteLine("Hello, " + name + "! Count to " + msg);
}