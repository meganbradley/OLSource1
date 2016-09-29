---
title: "Set.singleton&lt;&#39;T&gt; Function (F#)"
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
  - "Set.singleton<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.Singleton``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Set.singleton function [F#]"
  - "singleton function [F#]"
ms.assetid: 10355cec-dab2-40d0-b044-ed928dbd646f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.singleton&lt;&#39;T&gt; Function (F#)
The set containing the given element.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.singleton : 'T -> Set<'T> (requires comparison)  
  
// Usage:  
Set.singleton value  
```  
  
#### Parameters  
 `value`  
 Type: `'T`  
  
 The value for the set to contain.  
  
## Return Value  
 The set containing `value`.  
  
## Remarks  
 This function is named `Singleton` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)