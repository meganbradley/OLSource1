---
title: "LanguagePrimitives.GenericLimitedHash&lt;&#39;T&gt; Function (F#)"
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
  - "LanguagePrimitives.GenericLimitedHash<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.GenericLimitedHash``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LanguagePrimitives.GenericLimitedHash function [F#]"
  - "GenericLimitedHash function [F#]"
ms.assetid: 1ada2a57-433f-4fa7-b8ce-1aa010d626c7
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.GenericLimitedHash&lt;&#39;T&gt; Function (F#)
Hash a value according to its structure. Use the given limit to restrict the hash when hashing F# records, lists and union types.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericLimitedHash : int -> 'T -> int  
  
// Usage:  
GenericLimitedHash limit obj  
```  
  
#### Parameters  
 `limit`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The limit on the number of nodes.  
  
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