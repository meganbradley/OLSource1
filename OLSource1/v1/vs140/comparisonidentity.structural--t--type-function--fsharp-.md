---
title: "ComparisonIdentity.Structural&lt;&#39;T&gt; Type Function (F#)"
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
  - "ComparisonIdentity.Structural<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ComparisonIdentity.Structural``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Structural type function [F#]"
  - "ComparisonIdentity.Structural type function [F#]"
ms.assetid: af092340-5ab2-478f-b873-1c88d97a0365
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComparisonIdentity.Structural&lt;&#39;T&gt; Type Function (F#)
Returns a comparer object that performs structural comparison, by using [Operators.compare](../vs140/operators.compare--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.ComparisonIdentity  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Structural<'T (requires comparison)> :  IComparer<'T> (requires comparison)  
  
// Usage:  
Structural  
```  
  
## Return Value  
 Returns an object that implements \<xref:System.Collections.IComparer*> that performs structural comparison.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.ComparisonIdentity Module (F#)](../vs140/collections.comparisonidentity-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)