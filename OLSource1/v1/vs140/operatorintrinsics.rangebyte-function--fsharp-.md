---
title: "OperatorIntrinsics.RangeByte Function (F#)"
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
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.RangeByte"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RangeByte function [F#]"
ms.assetid: 6a7e4d3e-93f4-408b-b365-bee6710e9d7e
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.RangeByte Function (F#)
Generates a range of `byte` values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
RangeByte : byte -> byte -> byte -> seq<byte>  
  
// Usage:  
RangeByte start step stop  
```  
  
#### Parameters  
 `start`  
 Type: [byte](../vs140/core.byte-type-abbreviation--fsharp-.md)  
  
 The first value in the sequence.  
  
 `step`  
 Type: [byte](../vs140/core.byte-type-abbreviation--fsharp-.md)  
  
 An increment between each value.  
  
 `stop`  
 Type: [byte](../vs140/core.byte-type-abbreviation--fsharp-.md)  
  
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