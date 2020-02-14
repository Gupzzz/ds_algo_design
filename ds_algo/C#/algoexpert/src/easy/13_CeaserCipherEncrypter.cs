namespace algoexpert
{
// ​Caesar Cipher Encryptor

// Given a non-empty string of lowercase letters and a non-negative integer value representing a key, write a 
// function that returns a new string obtained by shifting every letter in the input string by k positions in the 
// alphabet, where k is the key.Note that letters should "wrap" around the alphabet; in other words, the letter "z" 
// shifted by 1 returns the letter "a".

// Sample input: "xyz", 2
// Sample output: "zab"
public partial class Program
    {
        // O(n) time | O(n) space
        public static string CaesarCypherEncryptor(string str, int key)
        {
            char[] newLetters = new char[str.Length];
            int newKey = key % 26;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < str.Length; i++)
            {
                newLetters[i] = getNewLetter(str[i], newKey, alphabet);
            }
            return new string(newLetters);
        }

        public static char getNewLetter(char letter, int key, string alphabet)
        {
            int newLetterCode = alphabet.IndexOf(letter) + key;
            return newLetterCode <=
                   25 ? alphabet[newLetterCode] : alphabet[-1 + newLetterCode % 25];
        }
    }
}