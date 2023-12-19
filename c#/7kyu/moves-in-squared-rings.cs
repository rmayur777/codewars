// You are given a string of n lines, each substring being n characters long: For example:

// s = "abcd\nefgh\nijkl\nmnop"

// We will study some transformations of this square of strings.

//     Vertical mirror: vert_mirror (or vertMirror or vert-mirror)

//     vert_mirror(s) => "dcba\nhgfe\nlkji\nponm"

//     Horizontal mirror: hor_mirror (or horMirror or hor-mirror)

//      hor_mirror(s) => "mnop\nijkl\nefgh\nabcd"

// or printed:

// vertical mirror   |horizontal mirror   
// abcd --> dcba     |abcd --> mnop 
// efgh     hgfe     |efgh     ijkl 
// ijkl     lkji     |ijkl     efgh 
// mnop     ponm     |mnop     abcd 

// Task:

//     Write these two functions

// and

//     high-order function oper(fct, s) where

//     fct is the function of one variable f to apply to the string s (fct will be one of vertMirror, horMirror)


using System;
using System.Linq;

public class Opstrings
{
    public static string VertMirror(string strng)
    {
        return string.Join("\n", strng.Split('\n').Select(i => string.Concat(i.Reverse())));
    }
    public static string HorMirror(string strng)
    {
        return string.Join("\n", strng.Split('\n').Reverse());
    }
    public static string Oper(Func<string,string> fct, string s)
    {
        return fct(s);
    }
}