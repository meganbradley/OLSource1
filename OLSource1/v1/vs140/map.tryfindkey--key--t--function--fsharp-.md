---
title: "Map.tryFindKey&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - Map.tryFindKey<'Key,'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.MapModule.TryFindKey``2
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - Map.tryFindKey function [F#]
  - tryFindKey function [F#]
ms.assetid: 9356bc17-ebc7-4070-b58d-96275a791c5d
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Map.tryFindKey&lt;&#39;Key,&#39;T&gt; Function (F#)
Returns the key of the first mapping in the collection that satisfies the given predicate, or returns `None` if no such element exists.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.tryFindKey : ('Key -> 'T -> bool) -> Map<'Key,'T> -> 'Key option (requires comparison)  
  
// Usage:  
Map.tryFindKey predicate table  
```  
  
#### Parameters  
 `predicate`  
 Type: `'Key -> 'T ->`[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 `table`  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)`<'Key,'T>`  
  
 The input map.  
  
## Return Value  
 The first key for which the predicate returns true or None if the predicate evaluates to false for each key/value pair.  
  
## Remarks  
 This function is named `TryFindKey` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows the use of the `Map.tryFindKey` function.  
  
 [!code[FsMaps#17](../vs140/codesnippet/FSharp/map.tryfindkey--key--t--function--fsharp-_1.fs)]
  
  
 **Output**  
  
 **Found element with key 1.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)