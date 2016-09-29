---
title: "LanguagePrimitives.GenericHash&lt;&#39;T&gt; Function (F#)"
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
  - "LanguagePrimitives.GenericHash<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.GenericHash``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LanguagePrimitives.GenericHash function [F#]"
  - "GenericHash function [F#]"
ms.assetid: 68b1207f-757a-45a1-8bc3-21dc82bf24a8
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.GenericHash&lt;&#39;T&gt; Function (F#)
Hash a value according to its structure. This hash is not limited by an overall node count when hashing F# records, lists and union types.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericHash : 'T -> int  
  
// Usage:  
GenericHash obj  
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