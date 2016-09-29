---
title: "NullableOperators.( ?= )&lt;&#39;T&gt; Function (F#)"
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
  - "?= operator [F#]"
ms.assetid: 5cdc8ff6-244b-49cf-9376-69ecf249fd7c
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NullableOperators.( ?= )&lt;&#39;T&gt; Function (F#)
The `=` operator where a nullable value appears on the left.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Linq.NullableOperators  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
( ?= ) : Nullable<'T> -> 'T -> bool when 'T : equality and 'T : (new : unit ->  'T) and 'T : struct and 'T :> ValueType  
  
// Usage:  
nullableValue ?= value  
```  
  
#### Parameters  
 `nullableValue`  
 Type: <xref:System.Nullable`1*><'T>  
  
 The first input value, as a nullable value.  
  
 `value`  
 Type: 'T  
  
 The second input value.  
  
## Return Value  
 `true` if the first input value is numerically equal to the second input value.  
  
## Remarks  
 If the first value is null, then the result is `false`.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 4.0, Portable  
  
## See Also  
 [Linq.NullableOperators Module (F#)](../vs140/linq.nullableoperators-module--fsharp-.md)   
 [Microsoft.FSharp.Linq Namespace (F#)](../vs140/microsoft.fsharp.linq-namespace--fsharp-.md)