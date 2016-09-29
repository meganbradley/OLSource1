---
title: "FSharpValue.MakeUnion Method (F#)"
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
  - "FSharpValue.MakeUnion"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.MakeUnion"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MakeUnion method [F#]"
  - "FSharpValue.MakeUnion method [F#]"
ms.assetid: 70e0087b-3f79-4b1e-93a2-82514ecae0f7
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.MakeUnion Method (F#)
Create a union case value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member MakeUnion : UnionCaseInfo * obj [] * ?BindingFlags -> obj  
static member MakeUnion : UnionCaseInfo * obj [] * ?bool -> obj  
// Usage:  
FSharpValue.MakeUnion (unionCase, args)  
FSharpValue.MakeUnion (unionCase, args, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpValue.MakeUnion (unionCase, args, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `unionCase`  
 Type: [UnionCaseInfo](../vs140/reflection.unioncaseinfo-class--fsharp-.md)  
  
 The description of the union case to create.  
  
 `args`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The array of arguments to construct the given case.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Return Value  
 The constructed union case.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)