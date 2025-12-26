namespace DemoTreeTraversal
{
    public class Alphabet
    {
        public IAsyncEnumerable<char> GetLettersAsync()
        {
            return GetLettersInternalAsync();
            async IAsyncEnumerable<char> GetLettersInternalAsync()
            {
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    await System.Threading.Tasks.Task.Delay(1); // Simulate asynchronous operation
                    yield return c;
                }
            }
        }
    }
}


