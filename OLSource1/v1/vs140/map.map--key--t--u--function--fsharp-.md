---
title: "Map.map&lt;&#39;Key,&#39;T,&#39;U&gt; Function (F#)"
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
  - "Map.map<'Key,'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.Map``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
  - "Map.map function [F#]"
ms.assetid: c47bdb4a-af6b-4317-8687-02379b81d4c9
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.map&lt;&#39;Key,&#39;T,&#39;U&gt; Function (F#)
Creates a new collection whose elements are the results of applying the given function to each of the elements of the collection. The key passed to the function indicates the key of element being transformed.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Map  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.map : ('Key -> 'T -> 'U) -> Map<'Key,'T> -> Map<'Key,'U> (requires comparison)  
  
// Usage:  
Map.map mapping table  
```  
  
#### Parameters  
 `mapping`  
 Type: `'Key -> 'T -> 'U`  
  
 The function to transform the key/value pairs.  
  
 `table`  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)`<'Key,'T>`  
  
 The input map.  
  
## Return Value  
 The resulting map of keys and transformed values.  
  
## Remarks  
 This function is named `Map` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use **Map.map**.  
  
 [!code[FsMaps#12](../vs140/codesnippet/FSharp/map.map--key--t--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **map [(1, "One"); (2, "Two"); (3, "Three")]**  
**map [(1, "ONE"); (2, "TWO"); (3, "THREE")]**  
**map [(1, "one"); (2, "two"); (3, "three")]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)