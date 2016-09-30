---
title: "Array2D.createBased&lt;&#39;T&gt; Function (F#)"
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
  - "Array2D.createBased<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.Array2DModule.CreateBased``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "createBased function [F#]"
  - "Array2D.createBased function [F#]"
ms.assetid: 673f61c6-3b1c-425a-b847-7e236a03651f
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array2D.createBased&lt;&#39;T&gt; Function (F#)
Creates a based array whose elements are all initially the given value.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array2D  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array2D.createBased : int -> int -> int -> int -> 'T -> 'T [,]  
  
// Usage:  
Array2D.createBased base1 base2 length1 length2 initial  
```  
  
#### Parameters  
 `base1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The base for the first dimension of the array.  
  
 `base2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The base for the second dimension of the array.  
  
 `length1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the first dimension of the array.  
  
 `length2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the second dimension of the array.  
  
 `initial`  
 Type: `'T`  
  
 The value to populate the new array.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when `base1`, `base2`, `length1`, or `length2` is negative.|  
  
## Return Value  
 The created array.  
  
## Remarks  
 This function is named `CreateBased` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0  
  
## See Also  
 [Collections.Array2D Module (F#)](../vs140/collections.array2d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)