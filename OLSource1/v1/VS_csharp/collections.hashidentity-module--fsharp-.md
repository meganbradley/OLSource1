---
title: "Collections.HashIdentity Module (F#)"
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
  - "Collections.HashIdentity"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.HashIdentity"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "HashIdentity module [F#]"
ms.assetid: 8e676091-4b8d-44d6-83cc-5caeb3f78cf4
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Collections.HashIdentity Module (F#)
Common notions of value identity used with hash tables.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module HashIdentity  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[FromFunctions](../VS_csharp/hashidentity.fromfunctions--t--function--fsharp-.md)  `: ('T -> int) -> ('T -> 'T -> bool) -> IEqualityComparer<'T>`|Hash using the given hashing and equality functions.|  
|[LimitedStructural](../VS_csharp/hashidentity.limitedstructural--t--function--fsharp-.md)  `: int -> IEqualityComparer<'T>`|Provides structural hashing up to a specified number of elements.|  
|[Reference](../VS_csharp/hashidentity.reference--t--type-function--fsharp-.md)  `: IEqualityComparer<'T>`|Implements physical hashing, which means that it hashes on reference identity of objects, and the contents of value types..|  
|[Structural](../VS_csharp/hashidentity.structural--t--type-function--fsharp-.md)  `: IEqualityComparer<'T>`|Implements structural hashing. Hashes using [Operators.(=)](../VS_csharp/operators.--=----t--function--fsharp-.md) and [Operators.hash](../VS_csharp/operators.hash--t--function--fsharp-.md).|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)