using System.Text;

namespace Solutions;

/*
https://leetcode.com/problems/zigzag-conversion/

The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
(you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

string convert(string s, int numRows);


Example 1:
    Input: s = "PAYPALISHIRING", numRows = 3
    Output: "PAHNAPLSIIGYIR"

Example 2:
    Input: s = "PAYPALISHIRING", numRows = 4
    Output: "PINALSIGYAHRPI"
    Explanation:
        P     I    N
        A   L S  I G
        Y A   H R
        P     I

Example 3:
    Input: s = "A", numRows = 1
    Output: "A"
 
Constraints:
    1 <= s.length <= 1000
    s consists of English letters (lower-case and upper-case), ',' and '.'.
    1 <= numRows <= 1000
*/
public class Problem6
{
    public string Convert(string s, int numRows)
    {
        if (s.Length <= numRows || numRows == 1) return s;

        var rows = new StringBuilder[numRows];

        for (int x = 0; x < numRows; x++)
            rows[x] = new StringBuilder();

        int pos = 0, direction = 1;

        for (int i = 0; i < s.Length; i++)
        {
            rows[pos].Append(s[i]);
            pos += direction;
            if (pos == numRows - 1 || pos == 0) direction *= -1;
        }

        var result = new StringBuilder(s.Length);

        foreach (var row in rows)
        {
            result.Append(row);
        }

        return result.ToString();
    }
}