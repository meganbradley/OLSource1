---
title: "LanguagePrimitives.GenericMaximum&lt;&#39;T&gt; Function (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - LanguagePrimitives.GenericMaximum<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Core.LanguagePrimitives.GenericMaximum``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - LanguagePrimitives.GenericMaximum function [F#]
  - GenericMaximum function [F#]
ms.assetid: 27a7cef8-4f85-4ad0-aa5b-6872f3216997
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# LanguagePrimitives.GenericMaximum&lt;&#39;T&gt; Function (F#)
Take the maximum of two values structurally according to the order given by [GenericComparison](../vs140/languageprimitives.genericcomparison--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Core.LanguagePrimitives  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
GenericMaximum : 'T -> 'T -> 'T (requires comparison)  
  
// Usage:  
GenericMaximum e1 e2  
```  
  
#### Parameters  
 `e1`  
 Type: `'T`  
  
 The first value.  
  
 `e2`  
 Type: `'T`  
  
 The second value.  
  
## Return Value  
 The maximum value.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Core.LanguagePrimitives Module (F#)](../vs140/core.languageprimitives-module--fsharp-.md)   
 [Microsoft.FSharp.Core Namespace (F#)](../vs140/microsoft.fsharp.core-namespace--fsharp-.md)