public class Solution {
    public static int LengthOfLastWord(string s) {
        int l=0;
        int i=s.Length-1;
        while(i>=0 && s[i]==' '){
            i--;
        }
        while(i>=0 && s[i]!=' '){
            l++;
            i--;
        }
        return l;
    }

    public static void Main () {
        string s = "  we are  flying to the  moon   ";
        Console.Write(LengthOfLastWord (s));
    }
}

