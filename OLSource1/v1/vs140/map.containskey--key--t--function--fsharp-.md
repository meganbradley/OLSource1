---
title: "Map.containsKey&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.containsKey<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.ContainsKey``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Map.containsKey function [F#]"
  - "containsKey function [F#]"
ms.assetid: 45364a26-984c-4cf8-844f-dad1121c012d
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.containsKey&lt;&#39;Key,&#39;T&gt; Function (F#)
Tests if an element is in the domain of the map.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Map  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.containsKey : 'Key -> Map<'Key,'T> -> bool (requires comparison)  
  
// Usage:  
Map.containsKey key table  
```  
  
#### Parameters  
 `key`  
 Type: `'Key`  
  
 The input key.  
  
 `table`  
 Type: [Map](../vs140/collections.map--key--value--class--fsharp-.md)`<'Key,'T>`  
  
 The input map.  
  
## Return Value  
 `true` if the map contains the key.  
  
## Remarks  
 This function is named `ContainsKey` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use `Map.containsKey`.  
  
 [!code[FsMaps#3](../vs140/codesnippet/FSharp/map.containskey--key--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The specified map contains the key 1.**  
**The specified map does not contain the key 0.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../vs140/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)