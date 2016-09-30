---
title: "List.Cons&lt;&#39;T&gt; Method (F#)"
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
  - "List.Cons<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpList`1.Cons"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.Cons method [F#]"
  - "Cons method [F#]"
ms.assetid: 73ae40fd-3f79-4437-b2c5-5b1570e73713
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.Cons&lt;&#39;T&gt; Method (F#)
Returns a list with `head` as its first element and `tail` as its subsequent elements.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member List.Cons : 'T * 'T list -> 'T list  
  
// Usage:  
List.Cons (head, tail)  
```  
  
#### Parameters  
 `head`  
 Type: `'T`  
  
 A new head value for the list.  
  
 `tail`  
 Type: `'T list`  
  
 The existing list.  
  
## Return Value  
 The list with `head` appended to the front of `tail`.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List\<'T> Union (F#)](../vs140/collections.list--t--union--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)