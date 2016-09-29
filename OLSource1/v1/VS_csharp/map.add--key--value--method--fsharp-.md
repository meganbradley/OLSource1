---
title: "Map.Add&lt;&#39;Key,&#39;Value&gt; Method (F#)"
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
  - "Map.Add<'Key,'Value>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpMap`2.Add"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Map.Add method [F#]"
  - "Add method [F#]"
ms.assetid: 7126bb07-f521-421f-ae84-41e0321f4279
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Map.Add&lt;&#39;Key,&#39;Value&gt; Method (F#)
Returns a new map with the binding added to the given map.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Add : 'Key * 'Value -> Map<'Key, 'Value> (requires comparison)  
  
// Usage:  
map.Add (key, value)  
```  
  
#### Parameters  
 `key`  
 Type: `'Key`  
  
 The input key.  
  
 `value`  
 Type: `'Value`  
  
 The input value.  
  
## Return Value  
 The resulting map.  
  
## Remarks  
  
## Example  
 The following code example shows how to use the `Add` method.  
  
 [!code[FsMaps#2](../VS_csharp/codesnippet/FSharp/map.add--key--value--method--fsharp-_1.fs)]  
  
 **Output**  
  
 **key: 0 value: zero**  
**key: 1 value: one**  
**key: 2 value: two**  
**key: 3 value: three**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Map<'Key,'Value> Class (F#)](../VS_csharp/collections.map--key--value--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)