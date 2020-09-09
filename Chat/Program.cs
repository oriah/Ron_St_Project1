using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat
{
  class Program
  {
    static void Main(string[] args)
    {
      asas();
  
    }

    private static void asas()
    {
      const int n = 15;
      int i, j;
      int[] a = new int[16] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
      for (i = 1; i <= n; i++)
      {
        a[i] = i;
      }

      for (i = 2; i < n; i++)
      {
        if (a[i] != 0)
        {
          for (j = i + 1; j <= n; j++)
          {
            if (a[j] % a[i] == 0)
            {
              a[j] = 0;
            }
          }

        }
      }

      for (i = 1; i <= n; i++)
      {
        if (a[i] != 0)
        {
          Console.WriteLine(a[i]);
        }
      }
    }
  }
}
