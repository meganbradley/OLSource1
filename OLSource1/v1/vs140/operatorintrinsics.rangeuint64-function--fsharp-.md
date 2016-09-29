---
title: "OperatorIntrinsics.RangeUInt64 Function (F#)"
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
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.RangeUInt64"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RangeUInt64 function [F#]"
ms.assetid: e4dd4711-e51b-475b-89c7-f531e14bfe6c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.RangeUInt64 Function (F#)
Generates a range of uint64 values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
RangeUInt64 : uint64 -> uint64 -> uint64 -> seq<uint64>  
  
// Usage:  
RangeUInt64 start step stop  
```  
  
#### Parameters  
 `start`  
 Type: [uint64](../vs140/core.uint64-type-abbreviation--fsharp-.md)  
  
 The initial value in the sequence.  
  
 `step`  
 Type: [uint64](../vs140/core.uint64-type-abbreviation--fsharp-.md)  
  
 The increment between each value.  
  
 `stop`  
 Type: [uint64](../vs140/core.uint64-type-abbreviation--fsharp-.md)  
  
 The maximum value in the sequence.  
  
## Return Value  
 An enumerable sequence of values.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Operators.OperatorIntrinsics Module (F#)](../vs140/operators.operatorintrinsics-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../vs140/core.operators-module--fsharp-.md)