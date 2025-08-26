namespace Solutions;

/*
https://leetcode.com/problems/string-to-integer-atoi/

Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer.

The algorithm for myAtoi(string s) is as follows:

1. Whitespace: Ignore any leading whitespace (" ").
2. Signedness: Determine the sign by checking if the next character is '-' or '+', assuming positivity if neither present.
3. Conversion: 
    Read the integer by skipping leading zeros until a non-digit character is encountered or the end of the string is reached. 
    If no digits were read, then the result is 0.
4. Rounding: 
    If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then round the integer to remain in the range. 
    Specifically, integers less than -231 should be rounded to -231, and integers greater than 231 - 1 should be rounded to 231 - 1.

Return the integer as the final result.
 

Example 1:
    Input: s = "42"
    Output: 42
    Explanation:
        The underlined characters are what is read in and the caret is the current reader position.
        Step 1: "42" (no characters read because there is no leading whitespace)
                ^
        Step 2: "42" (no characters read because there is neither a '-' nor '+')
                ^
        Step 3: "42" ("42" is read in)
                ^

Example 2:
    Input: s = " -042"
    Output: -42
    Explanation:
        Step 1: "   -042" (leading whitespace is read and ignored)
                    ^
        Step 2: "   -042" ('-' is read, so the result should be negative)
                    ^
        Step 3: "   -042" ("042" is read in, leading zeros ignored in the result)
                    ^

Example 3:
    Input: s = "1337c0d3"
    Output: 1337
    Explanation:
        Step 1: "1337c0d3" (no characters read because there is no leading whitespace)
                ^
        Step 2: "1337c0d3" (no characters read because there is neither a '-' nor '+')
                ^
        Step 3: "1337c0d3" ("1337" is read in; reading stops because the next character is a non-digit)
                    ^

Example 4:
    Input: s = "0-1"
    Output: 0
    Explanation:
        Step 1: "0-1" (no characters read because there is no leading whitespace)
                ^
        Step 2: "0-1" (no characters read because there is neither a '-' nor '+')
                ^
        Step 3: "0-1" ("0" is read in; reading stops because the next character is a non-digit)
                ^

Example 5:
    Input: s = "words and 987"
    Output: 0
    Explanation:
        Reading stops at the first non-digit character 'w'.
 

Constraints:
    0 <= s.length <= 200
    s consists of English letters (lower-case and upper-case), digits (0-9), ' ', '+', '-', and '.'.
*/
public class Problem8
{
    public int MyAtoi(string s)
    {
        bool isPositive = true;
        int startPosition = -1;
        bool leadingZero = false;
        var digits = new List<byte>();

        for (int i = 0; i < s.Length; i++)
        {
            var digit = CharToByte(s[i]);

            if (startPosition == -1)
            {
                if (digit.HasValue)
                {
                    startPosition = i;

                    if (digit.Value != 0)
                    {
                        digits.Add(digit.Value);
                    }
                    else
                    {
                        leadingZero = true;
                    }
                }
                else if (s[i] == ' ')
                {
                    continue;
                }
                else if (s[i] == '+')
                {
                    startPosition = i;
                }
                else if (s[i] == '-')
                {
                    startPosition = i;
                    isPositive = false;
                }
                else break;
            }
            else if (digit.HasValue)
            {
                if (leadingZero && digit.Value != 0)
                {
                    digits.Add(digit.Value);
                    leadingZero = false;
                }
                else if (!leadingZero)
                {
                    digits.Add(digit.Value);
                }
            }
            else break;

        }

        long result = 0;
        for (int i = 0; i < digits.Count; i++)
        {
            result += (int)(digits[i] * Math.Pow(10, digits.Count - 1 - i));

            if (isPositive && result > Int32.MaxValue)
            {
                result = Int32.MaxValue;
                break;
            }
            else if (!isPositive && result > Int32.MaxValue + 1L)
            {
                result = Int32.MaxValue + 1L;
                break;
            }
        }

        if (isPositive)
        {
            return (int)result;
        }
        else if (result == Int32.MaxValue + 1L)
        {
            return Int32.MinValue;
        }
        else
        {
            return (int)-result;
        }
    }

    private static byte? CharToByte(char ch) => ch switch
    {
        '0' => 0,
        '1' => 1,
        '2' => 2,
        '3' => 3,
        '4' => 4,
        '5' => 5,
        '6' => 6,
        '7' => 7,
        '8' => 8,
        '9' => 9,
        _ => null,
    };
}