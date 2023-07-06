namespace GenericsTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string> { };
            myDictionary.Add(1, "Deniz");
            myDictionary.Add(2, "Ayşe");
            myDictionary.Add(3, "Fulden");
            myDictionary.Add(4, "Ahsen");
            myDictionary.getWholeDict();
        }
    }
}