---
title: "FSharpType.IsExceptionRepresentation Method (F#)"
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
  - "FSharpType.IsExceptionRepresentation"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType.IsExceptionRepresentation"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IsExceptionRepresentation method [F#]"
  - "FSharpType.IsExceptionRepresentation method [F#]"
ms.assetid: 6ca9be2b-2f54-40b4-90a0-3c5dc623f116
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpType.IsExceptionRepresentation Method (F#)
Returns `true` if the specified type is a representation of an F# exception declaration.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member IsExceptionRepresentation : Type * ?BindingFlags -> bool  
static member IsExceptionRepresentation : Type * ?bool -> bool  
  
// Usage:  
FSharpType.IsExceptionRepresentation (exceptionType)  
FSharpType.IsExceptionRepresentation (exceptionType, bindingFlags = bindingFlags)  
  
open FSharpReflectionExtensions  
FSharpType.IsExceptionRepresentation (exceptionType, allowAccessToPrivateRepresentation = false)  
```  
  
#### Parameters  
 `exceptionType`  
 Type: <xref:System.Type*>  
  
 The type to check.  
  
 `bindingFlags`  
 Type: <xref:System.Reflection.BindingFlags*>  
  
 Optional binding flags.  
  
 `allowAccessToPrivateRepresentation`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Optional flag that denotes accessibility of the private representation.  
  
## Return Value  
 Returns `true` if the type checked is an F# exception.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpType Class (F#)](../vs140/reflection.fsharptype-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)