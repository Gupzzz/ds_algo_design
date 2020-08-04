import java.util.*;

class Solution {
    static Map<String, List<String>> map = new HashMap<>();

    public static void main(final String[] args) {
        List<String> input = new ArrayList<String>();
        input.add("cat");
        input.add("cats");
        input.add("and");
        input.add("sand");
        input.add("dog");
        System.out.println(wordBreak("catsanddog", input));
    }

    public static List<String> wordBreak(final String s, final List<String> wordDict) {
        if (map.containsKey(s))
            return map.get(s);
        final List<String> result = new LinkedList<>();
        if (wordDict.contains(s))
            result.add(s);
        for (int i = 1; i < s.length(); i++) {
            final String left = s.substring(0, i);
            if (wordDict.contains(left)) {
                for (final String ss : wordBreak(s.substring(i), wordDict)) {
                    result.add(left+ " " + ss);
                }
            }
        }

        map.put(s, result);
        return result;
    }
}

/*
Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, add spaces in s to construct a sentence where each word is a valid dictionary word. Return all such possible sentences.

Note:

The same word in the dictionary may be reused multiple times in the segmentation.
You may assume the dictionary does not contain duplicate words.
Example 1:

Input:
s = "catsanddog"
wordDict = ["cat", "cats", "and", "sand", "dog"]
Output:
[
  "cats and dog",
  "cat sand dog"
]
*/