---
title: "Core.Printf Module (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Core.Printf"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.PrintfModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Printf module [F#]"
  - "PrintfModule module [F#]"
ms.assetid: ea074733-6b5d-498c-ac88-7e4e0f8ded25
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Printf Module (F#)
Extensible <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-style formatting for numbers and other datatypes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Format specifications are strings with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> markers indicating format placeholders. Format placeholders consist of:  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> where the type is interpreted as in the following table:  
  
|Type|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Formats a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, formatted as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Formats a character.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Formats a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, formatted as its contents, without interpreting any escape characters.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Formats any basic integer type formatted as a decimal integer, signed if the basic integer type is signed.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Formats any basic integer type formatted as an unsigned decimal integer.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Formats any basic integer type formatted as an unsigned hexadecimal integer, using lowercase letters a through f.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Formats any basic integer type formatted as an unsigned hexadecimal integer, using uppercase letters A through F.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Formats any basic integer type formatted as an unsigned octal integer.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Formats any basic floating point type (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) formatted using a C-style floating point format specifications.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Formats a signed value having the form <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is a single decimal digit, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is one or more decimal digits, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is exactly three decimal digits, and sign is + or -.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Formats a signed value having the form <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is one or more decimal digits. The number of digits before the decimal point depends on the magnitude of the number, and the number of digits after the decimal point depends on the requested precision.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Formats a signed value printed in f or e format, whichever is more compact for the given value and precision.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Formats a \<xref:System.Decimal*> value.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Formats any value, printed by boxing the object and using its <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Formats any value, printed with the default layout settings. Use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to print the structure of discriminated unions with internal and private representations.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|A general format specifier, requires two arguments. The first argument is a function which accepts two arguments: first, a context parameter of the appropriate type for the given formatting function (for example, a \<xref:System.IO.TextWriter*>), and second, a value to print and which either outputs or returns appropriate text.\<br />\<br /> The second argument is the particular value to print.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|A general format specifier, requires one argument: a function which accepts a context parameter of the appropriate type for the given formatting function (a \<xref:System.IO.TextWriter*>)and which either outputs or returns appropriate text. Basic integer types are <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. Basic floating point types are <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.|  
  
 The optional *width* is an integer indicating the minimal width of the result. For instance, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> prints an integer, prefixing it with spaces to fill at least 6 characters. If width is <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, then an extra integer argument is taken to specify the corresponding width.  
  
 Valid flags are described in the following table.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Specifies to add zeros instead of spaces to make up the required width.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Specifies to left-justify the result within the width specified.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Specifies to add a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> character if the number is positive (to match a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> sign for negative numbers).|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder> (space)|Specifies to add an extra space if the number is positive (to match a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> sign for negative numbers).|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Invalid.|  
  
## Type Abbreviations  
  
|Type|Description|  
|----------|-----------------|  
|type [BuilderFormat\<'T,'Result>](../vs140/printf.builderformat--t--result--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format associated with writing to a \<xref:System.Text.StringBuilder*>. The first type parameter indicates the arguments of the format operation and the last the overall return type.|  
|type [BuilderFormat\<'T>](../vs140/printf.builderformat--t--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format associated with writing to a \<xref:System.Text.StringBuilder*>. The type parameter indicates the arguments and return type of the format operation.|  
|type [StringFormat\<'T,'Result>](../vs140/printf.stringformat--t--result--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format when formatting builds a string. The first type parameter indicates the arguments of the format operation and the last the overall return type.|  
|type [StringFormat\<'T>](../vs140/printf.stringformat--t--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format when formatting builds a string. The type parameter indicates the arguments and return type of the format operation.|  
|type [TextWriterFormat\<'T,'Result>](../vs140/printf.textwriterformat--t--result--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format associated with writing to a \<xref:System.IO.TextWriter*>. The first type parameter indicates the arguments of the format operation and the last the overall return type.|  
|type [TextWriterFormat\<'T>](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format associated with writing to a \<xref:System.IO.TextWriter*>. The type parameter indicates the arguments and return type of the format operation.|  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[bprintf](../vs140/printf.bprintf--t--function--fsharp-.md)  <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Prints to a \<xref:System.Text.StringBuilder*>.|  
|[eprintf](../vs140/printf.eprintf--t--function--fsharp-.md)  <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Prints formatted output to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.|  
|[eprintfn](../vs140/printf.eprintfn--t--function--fsharp-.md)  <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Prints formatted output to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, adding a newline.|  
|[failwithf](../vs140/printf.failwithf--t--result--function--fsharp-.md)  <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Prints to a string buffer and raises an exception with the given result. Helper printers must return strings.|  
|[fprintf](../vs140/printf.fprintf--t--function--fsharp-.md) <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Prints to a text writer.|  
|[fprintfn](../vs140/printf.fprintfn--t--function--fsharp-.md)  <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Prints to a text writer, adding a newline.|  
|[kbprintf](../vs140/printf.kbprintf--result--t--function--fsharp-.md)  <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Like [bprintf](../vs140/printf.bprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md).|  
|[kfprintf](../vs140/printf.kfprintf--result--t--function--fsharp-.md)  <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Like [fprintf](../vs140/printf.fprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md).|  
|[kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md)  <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Like [printf](../vs140/printf.printf--t--function--fsharp-.md), but calls the specified function to generate the result. For example, these let the printing force a flush after all output has been entered onto the channel, but not before.|  
|[ksprintf](../vs140/printf.ksprintf--result--t--function--fsharp-.md)  <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Like [sprintf](../vs140/printf.sprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md).|  
|[printf](../vs140/printf.printf--t--function--fsharp-.md)  <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Prints formatted output to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.|  
|[printfn](../vs140/printf.printfn--t--function--fsharp-.md)  <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Prints formatted output to <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, adding a newline.|  
|[sprintf](../vs140/printf.sprintf--t--function--fsharp-.md)  <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|Prints to a string by using an internal string buffer and returns the result as a string. Helper printers must return strings.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
 Supported in: 2, 3  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)