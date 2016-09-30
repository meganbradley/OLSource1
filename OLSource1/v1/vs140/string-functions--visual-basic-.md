---
title: "String Functions (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "string functions"
ms.assetid: f1bf9ac2-cbcf-4298-ae51-53182076bdc8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String Functions (Visual Basic)
The following table lists the functions that Visual Basic provides to search and manipulate strings.  
  
|.NET Framework method|Description|  
|---------------------------|-----------------|  
|\<xref:Microsoft.VisualBasic.Strings.Asc*>, \<xref:Microsoft.VisualBasic.Strings.AscW*>|Returns an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> value representing the character code corresponding to a character.|  
|\<xref:Microsoft.VisualBasic.Strings.Chr*>, \<xref:Microsoft.VisualBasic.Strings.ChrW*>|Returns the character associated with the specified character code.|  
|\<xref:Microsoft.VisualBasic.Strings.Filter*>|Returns a zero-based array containing a subset of a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> array based on specified filter criteria.|  
|\<xref:Microsoft.VisualBasic.Strings.Format*>|Returns a string formatted according to instructions contained in a format <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression.|  
|\<xref:Microsoft.VisualBasic.Strings.FormatCurrency*>|Returns an expression formatted as a currency value using the currency symbol defined in the system control panel.|  
|\<xref:Microsoft.VisualBasic.Strings.FormatDateTime*>|Returns a string expression representing a date/time value.|  
|\<xref:Microsoft.VisualBasic.Strings.FormatNumber*>|Returns an expression formatted as a number.|  
|\<xref:Microsoft.VisualBasic.Strings.FormatPercent*>|Returns an expression formatted as a percentage (that is, multiplied by 100) with a trailing % character.|  
|\<xref:Microsoft.VisualBasic.Strings.InStr*>|Returns an integer specifying the start position of the first occurrence of one string within another.|  
|\<xref:Microsoft.VisualBasic.Strings.InStrRev*>|Returns the position of the first occurrence of one string within another, starting from the right side of the string.|  
|\<xref:Microsoft.VisualBasic.Strings.Join*>|Returns a string created by joining a number of substrings contained in an array.|  
|\<xref:Microsoft.VisualBasic.Strings.LCase*>|Returns a string or character converted to lowercase.|  
|\<xref:Microsoft.VisualBasic.Strings.Left*>|Returns a string containing a specified number of characters from the left side of a string.|  
|\<xref:Microsoft.VisualBasic.Strings.Len*>|Returns an integer that contains the number of characters in a string.|  
|\<xref:Microsoft.VisualBasic.Strings.LSet*>|Returns a left-aligned string containing the specified string adjusted to the specified length.|  
|\<xref:Microsoft.VisualBasic.Strings.LTrim*>|Returns a string containing a copy of a specified string with no leading spaces.|  
|\<xref:Microsoft.VisualBasic.Strings.Mid*>|Returns a string containing a specified number of characters from a string.|  
|\<xref:Microsoft.VisualBasic.Strings.Replace*>|Returns a string in which a specified substring has been replaced with another substring a specified number of times.|  
|\<xref:Microsoft.VisualBasic.Strings.Right*>|Returns a string containing a specified number of characters from the right side of a string.|  
|\<xref:Microsoft.VisualBasic.Strings.RSet*>|Returns a right-aligned string containing the specified string adjusted to the specified length.|  
|\<xref:Microsoft.VisualBasic.Strings.RTrim*>|Returns a string containing a copy of a specified string with no trailing spaces.|  
|\<xref:Microsoft.VisualBasic.Strings.Space*>|Returns a string consisting of the specified number of spaces.|  
|\<xref:Microsoft.VisualBasic.Strings.Split*>|Returns a zero-based, one-dimensional array containing a specified number of substrings.|  
|\<xref:Microsoft.VisualBasic.Strings.StrComp*>|Returns -1, 0, or 1, based on the result of a string comparison.|  
|\<xref:Microsoft.VisualBasic.Strings.StrConv*>|Returns a string converted as specified.|  
|\<xref:Microsoft.VisualBasic.Strings.StrDup*>|Returns a string or object consisting of the specified character repeated the specified number of times.|  
|\<xref:Microsoft.VisualBasic.Strings.StrReverse*>|Returns a string in which the character order of a specified string is reversed.|  
|\<xref:Microsoft.VisualBasic.Strings.Trim*>|Returns a string containing a copy of a specified string with no leading or trailing spaces.|  
|\<xref:Microsoft.VisualBasic.Strings.UCase*>|Returns a string or character containing the specified string converted to uppercase.|  
  
 You can use the [Option Compare](../vs140/option-compare-statement.md) statement to set whether strings are compared using a case-insensitive text sort order determined by your system's locale (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) or by the internal binary representations of the characters (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>). The default text comparison method is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 This example uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function to return an uppercase version of a string.  
  
 [!code[VbVbalrStrings#31](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_1.vb)]  
  
## Example  
 This example uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function to strip leading spaces and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function to strip trailing spaces from a string variable. It uses the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function to strip both types of spaces.  
  
 [!code[VbVbalrStrings#25](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_2.vb)]  
  
## Example  
 This example uses the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function to return a specified number of characters from a string.  
  
 [!code[VbVbalrStrings#17](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_3.vb)]  
  
## Example  
 This example uses <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to return the number of characters in a string.  
  
 [!code[VbVbalrStrings#33](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_4.vb)]  
  
## Example  
 This example uses the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> function to return the position of the first occurrence of one string within another.  
  
 [!code[VbVbalrStrings#8](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_5.vb)]  
  
## Example  
 This example shows various uses of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function to format values using both <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> formats and user-defined formats. For the date separator (<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), time separator (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>), and the AM/PM indicators (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>), the actual formatted output displayed by your system depends on the locale settings the code is using. When times and dates are displayed in the development environment, the short time format and short date format of the code locale are used.  
  
> [!NOTE]
>  For locales that use a 24-hour clock, the AM/PM indicators (<CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) display nothing.  
  
 [!code[VbVbalrStrings#27](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_6.vb)]  
  
## See Also  
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Visual Basic Runtime Library Members](../vs140/visual-basic-runtime-library-members.md)   
 [String Manipulation Summary](../vs140/string-manipulation-summary--visual-basic-.md)