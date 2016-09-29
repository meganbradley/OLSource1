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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String Functions (Visual Basic)
The following table lists the functions that Visual Basic provides to search and manipulate strings.  
  
|.NET Framework method|Description|  
|---------------------------|-----------------|  
|[Asc](assetId:///M:Microsoft.VisualBasic.Strings.Asc(System.Char)?qualifyHint=False&autoUpgrade=True), [AscW](assetId:///M:Microsoft.VisualBasic.Strings.AscW(System.Char)?qualifyHint=False&autoUpgrade=True)|Returns an `Integer` value representing the character code corresponding to a character.|  
|[Chr](assetId:///M:Microsoft.VisualBasic.Strings.Chr(System.Int32)?qualifyHint=False&autoUpgrade=True), [ChrW](assetId:///M:Microsoft.VisualBasic.Strings.ChrW(System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns the character associated with the specified character code.|  
|[Filter](assetId:///M:Microsoft.VisualBasic.Strings.Filter(System.String[],System.String,System.Boolean,Microsoft.VisualBasic.CompareMethod)?qualifyHint=False&autoUpgrade=True)|Returns a zero-based array containing a subset of a `String` array based on specified filter criteria.|  
|[Format](assetId:///M:Microsoft.VisualBasic.Strings.Format(System.Object,System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string formatted according to instructions contained in a format `String` expression.|  
|[FormatCurrency](assetId:///M:Microsoft.VisualBasic.Strings.FormatCurrency(System.Object,System.Int32,Microsoft.VisualBasic.TriState,Microsoft.VisualBasic.TriState,Microsoft.VisualBasic.TriState)?qualifyHint=False&autoUpgrade=True)|Returns an expression formatted as a currency value using the currency symbol defined in the system control panel.|  
|[FormatDateTime](assetId:///M:Microsoft.VisualBasic.Strings.FormatDateTime(System.DateTime,Microsoft.VisualBasic.DateFormat)?qualifyHint=False&autoUpgrade=True)|Returns a string expression representing a date/time value.|  
|[FormatNumber](assetId:///M:Microsoft.VisualBasic.Strings.FormatNumber(System.Object,System.Int32,Microsoft.VisualBasic.TriState,Microsoft.VisualBasic.TriState,Microsoft.VisualBasic.TriState)?qualifyHint=False&autoUpgrade=True)|Returns an expression formatted as a number.|  
|[FormatPercent](assetId:///M:Microsoft.VisualBasic.Strings.FormatPercent(System.Object,System.Int32,Microsoft.VisualBasic.TriState,Microsoft.VisualBasic.TriState,Microsoft.VisualBasic.TriState)?qualifyHint=False&autoUpgrade=True)|Returns an expression formatted as a percentage (that is, multiplied by 100) with a trailing % character.|  
|[InStr](assetId:///M:Microsoft.VisualBasic.Strings.InStr(System.String,System.String,Microsoft.VisualBasic.CompareMethod)?qualifyHint=False&autoUpgrade=True)|Returns an integer specifying the start position of the first occurrence of one string within another.|  
|[InStrRev](assetId:///M:Microsoft.VisualBasic.Strings.InStrRev(System.String,System.String,System.Int32,Microsoft.VisualBasic.CompareMethod)?qualifyHint=False&autoUpgrade=True)|Returns the position of the first occurrence of one string within another, starting from the right side of the string.|  
|[Join](assetId:///M:Microsoft.VisualBasic.Strings.Join(System.String[],System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string created by joining a number of substrings contained in an array.|  
|[LCase](assetId:///M:Microsoft.VisualBasic.Strings.LCase(System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string or character converted to lowercase.|  
|[Left](assetId:///M:Microsoft.VisualBasic.Strings.Left(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns a string containing a specified number of characters from the left side of a string.|  
|[Len](assetId:///M:Microsoft.VisualBasic.Strings.Len(System.String)?qualifyHint=False&autoUpgrade=True)|Returns an integer that contains the number of characters in a string.|  
|[LSet](assetId:///M:Microsoft.VisualBasic.Strings.LSet(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns a left-aligned string containing the specified string adjusted to the specified length.|  
|[LTrim](assetId:///M:Microsoft.VisualBasic.Strings.LTrim(System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string containing a copy of a specified string with no leading spaces.|  
|[Mid](assetId:///M:Microsoft.VisualBasic.Strings.Mid(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns a string containing a specified number of characters from a string.|  
|[Replace](assetId:///M:Microsoft.VisualBasic.Strings.Replace(System.String,System.String,System.String,System.Int32,System.Int32,Microsoft.VisualBasic.CompareMethod)?qualifyHint=False&autoUpgrade=True)|Returns a string in which a specified substring has been replaced with another substring a specified number of times.|  
|[Right](assetId:///M:Microsoft.VisualBasic.Strings.Right(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns a string containing a specified number of characters from the right side of a string.|  
|[RSet](assetId:///M:Microsoft.VisualBasic.Strings.RSet(System.String,System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns a right-aligned string containing the specified string adjusted to the specified length.|  
|[RTrim](assetId:///M:Microsoft.VisualBasic.Strings.RTrim(System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string containing a copy of a specified string with no trailing spaces.|  
|[Space](assetId:///M:Microsoft.VisualBasic.Strings.Space(System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns a string consisting of the specified number of spaces.|  
|[Split](assetId:///M:Microsoft.VisualBasic.Strings.Split(System.String,System.String,System.Int32,Microsoft.VisualBasic.CompareMethod)?qualifyHint=False&autoUpgrade=True)|Returns a zero-based, one-dimensional array containing a specified number of substrings.|  
|[StrComp](assetId:///M:Microsoft.VisualBasic.Strings.StrComp(System.String,System.String,Microsoft.VisualBasic.CompareMethod)?qualifyHint=False&autoUpgrade=True)|Returns -1, 0, or 1, based on the result of a string comparison.|  
|[StrConv](assetId:///M:Microsoft.VisualBasic.Strings.StrConv(System.String,Microsoft.VisualBasic.VbStrConv,System.Int32)?qualifyHint=False&autoUpgrade=True)|Returns a string converted as specified.|  
|[StrDup](assetId:///M:Microsoft.VisualBasic.Strings.StrDup(System.Int32,System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string or object consisting of the specified character repeated the specified number of times.|  
|[StrReverse](assetId:///M:Microsoft.VisualBasic.Strings.StrReverse(System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string in which the character order of a specified string is reversed.|  
|[Trim](assetId:///M:Microsoft.VisualBasic.Strings.Trim(System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string containing a copy of a specified string with no leading or trailing spaces.|  
|[UCase](assetId:///M:Microsoft.VisualBasic.Strings.UCase(System.String)?qualifyHint=False&autoUpgrade=True)|Returns a string or character containing the specified string converted to uppercase.|  
  
 You can use the [Option Compare](../vs140/option-compare-statement.md) statement to set whether strings are compared using a case-insensitive text sort order determined by your system's locale (`Text`) or by the internal binary representations of the characters (`Binary`). The default text comparison method is `Binary`.  
  
## Example  
 This example uses the `UCase` function to return an uppercase version of a string.  
  
 [!code[VbVbalrStrings#31](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_1.vb)]  
  
## Example  
 This example uses the `LTrim` function to strip leading spaces and the `RTrim` function to strip trailing spaces from a string variable. It uses the `Trim` function to strip both types of spaces.  
  
 [!code[VbVbalrStrings#25](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_2.vb)]  
  
## Example  
 This example uses the `Mid` function to return a specified number of characters from a string.  
  
 [!code[VbVbalrStrings#17](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_3.vb)]  
  
## Example  
 This example uses `Len` to return the number of characters in a string.  
  
 [!code[VbVbalrStrings#33](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_4.vb)]  
  
## Example  
 This example uses the `InStr` function to return the position of the first occurrence of one string within another.  
  
 [!code[VbVbalrStrings#8](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_5.vb)]  
  
## Example  
 This example shows various uses of the `Format` function to format values using both `String` formats and user-defined formats. For the date separator (`/`), time separator (`:`), and the AM/PM indicators (`t` and `tt`), the actual formatted output displayed by your system depends on the locale settings the code is using. When times and dates are displayed in the development environment, the short time format and short date format of the code locale are used.  
  
> [!NOTE]
>  For locales that use a 24-hour clock, the AM/PM indicators (`t` and `tt`) display nothing.  
  
 [!code[VbVbalrStrings#27](../vs140/codesnippet/VisualBasic/string-functions--visual-basic-_6.vb)]  
  
## See Also  
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Visual Basic Runtime Library Members](../vs140/visual-basic-runtime-library-members.md)   
 [String Manipulation Summary](../vs140/string-manipulation-summary--visual-basic-.md)