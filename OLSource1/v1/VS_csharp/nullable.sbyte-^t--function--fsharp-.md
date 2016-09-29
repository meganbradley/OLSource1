---
title: "Nullable.sbyte&lt;^T&gt; Function (F#)"
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
  - "Microsoft.FSharp.Linq.Nullable.sbyte"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Nullable.sbyte function [F#]"
ms.assetid: 44043d32-324b-4017-8546-016871776112
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable.sbyte&lt;^T&gt; Function (F#)
Converts the argument to signed byte ([sbyte](../VS_csharp/core.sbyte-type-abbreviation--fsharp-.md)). This is a direct conversion for all primitive numeric types. The operation requires an appropriate static conversion method on the input type.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.Nullable  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
sbyte : Nullable<^T> -> Nullable<sbyte> when ^T with static member op_Explicit and ^T : (new : unit ->  ^T) and ^T : struct and ^T :> ValueType  
  
// Usage:  
Nullable.sbyte value  
```  
  
#### Parameters  
 `value`  
 Type: <xref:System.Nullable`1*><^T>  
  
 The input value.  
  
## Return Value  
 The converted sbyte.  
  
## Remarks  
 This function is named `ToSByte` in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.Nullable Module (F#)](../VS_csharp/linq.nullable-module--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../VS_csharp/microsoft.fsharp.linq-namespace--fsharp-.md)   
 [Operators.sbyte<^T> Function (F#)](../VS_csharp/operators.sbyte-^t--function--fsharp-.md)