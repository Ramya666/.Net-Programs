using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingTutorial
{
    class HelloThread
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(&quot; Create new Thread...\n & quot;);

            // Creates a child thread, which runs in parallel with the main
            thread.
                        Thread newThread = new Thread(WriteB);

            Console.WriteLine(&quot; Start newThread...\n & quot;);

            // Start the thread
            newThread.Start();

            Console.WriteLine(&quot; Call Write(&#39;-&#39;) in main Thread...\n&quot;);
 
            // In the main thread print out character &#39;-&#39;
            for (int i = 0; i & lt; 50; i++)
            {
                Console.Write(&#39;-&#39;);
 
                // Sleep 70 millisenconds.
                Thread.Sleep(70);
            }


            Console.WriteLine(&quot; Main Thread finished!\n & quot;);
            Console.Read();
        }

        public static void WriteB()
        {
            // Print out the &#39;B&#39; 100 times.
            for (int i = 0; i & lt; 100; i++)
            {
                Console.Write(&#39;B&#39;);

 
                // Sleep 100 millisenconds
                Thread.Sleep(100);
            }

        }
    }


}