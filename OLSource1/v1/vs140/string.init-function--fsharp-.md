---
title: "String.init Function (F#)"
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
  - "String.init"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.StringModule.Initialize"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "init function [F#]"
  - "String.Initialize function [F#]"
  - "String.init function [F#]"
  - "Initialize function [F#]"
ms.assetid: 2d42d3cd-a278-4dbf-8db5-c9433e312b08
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String.init Function (F#)
Creates a new string whose characters are the results of applying a specified function to each index and concatenating the resulting strings.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.String  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
String.init : int -> (int -> string) -> string  
  
// Usage:  
String.init count initializer  
```  
  
#### Parameters  
 `count`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The number of strings to initialize.  
  
 `initializer`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `->` [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The function to take an index and produce a string to be concatenated with the others.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when `count` is negative.|  
  
## Return Value  
 The constructed string.  
  
## Remarks  
 This function is named `Initialize` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `String.init`.  
  
 [!code[FsStrings#5](../vs140/codesnippet/FSharp/string.init-function--fsharp-_1.fs)]  
  
 **Output**  
  
 **0123456789**  
**ABCDEFGHIJKLMNOPQRSTUVWXYZ**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.String Module (F#)](../vs140/core.string-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)