---
title: "Using Regular Expressions in Visual Studio"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vsregularexpressionhelp"
  - "vs.regularexpressionhelp"
  - "vs.wildcardsbuilder"
  - "vs.netregularexpressionhelp"
  - "vs.wildcards"
helpviewer_keywords: 
  - "regular expressions [Visual Studio]"
  - "regular expressions"
  - "Visual Studio, regular expressions"
ms.assetid: 718a617d-0e05-47e1-a218-9746971527f4
caps.latest.revision: 57
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Regular Expressions in Visual Studio
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] uses .NET Framework regular expressions to find and replace text. For more information about .NET regular expressions, see [.NET Framework Regular Expressions](assetId:///521b3f6d-f869-42e1-93e5-158c54a6895d).  
  
 Before Visual Studio 2012, Visual Studio used custom regular expression syntax in the Find and Replace windows. See [Visual Studio Regular Expression Conversions](https://msdn.microsoft.com/en-us/library/2k3te2cs\(v=vs.110\).aspx) for an explanation of how to convert some of the more commonly-used custom regular expression symbols to the .NET versions.  
  
> [!TIP]
>  In Windows operating systems, most lines end in “\r\n” (a carriage return followed by a new line). These characters are not visible, but are present in the editor and are passed to the .NET Regular Expression service.  
  
> [!TIP]
>  For information about regular expressions that are used in replacement patterns, see [Substitutions](assetId:///d1f52431-1c7d-4dc6-8792-6b988256892e). To use a numbered capture group, the syntax is <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> to specify the numbered group and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to specify the group in question. For example, the grouped regular expression <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> finds four matches in the following string: **1a 2b 3c 4d**. The replacement string <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> converts that string to **z1 z2 z3 z4**.  
  
## Regular Expressions in Visual Studio  
 Here are some examples  
  
|Purpose|Expression|Example|  
|-------------|----------------|-------------|  
|Match any single character (except a line break)|.|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> matches "aro" in "around" and "abo" in "about" but not "acro" in "across".|  
|Match zero or more occurrences of the preceding expression (match as many characters as possible)|*|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> matches "r" in "rack", "ar" in "ark", and "aar" in "aardvark"|  
|Match any character zero or more times (Wildcard *)|.*|c.*e matches “cke” in “racket”, “comme” in “comment”, and “code” in “code”|  
|Match one or more occurrences of the preceding expression (match as many characters as possible)|+|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> matches "eede" in "feeder" but not "ee".|  
|Match any character one or more times (Wildcard ?)|.+|e.+e matches "eede" in "feeder" but not "ee".|  
|Match zero or more occurrences of the preceding expression (match as few characters as possible)|*?|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> matches "ee" in "feeder" but not "eede".|  
|Match one or more occurrences of the preceding expression (match as few characters as possible)|+?|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> matches "ente" and "erprise" in "enterprise", but not the whole word "enterprise".|  
|Anchor the match string to the beginning of a line or string|^|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder> matches the word "car" only when it appears at the beginning of a line.|  
|Anchor the match string to the end of a line|\r?$|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> matches "end" only when it appears at the end of a line.|  
|Match any single character in a set|[abc]|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder> matches "ba", "bb", and "bc".|  
|Match any character in a range of characters|[a-f]|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder> matches "bet" in "between", "ben" in "beneath", and "bes" in "beside", but not "below".|  
|Capture and implicitly number the expression contained within parenthesis|()|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder> matches "aXa"and "bXb", but not "aXb". ". “\1” refers to the first expression group “[a-z]”.|  
|Invalidate a match|(?!abc)|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> matches "real" in "realty" and "really" but not in "reality." It also finds the second "real" (but not the first "real") in "realityreal".|  
|Match any character that is not in a given set of characters|[^abc]|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder> matches "bef" in "before", "beh" in "behind", and "bel" in "below", but not "beneath".|  
|Match either the expression before or the one after the symbol.|&#124;|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder> matches "sponge bath" and "mud bath."|  
|Escape the character following the backslash|\|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> matches the character ^.|  
|Specify the number of occurrences of the preceding character or group|{x}, where x is the number of occurrences|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> matches "xababx", and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> matches "xababx" and "xabababx" but not "xababababx".|  
|Match text in a Unicode character class, where “X” is the Unicode number. For more information about Unicode character classes, see\<br />\<br /> [Unicode Standard 5.2 Character Properties](http://www.unicode.org/versions/Unicode5.2.0/ch04.pdf).|\p{X}|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> matches "T" and "D" in "Thomas Doe".|  
|Match a word boundary|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder> (Outside a character class \b specifies a word boundary, and inside a character class specifies a backspace).|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> matches "in" in "inside" but not "pinto".|  
|Match a line break (ie a carriage return followed by a new line).|\r?\n|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder> matches "End" and "Begin" only when "End" is the last string in a line and "Begin" is the first string in the next line.|  
|Match any alphanumeric character|\w|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder> matches "add" and "a1d" but not "a d".|  
|Match any whitespace character.|(?([^\r\n])\s)|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> matches the phrase "Public Interface".|  
|Match any numeric character|\d|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder> matches and "3" in "3456", "2" in 23", and "1" in "1".|  
|Match a Unicode character|\uXXXX where XXXX specifies the Unicode character value.|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder> matches the character "e".|  
|Match an identifier|\b(_\w+&#124;[\w-[0-9\_]]\w*)\b|Matches "type1" but not &type1" or "#define".|  
|Match a string inside quotes|((\\".+?\\")&#124;('.+?'))|Matches any string inside single or double quotes.|  
|Match a hexadecimal number|\b0[xX]([0-9a-fA-F]\)\b|Matches "0xc67f" but not "0xc67fc67f".|  
|Match integers and decimals|\b[0-9]*\\.\*[0-9]+\b|Matches "1.333".|  
  
## See Also  
 [Searching and Replacing](../vs140/finding-and-replacing-text.md)