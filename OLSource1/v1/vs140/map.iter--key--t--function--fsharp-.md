---
title: "Map.iter&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.iter<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.Iterate``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Map.iter function [F#]"
  - "Iterate function [F#]"
  - "iter function [F#]"
  - "Map.Iterate function [F#]"
ms.assetid: 63ba88a2-0d40-452b-8993-ec66e2ac978f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.iter&lt;&#39;Key,&#39;T&gt; Function (F#)
Applies the given function to each binding in the map.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.iter : ('Key -> 'T -> unit) -> Map<'Key,'T> -> unit (requires comparison)  
  
// Usage:  
Map.iter action table  
```  
  
#### Parameters  
 `action`  
 Type: `'Key -> 'T ->` [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)  
  
 The function to apply to each key/value pair.  
  
 `table`  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)`<'Key,'T>`  
  
 The input map.  
  
## Remarks  
 This function is named `Iterate` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)