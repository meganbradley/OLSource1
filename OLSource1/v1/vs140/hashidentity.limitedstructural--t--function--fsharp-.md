---
title: "HashIdentity.LimitedStructural&lt;&#39;T&gt; Function (F#)"
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
  - "HashIdentity.LimitedStructural<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.HashIdentity.LimitedStructural``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "LimitedStructural function [F#]"
  - "HashIdentity.LimitedStructural function [F#]"
ms.assetid: 9d7b59ee-78b2-40a0-a988-ca4310031dc9
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashIdentity.LimitedStructural&lt;&#39;T&gt; Function (F#)
Implements a structural hash that is limited to hashing a fixed number of elements.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.HashIdentity  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
LimitedStructural : int -> IEqualityComparer<'T> (requires equality)  
  
// Usage:  
LimitedStructural limit  
```  
  
#### Parameters  
 `limit`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The maximum number of elements to hash.  
  
## Return Value  
 An object that implements <xref:System.Collections.IEqualityComparer*> using the limited hash.  
  
## Remarks  
 Structural hashing recursively composes a hash of a structural object by combining the hashes of each of its constituent elements. So, if you have a list composed of 20,000 elements, the hashes of each element will be composed into the hash of the list.  
  
 To save time and mitigate the risk of a stack overflow while hashing, the limited hash allows you to specify an upper bound on the number of items you would like to consider when constructing a hash over structured data. So, if you are hashing a list of 20,000 elements, you can just use its first 18 elements.  
  
 `LimitedStructural` uses the [limitedHash function](../vs140/operators.limitedhash--t--function--fsharp-.md).  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.HashIdentity Module (F#)](../vs140/collections.hashidentity-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)