---
title: "FSharpValue.MakeFunction Method (F#)"
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
  - "FSharpValue.MakeFunction"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpValue.MakeFunction"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpValue.MakeFunction method [F#]"
  - "MakeFunction method [F#]"
ms.assetid: 369b5863-d689-4adb-a4e9-756cc39731b4
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpValue.MakeFunction Method (F#)
Creates a typed function from object from a dynamic function implementation.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member MakeFunction : Type * (obj -> obj) -> obj  
  
// Usage:  
FSharpValue.MakeFunction (functionType, implementation)  
```  
  
#### Parameters  
 `functionType`  
 Type: <xref:System.Type*>  
  
 The function type of the implementation.  
  
 `implementation`  
 Type: [obj](../vs140/core.obj-type-abbreviation--fsharp-.md) `->` [obj](../vs140/core.obj-type-abbreviation--fsharp-.md)  
  
 The untyped lambda of the function implementation.  
  
## Return Value  
 A typed function from the given dynamic implementation.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpValue Class (F#)](../vs140/reflection.fsharpvalue-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)