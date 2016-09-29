---
title: "String.iteri Function (F#)"
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
  - "String.iteri"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule.IterateIndexed"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "iteri function [F#]"
  - "String.iteri function [F#]"
  - "String.IterateIndexed function [F#]"
  - "IterateIndexed function [F#]"
ms.assetid: 9f94dad5-53a2-44aa-a221-5000ccc03e5d
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String.iteri Function (F#)
Applies a specified function to each character and corresponding index in the string.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
String.iteri : (int -> char -> unit) -> string -> unit  
  
// Usage:  
String.iteri action str  
```  
  
#### Parameters  
 `action`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md) `->` [char](../VS_csharp/core.char-type-abbreviation--fsharp-.md) `->` [unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to each character and index of the string.  
  
 `str`  
 Type: [string](../VS_csharp/core.string-type-abbreviation--fsharp-.md)  
  
 The input string.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input string is null.|  
  
## Remarks  
 This function is named `IterateIndexed` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use **String.iteri**.  
  
 [!code[FsStrings#9](../VS_csharp/codesnippet/FSharp/string.iteri-function--fsharp-_1.fs)]  
  
 **Output**  
  
 **0 T**  
**1 I**  
**2 M**  
**3 E**  
**0 S**  
**1 P**  
**2 A**  
**3 C**  
**4 E**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../VS_csharp/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../VS_csharp/microsoft.fsharp.core-namespace--fsharp-.md)