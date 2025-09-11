using System.Text;

namespace Solutions;

/*
https://leetcode.com/problems/letter-combinations-of-a-phone-number/

Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.

A mapping of digits to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

2: [a,b,c]
3: [d,e,f]
4: [g,h,i]
5: [j,k,l]
6: [m,n,o]
7: [p,q,r,s]
8: [t,u,v]
9: [w,x,y,z]

Example 1:
    Input: digits = "23"
    Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]

Example 2:
    Input: digits = ""
    Output: []

Example 3:
    Input: digits = "2"
    Output: ["a","b","c"]
 

Constraints:
    0 <= digits.length <= 4
    digits[i] is a digit in the range ['2', '9']

Complexity:
    O(4^n) - time
    O(n) - space    
*/
public class Problem17
{
    private static readonly Dictionary<char, string> Alphabet =
        new() {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" },
        };

    public IList<string> LetterCombinations(string digits)
    {
        var result = new List<string>();

        if (digits.Length == 0)
        {
            return result;
        }

        Backtrack(0, "");

        return result;

        void Backtrack(int index, string acc)
        {
            if (index == digits.Length)
            {
                result.Add(acc);
                return;
            }

            var letters = Alphabet[digits[index]];

            for (int i = 0; i < letters.Length; i++)
            {
                Backtrack(index + 1, acc + letters[i]);
            }
        }
    }
}