---
title: "Set.iter&lt;&#39;T&gt; Function (F#)"
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
  - Set.iter<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.SetModule.Iterate``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Set.iter function [F#]
  - Iterate function [F#]
  - iter function [F#]
  - Set.Iterate function [F#]
ms.assetid: 3f10b1f1-c1c9-4a86-af37-41e9c8dd8f54
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Set.iter&lt;&#39;T&gt; Function (F#)
Applies the given function to each element of the set, in order according to the comparison function.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Set  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.iter : ('T -> unit) -> Set<'T> -> unit (requires comparison)  
  
// Usage:  
Set.iter action set  
```  
  
#### Parameters  
 `action`  
 Type: `'T ->`[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to each element.  
  
 `set`  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)`<'T>`  
  
 The input set.  
  
## Remarks  
 This function is named `Iterate` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)