namespace DemoTreeTraversal
{
    public class AsyncDemo
    {
        public async System.Threading.Tasks.Task PrintLettersAsync()
        {
            Alphabet alphabet = new Alphabet();
            await foreach (var letter in alphabet.GetLettersAsync())
            {
                Console.Write(letter + " ");
            }
        }
    }
}


