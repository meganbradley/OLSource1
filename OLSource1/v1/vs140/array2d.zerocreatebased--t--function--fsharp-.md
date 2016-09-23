---
title: "Array2D.zeroCreateBased&lt;&#39;T&gt; Function (F#)"
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
  - Array2D.zeroCreateBased<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.Array2DModule.ZeroCreateBased``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Array2D.zeroCreateBased function [F#]
  - zeroCreateBased function [F#]
ms.assetid: 5b67f6b5-1dc4-4952-a8cf-241f3cc95124
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array2D.zeroCreateBased&lt;&#39;T&gt; Function (F#)
Creates a based array where the entries are initially [Unchecked.defaultof<'T>](../vs140/unchecked.defaultof--t--type-function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array2D  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array2D.zeroCreateBased : int -> int -> int -> int -> 'T [,]  
  
// Usage:  
Array2D.zeroCreateBased base1 base2 length1 length2  
```  
  
#### Parameters  
 `base1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The base for the first dimension of the array.  
  
 `base2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The base for the second dimension of the array.  
  
 `length1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the first dimension of the array.  
  
 `length2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the second dimension of the array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException?qualifyHint=False>|Thrown when `base1`, `base2`, `length1`, or `length2` is negative.|  
  
## Return Value  
 The created array.  
  
## Remarks  
 This function is named `ZeroCreateBased` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 [Collections.Array2D Module (F#)](../vs140/collections.array2d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)