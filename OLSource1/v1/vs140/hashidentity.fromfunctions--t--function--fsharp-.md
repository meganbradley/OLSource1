---
title: "HashIdentity.FromFunctions&lt;&#39;T&gt; Function (F#)"
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
  - HashIdentity.FromFunctions<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.HashIdentity.FromFunctions``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - FromFunctions function [F#]
  - HashIdentity.FromFunctions function [F#]
ms.assetid: b19afd76-a58f-4a6d-a10e-b302d59b8889
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# HashIdentity.FromFunctions&lt;&#39;T&gt; Function (F#)
Hash using the given hashing and equality functions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.HashIdentity  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
FromFunctions : ('T -> int) -> ('T -> 'T -> bool) -> IEqualityComparer<'T>  
  
// Usage:  
FromFunctions hasher equality  
```  
  
#### Parameters  
 `hasher`  
 Type: `'T ->`[int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 A function to generate a hash code from a value.  
  
 `equality`  
 Type: `'T -> 'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 A function to test equality of two values.  
  
## Return Value  
 An object that implements <xref:System.Collections.IEqualityComparer?qualifyHint=False> using the supplied functions.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.HashIdentity Module (F#)](../vs140/collections.hashidentity-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)