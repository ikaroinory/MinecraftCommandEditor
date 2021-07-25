using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Functions
{
    namespace System
    {
        public class Process
        {
            public static void ThreadSleep(int millisecondsTimeout)
            {
                Thread.Sleep(millisecondsTimeout);
            }

            public static void ThreadDelay(int millisecondsTimeout)
            {
                int start = Environment.TickCount;
                while (Math.Abs(Environment.TickCount - start) < millisecondsTimeout)// 毫秒
                {
                    Application.DoEvents();
                }
            }
        }

        public class StrManipulation
        {
            public static string Replace(string str, string oldSubstr, string newSubstr = null)
            {
                str = str.Replace(oldSubstr, newSubstr);
                return str;
            }
            public static string Replace(string str, string[] oldSubstrList, string[] newSubstrList)
            {
                int count_old = oldSubstrList.Length;
                int count_new = newSubstrList.Length;
                int i = 0;
                while (i < count_new)
                {
                    Regex r = new Regex(oldSubstrList[i]);
                    Match m = r.Match(str);
                    if (m.Success == true)
                    {
                        str = str.Replace(oldSubstrList[i], newSubstrList[i]);
                    }
                    i++;
                }
                while (i < count_old)
                {
                    Regex r = new Regex(oldSubstrList[i]);
                    Match m = r.Match(str);
                    if (m.Success == true)
                    {
                        str = str.Replace(oldSubstrList[i],null);
                    }
                    i++;
                }
                return str;
            }
            public static string Replace(string str, SortedList list)
            {
                ICollection keys = list.Keys;
                foreach (string p in keys)
                {
                    Regex r = new Regex(p);
                    Match m = r.Match(str);
                    if (m.Success == true)
                    {
                        str = str.Replace(p, list[p].ToString());
                    }
                }
                return str;
            }
        }
    }
}
