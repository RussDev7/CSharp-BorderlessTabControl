using System.Windows.Forms;
using System.Threading;
using System;

namespace BorderlessTabControlExample
{
    internal static class Program
    {
        /// <summary>
        /// Main method – guards against multiple instances, enables WinForms
        /// visual styles, and starts the UI via <see cref="AppContextManager" />.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Unique name for the mutex that enforces a single instance.
            string SingleInstanceMutexName = Application.ProductName;

            // Try to acquire the global mutex.
            bool isFirstInstance;
            using var mutex = new Mutex(initiallyOwned: true,
                                        name: SingleInstanceMutexName,
                                        createdNew: out isFirstInstance);

            if (!isFirstInstance) return; // Another copy is already running – quietly exit.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            // Application.Run(new AppContextManager());

            // GC.KeepAlive(mutex);       // Now unnecessary with the using‑statement.
        }
    }
}