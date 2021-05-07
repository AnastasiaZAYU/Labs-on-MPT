using System.Threading;

namespace Lab_3
{
    public class Lab_Mutex
    {
        private static Mutex _mutex = new Mutex(false, "Lab3_Mutex");

        public bool Start()
        {
            if (!_mutex.WaitOne(10))
            {
                return false;
            }
            return true;
        }

        public void Stop()
        {
            _mutex.ReleaseMutex();
            _mutex.Dispose();
        }
    }
}
