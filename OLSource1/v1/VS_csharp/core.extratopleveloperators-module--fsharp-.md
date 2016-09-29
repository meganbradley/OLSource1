---
title: "Core.ExtraTopLevelOperators Module (F#)"
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
  - "Core.ExtraTopLevelOperators"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.ExtraTopLevelOperators"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ExtraTopLevelOperators module [F#]"
ms.assetid: 03c4f2ba-52e1-48cd-9f62-6d224a32b135
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Core.ExtraTopLevelOperators Module (F#)
Additional F# operators and types that are available without opening a module or namespace.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<AutoOpen>]  
module ExtraTopLevelOperators  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[( ~% )](../Topic/ExtraTopLevelOperators.\(%20~%25%3C'T%3E%20Function%20\(F%23\).md)  `: Expr<'T> -> 'T`|Special prefix operator for splicing typed expressions into quotation holes.|  
|[( ~%% )](../Topic/ExtraTopLevelOperators.\(%20~%25%25%20\)%3C'T%3E%20Function%20\(F%23\).md)  `: Expr -> 'T`|Special prefix operator for splicing untyped expressions into quotation holes.|  
|[array2D](../Topic/ExtraTopLevelOperators.array2D%3C'T%3E%20Function%20\(F%23\).md)  `: seq<#seq<'T>> -> 'T [,]`|Builds a 2D array from a sequence of sequences of elements.|  
|[async](../Topic/ExtraTopLevelOperators.async%20Function%20\(F%23\).md)  `: AsyncBuilder`|Build an asynchronous workflow using computation expression syntax.|  
|[dict](../Topic/ExtraTopLevelOperators.dict%3C'Key,'Value%3E%20Function%20\(F%23\).md)  `: seq<'Key * 'Value> -> IDictionary<'Key,'Value>`|Builds a read-only lookup table from a sequence of key/value pairs. The key objects are indexed using generic hashing and equality.|  
|[double](../Topic/ExtraTopLevelOperators.double%3C%5ET%3E%20Function%20\(F%23\).md)  `: ^T -> float`|Converts the argument to 64-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using [Parse](assetId:///M:System.Double.Parse(System.String)?qualifyHint=False&autoUpgrade=True) with [InvariantCulture](assetId:///P:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False&autoUpgrade=True) settings. Otherwise the operation requires and invokes a `ToDouble` method on the input type.|  
|[eprintf](../Topic/ExtraTopLevelOperators.eprintf%3C'T%3E%20Function%20\(F%23\).md)  `: TextWriterFormat<'T> -> 'T`|Print to `stderr` using the given format.|  
|[eprintfn](../Topic/ExtraTopLevelOperators.eprintfn%3C'T%3E%20Function%20\(F%23\).md)  `: TextWriterFormat<'T> -> 'T`|Print to `stderr` using the given format, and add a newline|  
|[failwithf](../Topic/ExtraTopLevelOperators.failwithf%3C'T,'Result%3E%20Function%20\(F%23\).md)  `: StringFormat<'T,'TResult> -> 'T`|Print to a string buffer and raise an exception with the given result. Helper printers must return strings.|  
|[fprintf](../Topic/ExtraTopLevelOperators.fprintf%3C'T%3E%20Function%20\(F%23\).md)  `: TextWriter -> TextWriterFormat<'T> -> 'T`|Print to a file using the given format|  
|[fprintfn](../Topic/ExtraTopLevelOperators.fprintfn%3C'T%3E%20Function%20\(F%23\).md)  `: TextWriter -> TextWriterFormat<'T> -> 'T`|Print to a file using the given format, and add a newline|  
|[int8](../Topic/ExtraTopLevelOperators.int8%3C%5ET%3E%20Function%20\(F%23\).md)  `: ^T -> sbyte`|Converts the argument to signed byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using [Parse](assetId:///M:System.SByte.Parse(System.String)?qualifyHint=False&autoUpgrade=True) with [InvariantCulture](assetId:///P:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False&autoUpgrade=True) settings. Otherwise the operation requires and invokes a `ToSByte` method on the input type.|  
|[printf](../Topic/ExtraTopLevelOperators.printf%3C'T%3E%20Function%20\(F%23\).md)  `: TextWriterFormat<'T> -> 'T`|Print to `stdout` using the given format.|  
|[printfn](../Topic/ExtraTopLevelOperators.printfn%3C'T%3E%20Function%20\(F%23\).md)  `: TextWriterFormat<'T> -> 'T`|Print to `stdout` using the given format, and add a newline.|  
|[set](../Topic/ExtraTopLevelOperators.set%3C'T%3E%20Function%20\(F%23\).md)  `: seq<'T> -> Set<'T>`|Builds a set from a sequence of objects. The objects are indexed using generic comparison.|  
|[single](../Topic/ExtraTopLevelOperators.single%3C%5ET%3E%20Function%20\(F%23\).md)  `: ^T -> single`|Converts the argument to 32-bit float. This is a direct conversion for all primitive numeric types. For strings, the input is converted using [Parse](assetId:///M:System.Single.Parse(System.String)?qualifyHint=False&autoUpgrade=True) with [InvariantCulture](assetId:///P:System.Globalization.CultureInfo.InvariantCulture?qualifyHint=False&autoUpgrade=True) settings. Otherwise the operation requires and invokes a `ToSingle` method on the input type.|  
|[sprintf](../Topic/ExtraTopLevelOperators.sprintf%3C'T%3E%20Function%20\(F%23\).md)  `: StringFormat<'T> -> 'T`|Print to a string using the given format.|  
|[uint8](../Topic/ExtraTopLevelOperators.uint8%3C%5ET%3E%20Function%20\(F%23\).md)  `: ^T -> byte`|Converts the argument to byte. This is a direct conversion for all primitive numeric types. For strings, the input is converted using `Byte.Parse` on strings and otherwise requires a `ToByte` method on the input type.|  
  
## Active Patterns  
  
|Active Pattern|Description|  
|--------------------|-----------------|  
|[( &#124;Lazy&#124; )](../Topic/ExtraTopLevelOperators.Lazy%3C'T%3E%20Active%20Pattern%20\(F%23\).md)  `: Lazy<'T> -> 'T`|An active pattern to force the execution of values of type [Lazy](../Topic/Control.Lazy%3C'T%3E%20Type%20Abbreviation%20\(F%23\).md).|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Core Namespace (F#)](../Topic/Microsoft.FSharp.Core%20Namespace%20\(F%23\).md)