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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.Printf Module (F#)
Extensible `printf`-style formatting for numbers and other datatypes.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Printf  
```  
  
## Remarks  
 Format specifications are strings with `%` markers indicating format placeholders. Format placeholders consist of:  `%[flags][width][.precision][type]` where the type is interpreted as in the following table:  
  
|Type|Description|  
|----------|-----------------|  
|`%b`|Formats a `bool`, formatted as `true` or `false`.|  
|`%c`|Formats a character.|  
|`%s`|Formats a `string`, formatted as its contents, without interpreting any escape characters.|  
|`%d, %i`|Formats any basic integer type formatted as a decimal integer, signed if the basic integer type is signed.|  
|`%u`|Formats any basic integer type formatted as an unsigned decimal integer.|  
|`%x`|Formats any basic integer type formatted as an unsigned hexadecimal integer, using lowercase letters a through f.|  
|`%X`|Formats any basic integer type formatted as an unsigned hexadecimal integer, using uppercase letters A through F.|  
|`%o`|Formats any basic integer type formatted as an unsigned octal integer.|  
|`%e, %E, %f, %F, %g, %G`|Formats any basic floating point type (`float`, `float32`) formatted using a C-style floating point format specifications.|  
|`%e, %E`|Formats a signed value having the form `[-]d.dddde[sign]ddd` where `d` is a single decimal digit, `dddd` is one or more decimal digits, `ddd` is exactly three decimal digits, and sign is + or -.|  
|`%f`|Formats a signed value having the form `[-]dddd.dddd`, where `dddd` is one or more decimal digits. The number of digits before the decimal point depends on the magnitude of the number, and the number of digits after the decimal point depends on the requested precision.|  
|`%g, %G`|Formats a signed value printed in f or e format, whichever is more compact for the given value and precision.|  
|`%M`|Formats a <xref:System.Decimal*> value.|  
|`%O`|Formats any value, printed by boxing the object and using its `ToString` method.|  
|`%A, %+A`|Formats any value, printed with the default layout settings. Use `%+A` to print the structure of discriminated unions with internal and private representations.|  
|`%a`|A general format specifier, requires two arguments. The first argument is a function which accepts two arguments: first, a context parameter of the appropriate type for the given formatting function (for example, a <xref:System.IO.TextWriter*>), and second, a value to print and which either outputs or returns appropriate text.<br /><br /> The second argument is the particular value to print.|  
|`%t`|A general format specifier, requires one argument: a function which accepts a context parameter of the appropriate type for the given formatting function (a <xref:System.IO.TextWriter*>)and which either outputs or returns appropriate text. Basic integer types are `byte`, `sbyte`, `int16`, `uint16`, `int32`, `uint32`, `int64`, `uint64`, `nativeint`, and `unativeint`. Basic floating point types are `float` and `float32`.|  
  
 The optional *width* is an integer indicating the minimal width of the result. For instance, `%6d` prints an integer, prefixing it with spaces to fill at least 6 characters. If width is `*`, then an extra integer argument is taken to specify the corresponding width.  
  
 Valid flags are described in the following table.  
  
|||  
|-|-|  
|`0`|Specifies to add zeros instead of spaces to make up the required width.|  
|`-`|Specifies to left-justify the result within the width specified.|  
|`+`|Specifies to add a `+` character if the number is positive (to match a `-` sign for negative numbers).|  
|`' '` (space)|Specifies to add an extra space if the number is positive (to match a `-` sign for negative numbers).|  
|`#`|Invalid.|  
  
## Type Abbreviations  
  
|Type|Description|  
|----------|-----------------|  
|type [BuilderFormat<'T,'Result>](../vs140/printf.builderformat--t--result--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format associated with writing to a <xref:System.Text.StringBuilder*>. The first type parameter indicates the arguments of the format operation and the last the overall return type.|  
|type [BuilderFormat<'T>](../vs140/printf.builderformat--t--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format associated with writing to a <xref:System.Text.StringBuilder*>. The type parameter indicates the arguments and return type of the format operation.|  
|type [StringFormat<'T,'Result>](../vs140/printf.stringformat--t--result--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format when formatting builds a string. The first type parameter indicates the arguments of the format operation and the last the overall return type.|  
|type [StringFormat<'T>](../vs140/printf.stringformat--t--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format when formatting builds a string. The type parameter indicates the arguments and return type of the format operation.|  
|type [TextWriterFormat<'T,'Result>](../vs140/printf.textwriterformat--t--result--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format associated with writing to a <xref:System.IO.TextWriter*>. The first type parameter indicates the arguments of the format operation and the last the overall return type.|  
|type [TextWriterFormat<'T>](../vs140/printf.textwriterformat--t--type-abbreviation--fsharp-.md)|Represents a statically-analyzed format associated with writing to a <xref:System.IO.TextWriter*>. The type parameter indicates the arguments and return type of the format operation.|  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[bprintf](../vs140/printf.bprintf--t--function--fsharp-.md)  `: StringBuilder -> BuilderFormat<'T> -> 'T`|Prints to a <xref:System.Text.StringBuilder*>.|  
|[eprintf](../vs140/printf.eprintf--t--function--fsharp-.md)  `: TextWriterFormat<'T> -> 'T`|Prints formatted output to `stderr`.|  
|[eprintfn](../vs140/printf.eprintfn--t--function--fsharp-.md)  `: TextWriterFormat<'T> -> 'T`|Prints formatted output to `stderr`, adding a newline.|  
|[failwithf](../vs140/printf.failwithf--t--result--function--fsharp-.md)  `: StringFormat<'T,'Result> -> 'T`|Prints to a string buffer and raises an exception with the given result. Helper printers must return strings.|  
|[fprintf](../vs140/printf.fprintf--t--function--fsharp-.md) `: TextWriter -> TextWriterFormat<'T> -> 'T`|Prints to a text writer.|  
|[fprintfn](../vs140/printf.fprintfn--t--function--fsharp-.md)  `: TextWriter -> TextWriterFormat<'T> -> 'T`|Prints to a text writer, adding a newline.|  
|[kbprintf](../vs140/printf.kbprintf--result--t--function--fsharp-.md)  `: (unit -> 'Result) -> StringBuilder -> BuilderFormat<'T,'Result> -> 'T`|Like [bprintf](../vs140/printf.bprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md).|  
|[kfprintf](../vs140/printf.kfprintf--result--t--function--fsharp-.md)  `: (unit -> 'Result) -> TextWriter -> TextWriterFormat<'T,'Result> -> 'T`|Like [fprintf](../vs140/printf.fprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md).|  
|[kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md)  `: (string -> 'Result) -> StringFormat<'T,'Result> -> 'T`|Like [printf](../vs140/printf.printf--t--function--fsharp-.md), but calls the specified function to generate the result. For example, these let the printing force a flush after all output has been entered onto the channel, but not before.|  
|[ksprintf](../vs140/printf.ksprintf--result--t--function--fsharp-.md)  `: (string -> 'Result) -> StringFormat<'T,'Result> -> 'T`|Like [sprintf](../vs140/printf.sprintf--t--function--fsharp-.md), but calls the specified function to generate the result. See [kprintf](../vs140/printf.kprintf--result--t--function--fsharp-.md).|  
|[printf](../vs140/printf.printf--t--function--fsharp-.md)  `: TextWriterFormat<'T> -> 'T`|Prints formatted output to `stdout`.|  
|[printfn](../vs140/printf.printfn--t--function--fsharp-.md)  `: TextWriterFormat<'T> -> 'T`|Prints formatted output to `stdout`, adding a newline.|  
|[sprintf](../vs140/printf.sprintf--t--function--fsharp-.md)  `: StringFormat<'T> -> 'T`|Prints to a string by using an internal string buffer and returns the result as a string. Helper printers must return strings.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
 Supported in: 2, 3  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)