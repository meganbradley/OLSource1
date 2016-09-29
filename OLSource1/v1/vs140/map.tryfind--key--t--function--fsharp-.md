---
title: "Map.tryFind&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.tryFind<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.TryFind``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "tryFind function [F#]"
  - "Map.tryFind function [F#]"
ms.assetid: 3e1b9f31-7584-4115-aaa6-442b71b21cc9
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.tryFind&lt;&#39;Key,&#39;T&gt; Function (F#)
Looks up an element in the map, returning a `Some` value if the element is in the domain of the map and `None` if not.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.tryFind : 'Key -> Map<'Key,'T> -> 'T option (requires comparison)  
  
// Usage:  
Map.tryFind key table  
```  
  
#### Parameters  
 `key`  
 Type: `'Key`  
  
 The input key.  
  
 `table`  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)`<'Key,'T>`  
  
 The input map.  
  
## Return Value  
 The found `Some` value or `None`.  
  
## Remarks  
 This function is named `TryFind` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use **Map.tryFind**.  
  
 [!code[FsMaps#15](../vs140/codesnippet/FSharp/map.tryfind--key--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Found 2500.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)