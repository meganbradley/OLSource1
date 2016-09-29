---
title: "FSharpValue.PreComputeUnionTagReader Method (F#)"
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
  - "FSharpValue.PreComputeUnionTagReader"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.PreComputeUnionTagReader"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PreComputeUnionTagReader method [F#]"
  - "FSharpValue.PreComputeUnionTagReader method [F#]"
ms.assetid: ca2f8c2b-59ec-4cc8-a307-cca468325de9
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.PreComputeUnionTagReader Method (F#)
Generates a function to read the tags of a union type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member PreComputeUnionTagReader : Type * ?BindingFlags -> obj -> int  
static member PreComputeUnionTagReader : Type * ?bool -> obj -> int  
  
// Usage:  
FSharpValue.PreComputeUnionTagReader (unionType)  
FSharpValue.PreComputeUnionTagReader (unionType, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpValue.PreComputeUnionTagReader (unionType, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `unionType`  
 Type: <xref:System.Type*>  
  
 The type of union to optimize reading.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Return Value  
 An optimized function to read the tags of the given union type.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)