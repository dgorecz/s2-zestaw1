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

            /*----------------------------------------------------
                                Zadanie. 2
            ----------------------------------------------------*/

            Dictionary<string, int[]> dict = new Dictionary<string, int[]>() {
                {"Jan", new int[] {3, 4, 5} },
                {"Anna", new int[] {5, 5, 4 } },
                {"Piotr", new int[] {2, 3, 3 } } };

            foreach (var pair in dict)
            {
                Console.WriteLine($"\n{pair.Key} Oceny: ");
                foreach (var oceny in pair.Value)
                { Console.WriteLine(oceny); }

                Console.WriteLine($"Średnia: {pair.Value.Average()}");
            }
            var najlepszyStudent = dict.OrderByDescending(x => x.Value.Average()).First();
            Console.WriteLine($"Student z najlepszą średnią: {najlepszyStudent.Key}");

            /*----------------------------------------------------
                                Zadanie. 3
            ----------------------------------------------------*/

            Queue<string> klienci = new Queue<string>();
            klienci.Enqueue("Adam");
            klienci.Enqueue("Kasia");
            klienci.Enqueue("Marek");
            klienci.Enqueue("Olek");
            klienci.Enqueue("Tomek");

            Console.WriteLine(klienci.First());

            klienci.Dequeue();
            klienci.Dequeue();

            klienci.Enqueue("Paweł");
            klienci.Enqueue("Karolina");

            foreach (string klient in klienci)
            { Console.WriteLine(klient); }

            Console.WriteLine(klienci.Count());

            /*----------------------------------------------------
                                Zadanie. 4
            ----------------------------------------------------*/

            Stack<string> stack = new Stack<string>();
            stack.Push("napisano tekst");
            stack.Push("dodano zdanie");
            stack.Push("usunięto słowo");
            stack.Push("dodano akapit");

            Console.WriteLine(stack.Peek());
            stack.Pop();
            stack.Pop();

            foreach(string s in stack)
            { Console.WriteLine(s); }

            /*----------------------------------------------------
                                Zadanie. 5
            ----------------------------------------------------*/

            HashSet<int> A = new HashSet<int>() {1, 2, 3, 4, 5, 6};
            HashSet<int> B = new HashSet<int>() {4, 5, 6, 7, 8, 9};

            foreach (int num in A.Union(B)) { Console.WriteLine(num); }
            foreach (int num in A.Intersect(B)) { Console.WriteLine(num); }
            foreach (int num in A.Except(B)) { Console.WriteLine(num); }

            A.Contains(3);
            B.Contains(10);

            /*----------------------------------------------------
                                Zadanie. 6
            ----------------------------------------------------*/

            LinkedList<string> dni = new LinkedList<string>();
            dni.AddFirst("Poniedziałek");
            var node = dni.AddLast("Piątek");
            dni.AddBefore(node, "Wtorek");
            var node2 = dni.AddBefore(node, "Środa");
            dni.AddBefore(node, "Czwartek");
            dni.AddFirst("Niedziela");
            dni.AddLast("Sobota");
            dni.AddAfter(node2, "Święto");
            dni.Remove("Wtorek");
            
            foreach (string dzien in dni) { Console.WriteLine(dzien); }
            Console.WriteLine(dni.First());
            Console.WriteLine(dni.Last());

        }
    }
}
