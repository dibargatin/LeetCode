namespace Solutions;

/*
https://leetcode.com/problems/valid-parentheses/description/

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

1. Open brackets must be closed by the same type of brackets.
2. Open brackets must be closed in the correct order.
3. Every close bracket has a corresponding open bracket of the same type.
 

Example 1:
    Input: s = "()"
    Output: true

Example 2:
    Input: s = "()[]{}"
    Output: true

Example 3:
    Input: s = "(]"
    Output: false

Example 4:
    Input: s = "([])"
    Output: true

Example 5:
    Input: s = "([)]"
    Output: false

Constraints:
    1 <= s.length <= 104
    s consists of parentheses only '()[]{}'.
*/
public class Problem20
{
    public bool IsValid(string s)
    {
        var opened = new Stack<BracketType>();
        var bracketsCount = new Dictionary<BracketType, int>{
            { BracketType.Round, 0 },
            { BracketType.Square, 0 },
            { BracketType.Curly, 0 }
        };

        foreach (var ch in s)
        {
            (var bracketType, var isOpened) = CheckBracket(ch);

            if (isOpened)
            {
                bracketsCount[bracketType]++;
                opened.Push(bracketType);
            }
            else if (bracketsCount[bracketType] == 0)
            {
                return false;
            }
            else if (opened.Count() == 0 || opened.Peek() != bracketType)
            {
                return false;
            }
            else
            {
                bracketsCount[bracketType]--;
                opened.Pop();
            }
        }

        return opened.Count() == 0;
    }

    private (BracketType, bool) CheckBracket(char ch) => ch switch
    {
        '(' => (BracketType.Round, true),
        ')' => (BracketType.Round, false),
        '[' => (BracketType.Square, true),
        ']' => (BracketType.Square, false),
        '{' => (BracketType.Curly, true),
        '}' => (BracketType.Curly, false),
        _ => throw new ArgumentException()
    };

    private enum BracketType
    {
        Round,
        Square,
        Curly
    }
}