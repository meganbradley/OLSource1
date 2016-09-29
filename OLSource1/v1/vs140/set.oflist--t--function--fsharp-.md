---
title: "Set.ofList&lt;&#39;T&gt; Function (F#)"
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
  - "Set.of_list<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.OfList``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Set.ofList function [F#]"
  - "ofList function [F#]"
  - "Set.FromList function [F#]"
  - "FromList function [F#]"
ms.assetid: bc089500-969e-402f-9162-d0a23fdd5b58
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.ofList&lt;&#39;T&gt; Function (F#)
Creates a set that contains the same elements as the given list.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.ofList : 'T list -> Set<'T> (requires comparison)  
  
// Usage:  
Set.ofList elements  
```  
  
#### Parameters  
 `elements`  
 Type: `'T`[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 A set containing the elements form the input list.  
  
## Remarks  
 This function is named `OfList` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)