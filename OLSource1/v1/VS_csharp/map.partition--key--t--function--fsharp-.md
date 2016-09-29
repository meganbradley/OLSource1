---
title: "Map.partition&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.partition<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.Partition``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "partition function [F#]"
  - "Map.partition function [F#]"
ms.assetid: 97896a64-ef03-43d2-9000-51cad86c2200
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.partition&lt;&#39;Key,&#39;T&gt; Function (F#)
Creates two new maps, one containing the bindings for which the given predicate returns `true`, and the other the remaining bindings.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.partition : ('Key -> 'T -> bool) -> Map<'Key,'T> -> Map<'Key,'T> * Map<'Key,'T> (requires comparison)  
  
// Usage:  
Map.partition predicate table  
```  
  
#### Parameters  
 `predicate`  
 Type: `'Key -> 'T ->` [bool](../VS_csharp/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `table`  
 Type: [Map](../VS_csharp/collections.map--key--value--class--fsharp-.md)`<'Key,'T>`  
  
 The input map.  
  
## Return Value  
 A pair of maps in which the first contains the elements for which the predicate returned `true` and the second containing the elements for which the predicated returned `false`.  
  
## Remarks  
 This function is named `Partition` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use **Map.partition**.  
  
 [!code[FsMaps#13](../VS_csharp/codesnippet/FSharp/map.partition--key--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Evens: map [(2, 4); (4, 16); (6, 36); (8, 64); (10, 100)]**  
**Odds: map [(1, 1); (3, 9); (5, 25); (7, 49); (9, 81)]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../VS_csharp/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)