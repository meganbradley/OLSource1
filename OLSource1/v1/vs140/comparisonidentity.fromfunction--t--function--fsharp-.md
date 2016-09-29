---
title: "ComparisonIdentity.FromFunction&lt;&#39;T&gt; Function (F#)"
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
  - "ComparisonIdentity.FromFunction<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ComparisonIdentity.FromFunction``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FromFunction function [F#]"
  - "ComparisonIdentity.FromFunction function [F#]"
ms.assetid: 96d24027-4779-4f73-a611-91cbaca2ff9c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComparisonIdentity.FromFunction&lt;&#39;T&gt; Function (F#)
Compare using the given comparer function.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.ComparisonIdentity  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FromFunction : ('T -> 'T -> int) -> IComparer<'T>  
  
// Usage:  
FromFunction comparer  
```  
  
#### Parameters  
 `comparer`  
 Type: `'T -> 'T ->`[int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 A function to compare two values.  
  
## Return Value  
 An object implementing <xref:System.Collections.IComparer*> using the supplied comparer.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.ComparisonIdentity Module (F#)](../vs140/collections.comparisonidentity-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)