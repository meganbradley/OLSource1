---
title: "OperatorIntrinsics.RangeChar Function (F#)"
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
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.RangeChar"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RangeChar function [F#]"
ms.assetid: 720a3896-38c6-464a-bff7-7509095fcf68
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.RangeChar Function (F#)
Generates a range of `char` values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
RangeChar : char -> char -> seq<char>  
  
// Usage:  
RangeChar start stop  
```  
  
#### Parameters  
 `start`  
 Type: [char](../vs140/core.char-type-abbreviation--fsharp-.md)  
  
 The first value in the sequence.  
  
 `stop`  
 Type: [char](../vs140/core.char-type-abbreviation--fsharp-.md)  
  
 The last value in the sequence.  
  
## Return Value  
 An enumerable sequence of `char` values.  
  
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