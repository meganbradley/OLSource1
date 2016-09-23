---
title: "Collections.Map&lt;&#39;Key,&#39;Value&gt; Constructor (F#)"
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
  - Map.Map<'Key,'Value>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.FSharpMap`2.#ctor
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Map constructor [F#]
ms.assetid: 90fe335c-fe3d-4a81-9c82-ff4aed80fe4c
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Collections.Map&lt;&#39;Key,&#39;Value&gt; Constructor (F#)
Builds a map that contains the bindings of the given <xref:System.Collections.Generic.IEnumerable`1?qualifyHint=False>.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
new Map : seq<'Key * 'Value> -> Map<'Key, 'Value> (requires comparison)  
  
// Usage:  
new Map (elements)  
```  
  
#### Parameters  
 `elements`  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)`<'Key * 'Value>`  
  
 The input sequence of key/value pairs.  
  
## Return Value  
 The resulting map.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map<'Key,'Value> Class (F#)](../vs140/collections.map--key--value--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)