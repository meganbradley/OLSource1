---
title: "Collections.ComparisonIdentity Module (F#)"
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
  - Collections.ComparisonIdentity
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.ComparisonIdentity
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - ComparisonIdentity module [F#]
ms.assetid: c2b37395-7081-4427-9913-3e91a8001d77
caps.latest.revision: 23
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Collections.ComparisonIdentity Module (F#)
Common notions of comparison identity used with sorted data structures.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module ComparisonIdentity  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[FromFunction](../vs140/comparisonidentity.fromfunction--t--function--fsharp-.md)  `: ('T -> 'T -> int) -> IComparer<'T>`|Compare using the given comparer function.|  
|[Structural](../vs140/comparisonidentity.structural--t--type-function--fsharp-.md)  `: IComparer<'T>`|Structural comparison. Compare using [Operators.compare](../vs140/operators.compare--t--function--fsharp-.md).|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)