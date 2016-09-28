---
title: "OperatorIntrinsics.RangeStepGeneric&lt;&#39;Step,&#39;T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Core.Operators.OperatorIntrinsics.RangeStepGeneric"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RangeStepGeneric function [F#]"
ms.assetid: f3faecb8-24d4-435a-b59c-69c039397084
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OperatorIntrinsics.RangeStepGeneric&lt;&#39;Step,&#39;T&gt; Function (F#)
Generates a range of values using the given zero, add, start, step and stop values.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators.OperatorIntrinsics  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
RangeStepGeneric : 'Step -> ('T -> 'Step -> 'T) -> 'T -> 'Step -> 'T -> seq<'T>  
  
// Usage:  
RangeStepGeneric zero add start step stop  
```  
  
#### Parameters  
 `zero`  
 Type: `'Step`  
  
 The zero value for the step type.  
  
 `add`  
 Type: `'T -> 'Step -> 'T`  
  
 An addition function that adds a value and the step to produce another value.  
  
 `start`  
 Type: `'T`  
  
 The starting value.  
  
 `step`  
 Type: `'Step`  
  
 The increment to the value on each iteration.  
  
 `stop`  
 Type: `'T`  
  
 The final value.  
  
## Return Value  
 An enumerable sequence of values starting with `start`, incrementing by `step`, and ending with `stop`.  
  
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