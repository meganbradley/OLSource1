---
title: "Set.foldBack&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - "Set.foldBack<'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.FoldBack``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "foldBack function [F#]"
  - "Set.foldBack function [F#]"
ms.assetid: 17933093-9571-4889-8a9f-532d60ac64dd
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.foldBack&lt;&#39;T,&#39;State&gt; Function (F#)
Applies the given accumulating function to all the elements of the set.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.foldBack : ('T -> 'State -> 'State) -> Set<'T> -> 'State -> 'State (requires comparison)  
  
// Usage:  
Set.foldBack folder set state  
```  
  
#### Parameters  
 `folder`  
 Type: `'T -> 'State -> 'State`  
  
 The accumulating function.  
  
 `set`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The input set.  
  
 `state`  
 Type: `'State`  
  
 The initial state.  
  
## Return Value  
 The final state.  
  
## Remarks  
 This function is named `FoldBack` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)