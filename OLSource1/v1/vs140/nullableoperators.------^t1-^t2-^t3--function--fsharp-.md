---
title: "NullableOperators.( ?%)&lt;^T1,^T2,^T3&gt; Function (F#)"
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
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "?% operator [F#]"
ms.assetid: 44297bba-1bd9-4ed2-a848-f1e1e598db87
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NullableOperators.( ?%)&lt;^T1,^T2,^T3&gt; Function (F#)
The modulus operator where a nullable value appears on the left.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( ?% ) : Nullable<^T1> -> ^T2 -> Nullable<^T3> when ^T1 with static member op_Modulus and ^T1 : (new : unit ->  ^T1) and ^T1 : struct and ^T1 :> ValueType and ^T2 with static member op_Modulus and ^T3 : (new : unit ->  ^T3) and ^T3 : struct and ^T3 :> ValueType  
  
// Usage:  
nullableValue ?% value  
```  
  
#### Parameters  
 `nullableValue`  
 Type: <xref:System.Nullable`1*><^T1>  
  
 The first input value, as a nullable value.  
  
 `value`  
 Type: ^T2  
  
 The second input value.  
  
## Return Value  
 The result of the modulus operation, as a nullable value.  
  
## Remarks  
 If the first value is null, then the return value is null.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.NullableOperators Module (F#)](../vs140/linq.nullableoperators-module--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)