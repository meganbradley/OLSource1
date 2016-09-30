---
title: "FSharpType.MakeFunctionType Method (F#)"
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
  - "FSharpType.MakeFunctionType"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Reflection.FSharpType.MakeFunctionType"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FSharpType.MakeFunctionType method [F#]"
  - "MakeFunctionType method [F#]"
ms.assetid: 568814c9-1099-439d-abd1-de4a0b923476
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FSharpType.MakeFunctionType Method (F#)
Returns a \<xref:System.Type*> representing the F# function type with the given domain and range  
  
 **Namespace/Module Path:** Microsoft.FSharp.Reflection  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member MakeFunctionType : Type * Type -> Type  
  
// Usage:  
FSharpType.MakeFunctionType (domain, range)  
```  
  
#### Parameters  
 `domain`  
 Type: \<xref:System.Type*>  
  
 The input type of the function.  
  
 `range`  
 Type: \<xref:System.Type*>  
  
 The output type of the function.  
  
## Return Value  
 The function type with the given domain and range.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Reflection.FSharpType Class (F#)](../vs140/reflection.fsharptype-class--fsharp-.md)   
 [Microsoft.FSharp.Reflection Namespace (F#)](../vs140/microsoft.fsharp.reflection-namespace--fsharp-.md)