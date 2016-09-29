---
title: "Array2D.get&lt;&#39;T&gt; Function (F#)"
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
  - "Array2D.get<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array2DModule.Get``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array2D.get function [F#]"
  - "GetAtIndex function [F#]"
  - "Array2D.GetAtIndex function [F#]"
  - "get function [F#]"
ms.assetid: fa3adca1-4a34-4873-912b-28858042780b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array2D.get&lt;&#39;T&gt; Function (F#)
Fetches an element from a 2D array. You can also use the syntax `array.[index1,index2]`.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array2D  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array2D.get : 'T [,] -> int -> int -> 'T  
  
// Usage:  
Array2D.get array index1 index2  
```  
  
#### Parameters  
 `array`  
 Type: `'T`[&#91;,&#93;](../vs140/core.--t--type--fsharp-4.md)  
  
 The input array.  
  
 `index1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index along the first dimension.  
  
 `index2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The index along the second dimension.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when the indices are negative or exceed the bounds of the array.|  
  
## Return Value  
 The value of the array at the given index.  
  
## Remarks  
 This function is named `Get` in compiled assemblies. If you are accessing the member from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array2D Module (F#)](../vs140/collections.array2d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)