namespace CmdQ
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

public sealed class AsyncLock
{
    private readonly SemaphoreSlim _semaphore = new(1, 1);

    public async Task<IDisposable> LockAsync()
    {
        await this._semaphore.WaitAsync();
        return new Handler(this._semaphore);
    }

    private sealed class Handler: IDisposable
    {
        private readonly SemaphoreSlim _semaphore;
        private bool _disposed = false;

        public Handler(SemaphoreSlim semaphore)
        {
            this._semaphore = semaphore;
        }

        public void Dispose()
        {
            if (!this._disposed)
            {
                this._semaphore.Release();
                this._disposed = true;
            }
        }
    }
}