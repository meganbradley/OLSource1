---
title: "OperatorIntrinsics.SetArraySlice4D&lt;&#39;T&gt; Function (F#)"
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
  - "OperatorIntrinsics.SetArraySlice4D<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.SetArraySlice4D``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "SetArraySlice4D function [F#]"
  - "OperatorIntrinsics.SetArraySlice4D function [F#]"
ms.assetid: 77c84741-7646-4d09-a52f-4a06f678f50c
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.SetArraySlice4D&lt;&#39;T&gt; Function (F#)
Sets a slice of an array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
SetArraySlice4D : 'T [,,,] -> int option -> int option -> int option -> int option -> int option -> int option -> int option -> int option -> 'T [,,,] -> unit  
  
// Usage:  
SetArraySlice4D target start1 finish1 start2 finish2 start3 finish3 start4 finish4 source  
```  
  
#### Parameters  
 `target`  
 Type: `'T`[&#91;,,,&#93;](../vs140/core.--t--type--fsharp-1.md)  
  
 The target array.  
  
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
  
 `start4`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The start index of the fourth dimension.  
  
 `finish4`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)[option](../vs140/core.option--t--type-abbreviation--fsharp-.md)  
  
 The end index of the fourth dimension.  
  
 `source`  
 Type: `'T`[&#91;,,,&#93;](../vs140/core.--t--type--fsharp-1.md)  
  
 The source array.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Operators.OperatorIntrinsics Module (F#)](../vs140/operators.operatorintrinsics-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)