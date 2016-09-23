---
title: "OperatorIntrinsics.GetArraySlice2DFixed2 Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.Operators.OperatorIntrinsics.GetArraySlice2DFixed2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - GetArraySlice2DFixed2 function
ms.assetid: 2017f244-c552-44cd-87a5-ab6fdfc1fe1c
caps.latest.revision: 6
translation.priority.ht: 
  - de-de
  - ja-jp
---
# OperatorIntrinsics.GetArraySlice2DFixed2 Function (F#)
Gets a vector slice of a 2D array. The index of the second dimension is fixed.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GetArraySlice2DFixed2 : 'T [,] -> int option -> int option -> int -> 'T []  
  
// Usage:  
GetArraySlice2DFixed2 source start1 finish1 index2  
```  
  
#### Parameters  
 `source`  
 Type: `'T`[&#91;,&#93;](../vs140/core.--t--type--fsharp-4.md)  
  
 The source array.  
  
 `start1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The start index of the first dimension.  
  
 `finish1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The end index of the first dimension.  
  
 `index2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The fixed index of the second dimension.  
  
## Return Value  
 The sub array from the input indices.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Arrays (F#)](../vs140/arrays--fsharp-.md)   
 [Operators.OperatorIntrinsics Module (F#)](../vs140/operators.operatorintrinsics-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)