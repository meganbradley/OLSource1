---
title: "LanguagePrimitives.GenericEqualityER&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.GenericEqualityER"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GenericEqualityER function [F#]"
ms.assetid: b0018d4f-24dd-44f8-bb68-abf8f52ad763
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.GenericEqualityER&lt;&#39;T&gt; Function (F#)
Compare two values for equality using equivalence relation semantics ([nan] = [nan]).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericEqualityER : 'T -> 'T -> bool (requires equality)  
  
// Usage:  
GenericEqualityER e1 e2  
```  
  
#### Parameters  
 `e1`  
 Type: `'T`  
  
 The first value.  
  
 `e2`  
 Type: `'T`  
  
 The second value.  
  
## Return Value  
 The result of the comparison.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.LanguagePrimitives Module (F#)](../vs140/core.languageprimitives-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)