namespace s2_zestaw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------------------------
                                Zadanie 1.
            ----------------------------------------------------*/
            
            List<int> lista = new List<int>() {3, 7, 2, 9, 1, 5, 8, 6 };
            foreach (int i in lista)
            { Console.WriteLine(i); }

            lista.Sort();

            lista.RemoveAll(x => x < 5);
            
            lista.AddRange(new int[] { 10, 11, 12, });

            var listaSuma = lista.Sum();
            var listaSrednia = lista.Average();

            Console.WriteLine($"\nSuma = {listaSuma}" +
                $"\nŚrednia = {listaSrednia}");
        }
    }
}
