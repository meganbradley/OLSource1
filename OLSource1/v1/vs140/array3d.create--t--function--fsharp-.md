---
title: "Array3D.create&lt;&#39;T&gt; Function (F#)"
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
  - Array3D.create<'T>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Collections.Array3DModule.Create``1
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - create function [F#]
  - Array3D.create function [F#]
ms.assetid: ca930a5a-bf9d-4819-ba23-cc6bfb9c4233
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Array3D.create&lt;&#39;T&gt; Function (F#)
Creates an array whose elements are all initially the given value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array3D  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array3D.create : int -> int -> int -> 'T -> 'T [,,]  
  
// Usage:  
Array3D.create length1 length2 length3 initial  
```  
  
#### Parameters  
 `length1`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the first dimension.  
  
 `length2`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the second dimension.  
  
 `length3`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the third dimension.  
  
 `initial`  
 Type: `'T`  
  
 The value of the array elements.  
  
## Return Value  
 The created array.  
  
## Remarks  
 This function is named `Create` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array3D Module (F#)](../vs140/collections.array3d-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)