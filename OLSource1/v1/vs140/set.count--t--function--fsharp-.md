---
title: "Set.count&lt;&#39;T&gt; Function (F#)"
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
  - "Set.count<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.Count``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "count function [F#]"
  - "Set.count function [F#]"
ms.assetid: 54acc46d-af76-474e-9ff7-bd4bd6b7b4c4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.count&lt;&#39;T&gt; Function (F#)
Returns the number of elements in the set.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Set  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.count : Set<'T> -> int (requires comparison)  
  
// Usage:  
Set.count set  
```  
  
#### Parameters  
 `set`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The input set.  
  
## Return Value  
 The number of elements in the set.  
  
## Remarks  
 This function is named `Count` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)