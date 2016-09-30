---
title: "FSharpType.IsRecord Method (F#)"
ms.custom: na
ms.date: "09/23/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "FSharpType.IsRecord"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType.IsRecord"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IsRecord method [F#]"
  - "FSharpType.IsRecord method [F#]"
ms.assetid: bb3b2a3b-51b5-4a8b-82fe-d61282becead
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpType.IsRecord Method (F#)
Returns `true` if the specified type is a representation of an F# record type.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member IsRecord : Type * ?BindingFlags -> bool  
static member IsRecord : Type * ?bool -> bool  
  
// Usage:  
FSharpType.IsRecord (typ)  
FSharpType.IsRecord (typ, bindingFlags = bindingFlags)  
open FSharpReflectionExtensions  
FSharpType.IsRecord (type, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `typ`  
 Type: \<xref:System.Type*>  
  
 The type to check.  
  
 `bindingFlags`  
 Type: \<xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
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
 [Reflection.FSharpType Class (F#)](../vs140/reflection.fsharptype-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)