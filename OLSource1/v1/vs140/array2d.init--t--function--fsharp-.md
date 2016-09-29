---
title: "Array2D.init&lt;&#39;T&gt; Function (F#)"
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
  - "Array2D.init<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array2DModule.Initialize``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array2D.Initialize function [F#]"
  - "init function [F#]"
  - "Array2D.init function [F#]"
  - "Initialize function [F#]"
ms.assetid: 9de07e95-bc21-4927-b5b4-08fdec882c7b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array2D.init&lt;&#39;T&gt; Function (F#)
Creates an array given the dimensions and a generator function to compute the elements.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array2D  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array2D.init : int -> int -> (int -> int -> 'T) -> 'T [,]  
  
// Usage:  
Array2D.init length1 length2 initializer  
```  
  
#### Parameters  
 `length1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the first dimension of the array.  
  
 `length2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the second dimension of the array.  
  
 `initializer`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) `->` [int](../vs140/core.int-type-abbreviation--fsharp-.md) `-> 'T`  
  
 A function to produce elements of the array given the two indices.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.ArgumentException*>|Thrown when either of the lengths is negative.|  
  
## Return Value  
 The generated array.  
  
## Remarks  
 This function is named `Initialize` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates the use of `Array2D.init` to create a two-dimensional array.  
  
 [!code[FsArrays#21](../vs140/codesnippet/FSharp/array2d.init--t--function--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array2D Module (F#)](../vs140/collections.array2d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)