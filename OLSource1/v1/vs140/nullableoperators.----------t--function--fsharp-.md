---
title: "NullableOperators.( ?&lt;&gt;? )&lt;&#39;T&gt; Function (F#)"
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
  - "?<>? operator [F#]"
ms.assetid: 5da813d8-ee75-45b8-9ef4-146dcb6d394d
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NullableOperators.( ?&lt;&gt;? )&lt;&#39;T&gt; Function (F#)
The `<>` operator where a nullable value appears on both left and right sides.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( ?<>? ) : Nullable<'T> -> Nullable<'T> -> bool when 'T : equality and 'T : (new : unit ->  'T) and 'T : struct and 'T :> ValueType  
  
// Usage:  
 nullableValue1 ?<>? nullableValue2  
```  
  
#### Parameters  
 `nullableValue1`  
 Type: <xref:System.Nullable`1*><'T>  
  
 The first input value, as a nullable value.  
  
 `nullableValue2`  
 Type: <xref:System.Nullable`1*><'T>  
  
 The second input value, as a nullable value.  
  
## Return Value  
 True if the two input values are not numerically equal.  
  
## Remarks  
 If either of the values is null, the result is `false`.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.NullableOperators Module (F#)](../vs140/linq.nullableoperators-module--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)