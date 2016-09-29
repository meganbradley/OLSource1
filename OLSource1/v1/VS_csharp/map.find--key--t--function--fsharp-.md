---
title: "Map.find&lt;&#39;Key,&#39;T&gt; Function (F#)"
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
  - "Map.find<'Key,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.MapModule.Find``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "find function [F#]"
  - "Map.find function [F#]"
ms.assetid: fc984657-9e0f-4544-b7d1-da6572b5ae74
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.find&lt;&#39;Key,&#39;T&gt; Function (F#)
Looks up an element in the map. If no binding exists in the map, raises <xref:System.Collections.Generic.KeyNotFoundException*>.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Map  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Map.find : 'Key -> Map<'Key,'T> -> 'T (requires comparison)  
  
// Usage:  
Map.find key table  
```  
  
#### Parameters  
 `key`  
 Type: `'Key`  
  
 The input key.  
  
 `table`  
 Type: [Map](../VS_csharp/collections.map--key--value--class--fsharp-.md)`<'Key,'T>`  
  
 The input map.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.Collections.Generic.KeyNotFoundException*>|Thrown when the key does not exist in the map.|  
  
## Return Value  
 The value mapped to the given key.  
  
## Remarks  
 This function is named `Find` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following examples shows how to use `Map.filter`.  
  
 [!code[FsMaps#6](../VS_csharp/codesnippet/FSharp/map.find--key--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **With key 1, found value "one".**  
**With key 2, found value "two".**  
**With key 3, found value 9.**  
**With key 5, found value 25.**  
**The given key was not present in the dictionary.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map Module (F#)](../VS_csharp/collections.map-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)