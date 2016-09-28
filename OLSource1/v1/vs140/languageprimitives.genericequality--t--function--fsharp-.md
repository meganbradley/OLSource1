---
title: "LanguagePrimitives.GenericEquality&lt;&#39;T&gt; Function (F#)"
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
  - "LanguagePrimitives.GenericEquality<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.GenericEquality``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GenericEquality function [F#]"
  - "LanguagePrimitives.GenericEquality function [F#]"
ms.assetid: 68bf55cb-fd55-4883-90e7-98df080d8938
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.GenericEquality&lt;&#39;T&gt; Function (F#)
Compare two values for equality using partial equivalence relation semantics ([nan] <> [nan])  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericEquality : 'T -> 'T -> bool (requires equality)  
  
// Usage:  
GenericEquality e1 e2  
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