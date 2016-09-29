---
title: "HashIdentity.Structural&lt;&#39;T&gt; Type Function (F#)"
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
  - "HashIdentity.Structural<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.HashIdentity.Structural``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Structural type function [F#]"
  - "HashIdentity.Structural type function [F#]"
ms.assetid: afedeb12-67a3-423f-b941-92003d2710b8
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashIdentity.Structural&lt;&#39;T&gt; Type Function (F#)
Implements structural hashing. Hashes using [Operators.(=)](../vs140/operators.--=----t--function--fsharp-.md) and [Operators.hash](../vs140/operators.hash--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.HashIdentity  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Structural<'T (requires equality)> :  IEqualityComparer<'T> (requires equality)  
  
// Usage:  
Structural  
```  
  
## Return Value  
 An object that implements <xref:System.Collections.IEqualityComparer*>.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.HashIdentity Module (F#)](../vs140/collections.hashidentity-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)