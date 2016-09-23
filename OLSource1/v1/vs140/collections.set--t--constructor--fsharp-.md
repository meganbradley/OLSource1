---
title: "Collections.Set&lt;&#39;T&gt; Constructor (F#)"
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
  - Set.Set<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.FSharpSet`1.#ctor
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Set constructor [F#]
ms.assetid: 384b858c-e794-4f70-865f-80160bcbdf2d
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Collections.Set&lt;&#39;T&gt; Constructor (F#)
Create a set containing elements drawn from the given sequence.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
new Set : seq<'T> -> Set<'T> (requires comparison)  
  
// Usage:  
new Set (elements)  
```  
  
#### Parameters  
 `elements`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'T>`  
  
 The input sequence.  
  
## Return Value  
 The result set.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set<'T> Class (F#)](../vs140/collections.set--t--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)