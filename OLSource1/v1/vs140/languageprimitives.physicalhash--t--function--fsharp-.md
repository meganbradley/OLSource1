---
title: "LanguagePrimitives.PhysicalHash&lt;&#39;T&gt; Function (F#)"
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
  - "LanguagePrimitives.PhysicalHash<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.PhysicalHash``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LanguagePrimitives.PhysicalHash function [F#]"
  - "PhysicalHash function [F#]"
ms.assetid: 8c93ad8b-70d2-4035-9961-ba0f84d9458b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.PhysicalHash&lt;&#39;T&gt; Function (F#)
Implements the physical hash. This function hashes on the object identity, except for value types, where it hashes on the contents.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
PhysicalHash : 'T -> int (requires reference type)  
  
// Usage:  
PhysicalHash obj  
```  
  
#### Parameters  
 `obj`  
 Type: `'T`  
  
 The input object.  
  
## Return Value  
 The hashed value.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.LanguagePrimitives Module (F#)](../vs140/core.languageprimitives-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)