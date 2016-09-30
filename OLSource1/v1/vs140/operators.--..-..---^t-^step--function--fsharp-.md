---
title: "Operators.( .. .. )&lt;^T,^Step&gt; Function (F#)"
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
  - "Operators.( .. .. )<^T,^Step>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.Operators.op_RangeStep``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - ".. .. operator [F#]"
  - "Operators.op_RangeStep operator [F#]"
  - "op_RangeStep operator [F#]"
  - "Operators.( .. .. ) operator [F#]"
ms.assetid: 57cae22a-bf12-4872-b7d9-e4e0b5ff6b93
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operators.( .. .. )&lt;^T,^Step&gt; Function (F#)
The standard overloaded skip range operator, for example, `[n..skip..m]` for lists, `seq {n..skip..m}` for sequences.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.Operators  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( .. .. ) : ^T -> ^Step -> ^T -> seq<^T> (requires ^T with static member (+) and ^Step with static member (+) and ^Step with static member Zero)  
  
// Usage:  
start .. step .. finish  
```  
  
#### Parameters  
 `start`  
 Type: `^T`  
  
 The start value of the range.  
  
 `step`  
 Type: `^Step`  
  
 The step value of the range.  
  
 `finish`  
 Type: `^T`  
  
 The end value of the range.  
  
## Return Value  
 The sequence spanning the range using the specified step size.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.Operators Module (F#)](../vs140/core.operators-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)