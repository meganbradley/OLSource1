---
title: "FSharpValue.PreComputeUnionConstructor Method (F#)"
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
  - "FSharpValue.PreComputeUnionConstructor"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeUnionConstructor"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PreComputeUnionConstructor method [F#]"
  - "FSharpValue.PreComputeUnionConstructor method [F#]"
ms.assetid: feaae316-29f9-437d-b063-0f6f775ee96b
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeUnionConstructor Method (F#)
Generates a function for constructing a discriminated union value for a particular union case.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member PreComputeUnionConstructor : UnionCaseInfo * ?BindingFlags -> obj [] -> obj  
static member PreComputeUnionConstructor : UnionCaseInfo * ?bool -> obj [] -> obj  
  
// Usage:  
FSharpValue.PreComputeUnionConstructor (unionCase)  
FSharpValue.PreComputeUnionConstructor (unionCase, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpValue.PreComputeUnionConstructor (unionCase, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `unionCase`  
 Type: [UnionCaseInfo](../vs140/reflection.unioncaseinfo-class--fsharp-.md)  
  
 The description of the union case.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Return Value  
 A function for constructing values of the given union case.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)