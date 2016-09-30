---
title: "List.Item&lt;&#39;T&gt; Property (F#)"
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
  - "List.Item<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpList`1.Item"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.Item property [F#]"
  - "Item property [F#]"
ms.assetid: bdb2553a-0e54-4ff8-baed-ab1aac8f5dae
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.Item&lt;&#39;T&gt; Property (F#)
Gets the element of the list at the given position.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Item (int) :  'T  
  
// Usage:  
list.[index]  
```  
  
#### Parameters  
 `index`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index.  
  
## Return Value  
 The value at the given index.  
  
## Remarks  
 Lists are represented as linked lists so this is an O(n) operation.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List\<'T> Union (F#)](../vs140/collections.list--t--union--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)