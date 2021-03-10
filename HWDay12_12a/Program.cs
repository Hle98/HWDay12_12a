using System;
using System.Collections.Generic;

namespace HWDay12_12a
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "A", "B", "C", "D" };
            GroupAssignments(ls,3);
        }
        static void GroupAssignments(List<string> ls,int k)
        {
            var groups = new List<List<string>>();
            GroupAssignments(ls, 0, groups,k);
        }
        static void GroupAssignments(List<string> ls, int idx, List<List<string>> groups,int k)
        {
            if (ls.Count == idx && groups.Count == k)
            {
                PrintGroups(groups);
                return;
            }
            else if(ls.Count==idx)
            {
                return;
            }
            for (int i = 0; i < groups.Count; i++)
            {
                groups[i].Add(ls[idx]);
                GroupAssignments(ls, idx + 1, groups,k);
                groups[i].Remove(ls[idx]);
            }
            groups.Add(new List<string>());
            groups[groups.Count - 1].Add(ls[idx]);
            GroupAssignments(ls, idx + 1, groups,k);
            groups.RemoveAt(groups.Count - 1);
        }
        static void PrintGroups(List<List<string>> groups)
        {
            foreach (List<string> group in groups)
            {
                Console.Write("| ");
                foreach (string s in group)
                {
                    Console.Write(s + " ");
                }
            }
            Console.WriteLine("|");
        }
    }
}

            
            


