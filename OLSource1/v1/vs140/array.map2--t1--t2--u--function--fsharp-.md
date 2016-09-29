---
title: "Array.map2&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)"
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
  - "Array.map2<'T1,'T2,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Map2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map2 function [F#]"
  - "Array.map2 function [F#]"
ms.assetid: bb7aafe8-4a1f-45b9-92fc-1af9eafbea5c
caps.latest.revision: 26
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.map2&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)
Builds a new collection whose elements are the results of applying the given function to the corresponding elements of the two collections pairwise. The two input arrays must have the same lengths, otherwise <xref:System.ArgumentException*> is raised.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.map2 : ('T1 -> 'T2 -> 'U) -> 'T1 [] -> 'T2 [] -> 'U []  
  
// Usage:  
Array.map2 mapping array1 array2  
```  
  
#### Parameters  
 `mapping`  
 Type: `'T1 -> 'T2 -> 'U`  
  
 The function to transform the pairs of the input elements.  
  
 `array1`  
 Type: `'T1` [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The first input array.  
  
 `array2`  
 Type: `'T2` [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The second input array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the input arrays differ in length.|  
  
## Return Value  
 The array of transformed elements.  
  
## Remarks  
 This function is named `Map2` in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows the use of **Array.map2**.  
  
 [!code[FsArrays#52](../vs140/codesnippet/FSharp/array.map2--t1--t2--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;5; 7; 9&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)