using System;

class Program {
    static void Main(string[] args) {
        var sol = new Solution();

        Console.WriteLine(sol.IsAnagram("anagram", "nagaram")); // True
        Console.WriteLine(sol.IsAnagram("rat", "car"));         // False
    }
}

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var count = new int[26];
        foreach (char c in s) count[c - 'a']++;
        foreach (char c in t) count[c - 'a']--;

        foreach (int val in count)
            if (val != 0) return false;
        return true;
    }
}
