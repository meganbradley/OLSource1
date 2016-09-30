---
title: "Set.Contains&lt;&#39;T&gt; Method (F#)"
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
  - "Set.Contains<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpSet`1.Contains"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Contains method [F#]"
  - "Set.Contains method [F#]"
ms.assetid: beb0d4f8-15a0-46cd-bb2a-0d5f7f100ddd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.Contains&lt;&#39;T&gt; Method (F#)
A useful shortcut for [Set.contains](../vs140/set.contains--t--function--fsharp-.md). See the [Set module](../vs140/collections.set-module--fsharp-.md) for further operations on sets.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Contains : 'T -> bool (requires comparison)  
  
// Usage:  
set.Contains (value)  
```  
  
#### Parameters  
 `value`  
 Type: `'T`  
  
 The value to check.  
  
## Return Value  
 True if the set contains `value`.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set\<'T> Class (F#)](../vs140/collections.set--t--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)