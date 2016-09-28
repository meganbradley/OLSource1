---
title: "FSharpValue.PreComputeTuplePropertyInfo Method (F#)"
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
  - "FSharpValue.PreComputeTuplePropertyInfo"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeTuplePropertyInfo"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue.PreComputeTuplePropertyInfo method [F#]"
  - "PreComputeTuplePropertyInfo method [F#]"
ms.assetid: 521a6f3f-6774-4392-8a81-6b15d72c3d9c
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeTuplePropertyInfo Method (F#)
Gets information that indicates how to read a field of a tuple.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member PreComputeTuplePropertyInfo : Type * int -> PropertyInfo * (Type * int) option  
  
// Usage:  
FSharpValue.PreComputeTuplePropertyInfo (tupleType, index)  
```  
  
#### Parameters  
 `tupleType`  
 Type: <xref:System.Type*>  
  
 The input tuple type.  
  
 `index`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index of the tuple element to describe.  
  
## Return Value  
 The description of the tuple element as a <xref:System.Reflection.PropertyInfo*> object and an optional type and index if the tuple is big.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)