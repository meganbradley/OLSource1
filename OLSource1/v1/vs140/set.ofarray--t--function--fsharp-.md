---
title: "Set.ofArray&lt;&#39;T&gt; Function (F#)"
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
  - "Set.of_array<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.OfArray``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FromArray function [F#]"
  - "Set.ofArray function [F#]"
  - "ofArray function [F#]"
  - "Set.FromArray function [F#]"
ms.assetid: 10434aec-34c8-4101-9ec9-751533f8e3de
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.ofArray&lt;&#39;T&gt; Function (F#)
Creates a set that contains the same elements as the given array.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Set  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Set.ofArray : 'T array -> Set<'T> (requires comparison)  
  
// Usage:  
Set.ofArray array  
```  
  
#### Parameters  
 `array`  
 Type: `'T array`  
  
 The input array.  
  
## Return Value  
 A set containing the elements of `array`.  
  
## Remarks  
 This function is named `OfArray` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)