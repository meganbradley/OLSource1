---
title: "Set.Add&lt;&#39;T&gt; Method (F#)"
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
  - "Set.Add<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpSet`1.Add"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Add method [F#]"
  - "Set.Add method [F#]"
ms.assetid: 81a5d225-7c60-4243-9b4e-7162cb0e001b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.Add&lt;&#39;T&gt; Method (F#)
A useful shortcut for [Set.add](../vs140/set.add--t--function--fsharp-.md). Note this operation produces a new set and does not mutate the original set. The new set will share many storage nodes with the original. See the [Set module](../vs140/collections.set-module--fsharp-.md) for further operations on sets.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Add : 'T -> Set<'T> (requires comparison)  
  
// Usage:  
set.Add (value)  
```  
  
#### Parameters  
 `value`  
 Type: `'T`  
  
 The value to add to the set.  
  
## Return Value  
 The result set.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set\<'T> Class (F#)](../vs140/collections.set--t--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)