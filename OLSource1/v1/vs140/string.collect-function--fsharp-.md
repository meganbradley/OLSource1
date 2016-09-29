---
title: "String.collect Function (F#)"
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
  - "String.collect"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule.Collect"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "collect function [F#]"
  - "String.collect function [F#]"
ms.assetid: 9090ee26-f297-4abe-aa6a-8854d64ecf0f
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String.collect Function (F#)
Builds a new string whose characters are the results of applying a specified function to each of the characters of the input string and concatenating the resulting strings.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
String.collect : (char -> string) -> string -> string  
  
// Usage:  
String.collect mapping str  
```  
  
#### Parameters  
 `mapping`  
 Type: [char](../vs140/core.char-type-abbreviation--fsharp-.md) `->` [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The function to produce a string from each character of the input string.  
  
 `str`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The input string.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException*>|Thrown when the input string is null.|  
  
## Return Value  
 The concatenated string.  
  
## Remarks  
 This function is named `Collect` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use **String.collect**.  
  
 [!code[FsStrings#1](../vs140/codesnippet/FSharp/string.collect-function--fsharp-_1.fs)]  
  
 **Output**  
  
 **H e l l o   W o r l d !**    
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../vs140/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)