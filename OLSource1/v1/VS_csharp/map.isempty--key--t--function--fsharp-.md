---
title: "Map.isEmpty&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.isEmpty<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.IsEmpty``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Map.isEmpty function [F#]"
  - "isEmpty function [F#]"
ms.assetid: 3e6efa6d-e028-48c9-bfc8-189d2e9b98c9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.isEmpty&lt;&#39;Key,&#39;T&gt; Function (F#)
Tests whether the map has any bindings.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.isEmpty : Map<'Key,'T> -> bool (requires comparison)  
  
// Usage:  
Map.isEmpty table  
```  
  
#### Parameters  
 `table`  
 Type: [Map](../VS_csharp/collections.map--key--value--class--fsharp-.md)`<'Key,'T>`  
  
 The input map.  
  
## Return Value  
 `true` if the map is empty. Otherwise, returns `false`.  
  
## Remarks  
 This function is named `IsEmpty` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../VS_csharp/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)