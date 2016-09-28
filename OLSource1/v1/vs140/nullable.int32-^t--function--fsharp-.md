---
title: "Nullable.int32&lt;^T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Linq.Nullable.int32"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Nullable.int32 function [F#]"
ms.assetid: c6790ad2-bab4-49be-84ba-16dee88090db
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable.int32&lt;^T&gt; Function (F#)
Converts the argument to signed 32-bit integer ([int32](../vs140/core.int32-type-abbreviation--fsharp-.md)). This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.Nullable  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
int32 : Nullable<^T> -> Nullable<int32> when ^T with static member op_Explicit and ^T : (new : unit ->  ^T) and ^T : struct and ^T :> ValueType  
  
// Usage:  
Nullable.int32 value  
```  
  
#### Parameters  
 `value`  
 Type: <xref:System.Nullable`1*><^T>  
  
 The input value.  
  
## Return Value  
 The converted int32.  
  
## Remarks  
 This function is named `ToInt32` in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.Nullable Module (F#)](../vs140/linq.nullable-module--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Operators.int32<^T> Function (F#)](../vs140/operators.int32-^t--function--fsharp-.md)