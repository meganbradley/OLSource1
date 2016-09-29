---
title: "OperatorIntrinsics.GetArraySlice3D&lt;&#39;T&gt; Function (F#)"
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
  - "OperatorIntrinsics.GetArraySlice3D<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.GetArraySlice3D``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "OperatorIntrinsics.GetArraySlice3D function [F#]"
  - "GetArraySlice3D function [F#]"
ms.assetid: 304e787f-3abe-4c6e-bfac-295fcbef3a98
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.GetArraySlice3D&lt;&#39;T&gt; Function (F#)
Gets a slice of an array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GetArraySlice3D : 'T [,,] -> int option -> int option -> int option -> int option -> int option -> int option -> 'T [,,]  
  
// Usage:  
GetArraySlice3D source start1 finish1 start2 finish2 start3 finish3  
```  
  
#### Parameters  
 `source`  
 Type: `'T`[&#91;,,&#93;](../vs140/core.--t--type--fsharp-3.md)  
  
 The source array.  
  
 `start1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The start index of the first dimension.  
  
 `finish1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The end index of the first dimension.  
  
 `start2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The start index of the second dimension.  
  
 `finish2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The end index of the second dimension.  
  
 `start3`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The start index of the third dimension.  
  
 `finish3`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The end index of the third dimension.  
  
## Return Value  
 The three dimensional sub array from the given indices.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Operators.OperatorIntrinsics Module (F#)](../vs140/operators.operatorintrinsics-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)