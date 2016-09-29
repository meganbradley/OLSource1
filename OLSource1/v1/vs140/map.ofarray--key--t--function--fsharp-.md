---
title: "Map.ofArray&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.of_array<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.OfArray``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "FromArray function [F#]"
  - "ofArray function [F#]"
  - "Map.ofArray function [F#]"
  - "Map.FromArray function [F#]"
ms.assetid: 614c77a4-2571-485c-b25d-9077bd1d2ab6
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.ofArray&lt;&#39;Key,&#39;T&gt; Function (F#)
Returns a new map made from the given bindings.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.ofArray : ('Key * 'T) [] -> Map<'Key,'T> (requires comparison)  
  
// Usage:  
Map.ofArray elements  
```  
  
#### Parameters  
 `elements`  
 Type: `('Key * 'T)`[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array of key/value pairs.  
  
## Return Value  
 The resulting map.  
  
## Remarks  
 This function is named `OfArray` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)