---
title: "FSharpValue.PreComputeUnionConstructorInfo Method (F#)"
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
  - "FSharpValue.PreComputeUnionConstructorInfo"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeUnionConstructorInfo"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PreComputeUnionConstructorInfo method [F#]"
  - "FSharpValue.PreComputeUnionConstructorInfo method [F#]"
ms.assetid: bfe97595-394d-44e8-b4e8-4f6faf00ff10
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeUnionConstructorInfo Method (F#)
A method that constructs objects of the given case.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member PreComputeUnionConstructorInfo : UnionCaseInfo * ?BindingFlags -> MethodInfo  
static member PreComputeUnionConstructorInfo : UnionCaseInfo * ?bool -> MethodInfo  
  
// Usage:  
FSharpValue.PreComputeUnionConstructorInfo (unionCase)  
FSharpValue.PreComputeUnionConstructorInfo (unionCase, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions;  
FSharpValue.PreComputeUnionConstructorInfo (unionCase, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `unionCase`  
 Type: [UnionCaseInfo](../VS_csharp/reflection.unioncaseinfo-class--fsharp-.md)  
  
 The description of the union case.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Return Value  
 The description of the constructor of the given union case as a <xref:System.Reflection.MethodInfo*> object.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../VS_csharp/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../VS_csharp/microsoft.fsharp.reflection-namespace--fsharp-.md)