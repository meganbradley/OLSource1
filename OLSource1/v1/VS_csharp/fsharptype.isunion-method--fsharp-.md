---
title: "FSharpType.IsUnion Method (F#)"
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
  - "FSharpType.IsUnion"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType.IsUnion"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IsUnion method [F#]"
  - "FSharpType.IsUnion method [F#]"
ms.assetid: 529743e4-c456-429f-934f-ab8610166abb
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpType.IsUnion Method (F#)
Returns `true` if the specified type is a representation of an F# union type or the runtime type of a value of that type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member IsUnion : Type * ?BindingFlags -> bool  
static member IsUnion : Type * ?bool -> bool  
  
// Usage:  
FSharpType.IsUnion (typ)  
FSharpType.IsUnion (typ, bindingFlags = bindingFlags)  
open FSharpReflectionExtensions  
FSharpType.IsUnion (type, allowAccesstoPrivateRepresentation = false)  
```  
  
#### Parameters  
 `typ`  
 Type: <xref:System.Type*>  
  
 The type to check.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>[option](../VS_csharp/core.option--t--union--fsharp-.md)  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Return Value  
 Returns `true` if the type check succeeds.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpType Class (F#)](../VS_csharp/reflection.fsharptype-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../VS_csharp/microsoft.fsharp.reflection-namespace--fsharp-.md)