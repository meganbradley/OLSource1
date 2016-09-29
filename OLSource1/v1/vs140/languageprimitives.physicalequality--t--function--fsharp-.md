---
title: "LanguagePrimitives.PhysicalEquality&lt;&#39;T&gt; Function (F#)"
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
  - "LanguagePrimitives.PhysicalEquality<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.PhysicalEquality``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "PhysicalEquality function [F#]"
  - "LanguagePrimitives.PhysicalEquality function [F#]"
ms.assetid: 1783ed93-63f4-4936-832f-4bf0db6e3586
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.PhysicalEquality&lt;&#39;T&gt; Function (F#)
Implements reference, or *physical* equality.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
PhysicalEquality : 'T -> 'T -> bool (requires reference type)  
  
// Usage:  
PhysicalEquality e1 e2  
```  
  
#### Parameters  
 `e1`  
 Type: `'T`  
  
 The first value.  
  
 `e2`  
 Type: `'T`  
  
 The second value.  
  
## Return Value  
 `true` if boxed versions of the inputs are reference-equal, or if both are primitive numeric types and the implementation of <xref:System.Object.Equals*> for the type of the first argument returns `true` on the boxed version of the inputs.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library VersionsF# Core Library Versions**  
  
 Supported in: 2.0, 4.0, PortablePortable2.0, 4.0, Portable  
  
## See Also  
 [Core.LanguagePrimitives Module (F#)](../vs140/core.languageprimitives-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)