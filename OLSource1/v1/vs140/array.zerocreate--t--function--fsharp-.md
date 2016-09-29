---
title: "Array.zeroCreate&lt;&#39;T&gt; Function (F#)"
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
  - "Array.zeroCreate<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.ZeroCreate``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "zeroCreate function [F#]"
  - "Array.zeroCreate function [F#]"
ms.assetid: fa5b8e7a-1b5b-411c-8622-b58d7a14d3b2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.zeroCreate&lt;&#39;T&gt; Function (F#)
Creates an array where the entries are initially the default value [Unchecked.defaultof<'T>](../vs140/unchecked.defaultof--t--type-function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.zeroCreate : int -> 'T []  
  
// Usage:  
Array.zeroCreate count  
```  
  
#### Parameters  
 `count`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the array to create.  
  
## Return Value  
 The created array.  
  
## Remarks  
 This function is named `ZeroCreate` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of `Array.zeroCreate`.  
  
 [!code[FsArrays#4](../vs140/codesnippet/FSharp/array.zerocreate--t--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)