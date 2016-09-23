---
title: "String.replicate Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - String.replicate
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.StringModule.Replicate
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - String.replicate function [F#]
  - replicate function [F#]
ms.assetid: 489cf6e9-e0a0-457a-9e9b-bf630a40a25b
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# String.replicate Function (F#)
Returns a string by concatenating a specified number of instances of a string.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
String.replicate : int -> string -> string  
  
// Usage:  
String.replicate count str  
```  
  
#### Parameters  
 `count`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The number of copies of the input string will be copied.  
  
 `str`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The input string.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentNullException?qualifyHint=False>|Thrown when the input string is null.|  
  
## Return Value  
 The concatenated string.  
  
## Remarks  
 This function is named `Replicate` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `String.replicate`.  
  
 [!code[FsStrings#11](../vs140/codesnippet/FSharp/string.replicate-function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **XOXOXOXOXOXOXOXOXOXO**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../vs140/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)