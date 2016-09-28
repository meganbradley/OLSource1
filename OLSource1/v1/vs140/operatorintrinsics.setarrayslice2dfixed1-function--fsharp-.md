---
title: "OperatorIntrinsics.SetArraySlice2DFixed1 Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.SetArraySlice2DFixed1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "SetArraySlice2DFixed1 function"
ms.assetid: cf3ce860-1004-4d55-81af-173252c3c398
caps.latest.revision: 6
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.SetArraySlice2DFixed1 Function (F#)
Sets a vector slice of a 2D array. The index of the first dimension is fixed.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
SetArraySlice2DFixed1 : 'T [,] -> int -> int option -> int option -> 'T [] -> unit  
  
// Usage:  
SetArraySlice2DFixed1 target index1 start2 finish2 source  
```  
  
#### Parameters  
 `target`  
 Type: `'T`[&#91;,&#93;](../vs140/core.--t--type--fsharp-4.md)  
  
 The target array.  
  
 `index1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The start index of the first dimension.  
  
 `start2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The start index of the second dimension.  
  
 `finish2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The end index of the second dimension.  
  
 `source`  
 Type: `'T`[&#91;&#93;](../vs140/core.--t--type--fsharp-4.md)  
  
 The source array.  
  
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