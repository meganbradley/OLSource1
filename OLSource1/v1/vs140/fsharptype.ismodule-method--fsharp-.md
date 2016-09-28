---
title: "FSharpType.IsModule Method (F#)"
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
  - "FSharpType.IsModule"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType.IsModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpType.IsModule method [F#]"
  - "IsModule method [F#]"
ms.assetid: 77f65dd3-3111-4f59-8ab6-c028bc1c47e7
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpType.IsModule Method (F#)
Returns `true` if the specified type is a <xref:System.Type*> value corresponding to the compiled form of an F# module.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member IsModule : Type -> bool  
  
// Usage:  
FSharpType.IsModule (typ)  
```  
  
#### Parameters  
 `typ`  
 Type: <xref:System.Type*>  
  
 The type to check.  
  
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