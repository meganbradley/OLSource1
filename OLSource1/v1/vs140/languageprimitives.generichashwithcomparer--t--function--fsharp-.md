---
title: "LanguagePrimitives.GenericHashWithComparer&lt;&#39;T&gt; Function (F#)"
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
  - "LanguagePrimitives.GenericHashWithComparer<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Core.LanguagePrimitives.GenericHashWithComparer``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "GenericHashWithComparer function [F#]"
  - "LanguagePrimitives.GenericHashWithComparer function [F#]"
ms.assetid: 9bd694ff-6755-4004-9f8f-8d2d93ac582b
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# LanguagePrimitives.GenericHashWithComparer&lt;&#39;T&gt; Function (F#)
Recursively hash a part of a value according to its structure.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericHashWithComparer : IEqualityComparer -> 'T -> int  
  
// Usage:  
GenericHashWithComparer comparer obj  
```  
  
#### Parameters  
 `comparer`  
 Type: \<xref:System.Collections.IEqualityComparer*>  
  
 The comparison function.  
  
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