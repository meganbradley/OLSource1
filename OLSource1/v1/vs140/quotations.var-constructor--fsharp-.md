---
title: "Quotations.Var Constructor (F#)"
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
  - "FSharpVar.FSharpVar"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Quotations.FSharpVar.#ctor"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Var constructor [F#]"
ms.assetid: 15bacd28-8c79-42e2-b630-6ed7e594ef04
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Quotations.Var Constructor (F#)
Creates a new variable with the given name, type and mutability.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Quotations  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
new Var : string * Type * ?bool -> Var  
  
// Usage:  
new Var (name, typ)  
new Var (name, typ, isMutable = isMutable)  
```  
  
#### Parameters  
 `name`  
 Type: [string](../vs140/core.string-type-abbreviation--fsharp-.md)  
  
 The declared name of the variable.  
  
 `typ`  
 Type: <xref:System.Type*>  
  
 The type associated with the variable.  
  
 `isMutable`  
 Type: [bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 Indicates if the variable represents a mutable storage location. The default value is `false`.  
  
## Return Value  
 The created variable.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Quotations.Var Class (F#)](../vs140/quotations.var-class--fsharp-.md)   
 [Microsoft.FSharp.Quotations Namespace (F#)](../vs140/microsoft.fsharp.quotations-namespace--fsharp-.md)