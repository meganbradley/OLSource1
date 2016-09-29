---
title: "OperatorIntrinsics.RangeInt16 Function (F#)"
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
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.RangeInt16"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RangeInt16 function [F#]"
ms.assetid: 7b934a55-9f37-4337-a131-81ffa9b06128
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.RangeInt16 Function (F#)
Generates a range of `int16` values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
RangeInt16 : int16 -> int16 -> int16 -> seq<int16>  
  
// Usage:  
RangeInt16 start step stop  
```  
  
#### Parameters  
 `start`  
 Type: [int16](../VS_csharp/core.int16-type-abbreviation--fsharp-.md)  
  
 The first value of the sequence.  
  
 `step`  
 Type: [int16](../VS_csharp/core.int16-type-abbreviation--fsharp-.md)  
  
 The increment between values.  
  
 `stop`  
 Type: [int16](../VS_csharp/core.int16-type-abbreviation--fsharp-.md)  
  
 The maximum value of the sequence.  
  
## Return Value  
 A sequence of enumerable values.  
  
## Remarks  
 This function is for use by compiled F# code and should not be used directly.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable, Portable  
  
## See Also  
 [Operators.OperatorIntrinsics Module (F#)](../VS_csharp/operators.operatorintrinsics-module--fsharp-.md)   
 [Microsoft.FSharp.Core.Operators Namespace (F#)](../VS_csharp/core.operators-module--fsharp-.md)