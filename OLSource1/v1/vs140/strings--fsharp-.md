---
title: "Strings (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "strings [F#]"
  - "substrings [F#]"
ms.assetid: 01a0ccab-131f-4391-80b9-68eb35a70445
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Strings (F#)
The `string` type represents immutable text as a sequence of Unicode characters. `string` is an alias for <xref:System.String*> in the .NET Framework.  
  
## Remarks  
 String literals are delimited by the quotation mark (") character. The backslash character (\\) is used to encode certain special characters. The backslash and the next character together are known as an *escape sequence*. Escape sequences supported in F# string literals are shown in the following table.  
  
|Character|Escape sequence|  
|---------------|---------------------|  
|Backspace|\b|  
|Newline|\n|  
|Carriage return|\r|  
|Tab|\t|  
|Backslash|\\\|  
|Quotation mark|\\"|  
|Apostrophe|\\'|  
|Unicode character|\u*XXXX* or \U*XXXXXXXX* (where *X* indicates a hexadecimal digit)|  
  
 If preceded by the @ symbol, the literal is a verbatim string. This means that any escape sequences are ignored, except that two quotation mark characters are interpreted as one quotation mark character.  
  
 Additionally, a string may be enclosed by triple quotes. In this case, all escape sequences are ignored, including double quotation mark characters. To specify a string that contains an embedded quoted string, you can either use a verbatim string or a triple-quoted string. If you use a verbatim string, you  must specify two quotation mark characters to indicate a single quotation mark character. If you use a triple-quoted string, you can use the single quotation mark characters without them being parsed as the end of the string. This technique can be useful when you work with XML or other structures that include embedded quotation marks.  
  
```f#  
// Using a verbatim string  
let xmlFragment1 = @"<book author=""Milton, John"" title=""Paradise Lost"">"  
  
// Using a triple-quoted string  
let xmlFragment2 = """<book author="Milton, John" title="Paradise Lost">"""  
  
```  
  
 In code, strings that have line breaks are accepted and the line breaks are interpreted literally as newlines, unless a backslash character is the last character before the line break. Leading whitespace on the next line is ignored when the backslash character is used. The following code produces a string `str1` that has value `"abc\n     def"` and a string `str2` that has value `"abcdef"`.  
  
 [!code[FsLangRef1#1001](../vs140/codesnippet/FSharp/strings--fsharp-_1.fs)]  
  
 You can access individual characters in a string by using array-like syntax, as follows.  
  
 [!code[FsLangRef1#1002](../vs140/codesnippet/FSharp/strings--fsharp-_2.fs)]  
  
 The output is `b`.  
  
 Or you can extract substrings by using array slice syntax, as shown in the following code.  
  
 [!code[FsLangRef1#1003](../vs140/codesnippet/FSharp/strings--fsharp-_3.fs)]  
  
 The output is as follows.  
  
```  
abc  
def  
```  
  
 You can represent ASCII strings by arrays of unsigned bytes, type `byte[]`. You add the suffix `B` to a string literal to indicate that it is an ASCII string. ASCII string literals used with byte arrays support the same escape sequences as Unicode strings, except for the Unicode escape sequences.  
  
 [!code[FsLangRef1#1004](../vs140/codesnippet/FSharp/strings--fsharp-_4.fs)]  
  
## String Operators  
 There are two ways to concatenate strings: by using the `+` operator or by using the `^` operator. The `+` operator maintains compatibility with the .NET Framework string handling features.  
  
 The following example illustrates string concatenation.  
  
 [!code[FsLangRef1#1006](../vs140/codesnippet/FSharp/strings--fsharp-_5.fs)]  
  
## String Class  
 Because the string type in F# is actually a .NET Framework <xref:System.String*> type, all the <xref:System.String*> members are available. This includes the `+` operator, which is used to concatenate strings, the `Length` property, and the `Chars` property, which returns the string as an array of Unicode characters. For more information about strings, see <xref:System.String*>.  
  
 By using the `Chars` property of <xref:System.String*>, you can access the individual characters in a string by specifying an index, as is shown in the following code.  
  
 [!code[FsLangRef1#1005](../vs140/codesnippet/FSharp/strings--fsharp-_6.fs)]  
  
## String Module  
 Additional functionality for string handling is included in the `String` module in the `FSharp.Core` namespace. For more information, see [Core.String Module](../vs140/core.string-module--fsharp-.md).  
  
## See Also  
 <xref:System.String*>   
 [F# Language Reference](../vs140/fsharp-language-reference.md)