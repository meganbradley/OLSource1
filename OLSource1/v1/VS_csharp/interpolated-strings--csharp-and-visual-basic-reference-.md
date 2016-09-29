---
title: "Interpolated Strings (C# and Visual Basic Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 324f267e-1c61-431a-97ed-852c1530742d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interpolated Strings (C# and Visual Basic Reference)
Used to construct strings.  An interpolated string expression looks like a template string that contains expressions.  An interpolated string expression creates a string by replacing the contained expressions with the ToString represenations of the expressions’ results.  An interpolated string is easier to understand with respect to arguments than [composite formatting](assetId:///87b7d528-73f6-43c6-b71a-f23043039a49).  Here is an example of an interpolated string:  
  
```c#  
Console.WriteLine($"Name = {name}, hours = {hours:hh}")  
```  
  
 The structure of an interpolated string is as follows:  
  
```  
$ " <text> { <interpolation-expression> <optional-comma-field-width> <optional-colon-format> } <text> ... } "  
```  
  
 You can use an interpolated string anywhere you can use a string literal.  When running your program would execute the code with the interpolated string literal, the code computes a new string literal by evaluating the interpolation expressions.  This computation occurs each time the code with the interpolated string executes.  
  
 To include a curly brace ("{" or "}") in an interpolated string use two curly braces, "{{" or "}}".  See the Implicit Conversions section for more details.  
  
## Implicit Conversions  
 There are implicit type conversions from an interpolated string:  
  
```c#  
var s = $"hello, {name}"  
System.IFormattable s = $"Hello, {name}"  
System.FormattableString s = $"Hello, {name}"  
  
```  
  
 The first example produces a `string` value where all the string interpolation values have been computed.  It is the final result and has type string.  All occurrences of double curly braces (“{{“ and “}}”) are converted to a single curly brace.  
  
 The second example produces an <xref:System.IFormattable*> variable that allows you to convert the string with invariant context.  This is useful for getting numeric and data formats correct in different languages.  All occurrences of double curly braces (“{{“ and “}}”) remain as double curly braces, until you format the string with ToString.  All contained interpolation expressions are converted to {0}, {1}, and so on.  
  
```c#  
s.ToString(null, System.Globalization.CultureInfo.InvariantCulture);  
```  
  
 The third example produces a <xref:System.FormattableString*>, which allows you to inspect the objects that result from the interpolation computations.  Inspecting objects and how they render as strings might, for example, help you protect against an injection attack if you were building a query.  With <xref:System.FormattableString*>, you have convenience operations to produce the InvariantCulture and CurrentCulture string results.  All occurrences of double curly braces (“{{“ and “}}”) remain as double curly braces, until you format.  All contained interpolation expressions are converted to {0}, {1}, and so on.  
  
## Examples  
  
```c#  
$"Name = {name}, hours = {hours:hh}"  
var s = $"hello, {name}"  
System.IFormattable s = $"Hello, {name}"  
System.FormattableString s = $"Hello, {name}"  
$"{person.Name, 20} is {person.Age:D3} year {(p.Age == 1 ? "" : "s")} old."  
  
```  
  
 You do not need to quote the quotation characters within the contained interpolation expressions because interpolated string expressions start with $, and the compiler scans the contained interpolation expressions as balanced text until it finds a comma, colon, or close curly brace.  For the same reasons, the last example uses parentheses to allow the conditional expression (`p.Age == 1 ? "" : "s"`) to be inside the interpolation expression without the colon starting a format specification.  Outside of the contained interpolation expression (but still within the interpolated string expression) you escape quotation characters as you normally would.  
  
## Syntax  
  
```  
expression:  
    interpolated-string-expression  
  
interpolated-string-expression:  
    interpolated-string-start interpolations interpolated-string-end  
  
interpolations:  
    single-interpolation  
    single-interpolation interpolated-string-mid interpolations  
  
single-interpolation:  
    interpolation-start  
    interpolation-start : regular-string-literal  
  
interpolation-start:  
    expression  
    expression , expression  
  
```  
  
## Language Specifications  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
 For more information, see the [Visual Basic Language Reference](../VS_csharp/visual-basic-language-reference.md).  
  
## See Also  
 <xref:System.IFormattable*?displayProperty=fullName>   
 <xref:System.FormattableString*?displayProperty=fullName>   
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Visual Basic Language Reference](../VS_csharp/visual-basic-language-reference.md)   
 [Visual Basic Programming Guide](../VS_csharp/visual-basic-programming-guide.md)