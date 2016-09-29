---
title: "Nullable.unativeint&lt;^T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Linq.Nullable.unativeint"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Nullable.unativeint function [F#]"
ms.assetid: 85721b5a-d241-4586-bd12-ec81547a3f7e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable.unativeint&lt;^T&gt; Function (F#)
Converts the argument to unsigned native integer ([unativeint](../VS_csharp/core.unativeint-type-abbreviation--fsharp-.md)) using a direct conversion for all primitive numeric types. Otherwise, the operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.Nullable  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
unativeint : Nullable<^T> -> Nullable<unativeint> when ^T with static member op_Explicit and ^T : (new : unit ->  ^T) and ^T : struct and ^T :> ValueType  
  
// Usage:  
Nullable.unativeint value  
```  
  
#### Parameters  
 `value`  
 Type: <xref:System.Nullable`1*><^T>  
  
 The input value.  
  
## Return Value  
 The converted unativeint.  
  
## Remarks  
 This function is named `ToUIntPtr` in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.Nullable Module (F#)](../VS_csharp/linq.nullable-module--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../VS_csharp/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Operators.unativeint<^T> Function (F#)](../VS_csharp/operators.unativeint-^t--function--fsharp-.md)