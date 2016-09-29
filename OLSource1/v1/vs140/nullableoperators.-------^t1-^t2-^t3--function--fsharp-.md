---
title: "NullableOperators.( *? )&lt;^T1,^T2,^T3&gt; Function (F#)"
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
  - "*? operator [F#]"
ms.assetid: 04c47870-de7b-480d-98a0-f47593b4ffac
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NullableOperators.( *? )&lt;^T1,^T2,^T3&gt; Function (F#)
The multiplication operator where a nullable value appears on the right.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( *? ) : ^T1 -> Nullable<^T2> -> Nullable<^T3> when ^T1 with static member op_Multiply and ^T2 with static member op_Multiply and ^T2 : (new : unit ->  ^T2) and ^T2 : struct and ^T2 :> ValueType and ^T3 : (new : unit ->  ^T3) and ^T3 : struct and ^T3 :> ValueType  
  
// Usage:  
 *?   
```  
  
#### Parameters  
 `value`  
 Type: ^T1  
  
 The first input value.  
  
 `nullableValue`  
 Type: <xref:System.Nullable`1*><^T2>  
  
 The second input value, as a nullable value.  
  
## Return Value  
 The result of the multiplication, as a nullable value.  
  
## Remarks  
 If the second value is null, then the return value is null.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.NullableOperators Module (F#)](../vs140/linq.nullableoperators-module--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)