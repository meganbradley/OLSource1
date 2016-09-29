---
title: "Array.init&lt;&#39;T&gt; Function (F#)"
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
  - "Array.init<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Initialize``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "init function [F#]"
  - "Array.init function [F#]"
  - "Array.Initialize function [F#]"
  - "Initialize function [F#]"
ms.assetid: ee898089-63b0-40aa-910c-5ae7e32f6665
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.init&lt;&#39;T&gt; Function (F#)
Creates an array given the dimension and a generator function to compute the elements.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.Array  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.init : int -> (int -> 'T) -> 'T []  
  
// Usage:  
Array.init count initializer  
```  
  
#### Parameters  
 `count`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md)  
  
 The number of elements to initialize.  
  
 `initializer`  
 Type: [int](../VS_csharp/core.int-type-abbreviation--fsharp-.md) `-> 'T`  
  
 The function to generate the initial values for each index.  
  
## Return Value  
 The created array.  
  
## Remarks  
 This function is named `Initialize` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code demonstrates the use of `Array.init`.  
  
 [!code[FsArrays#101](../VS_csharp/codesnippet/FSharp/array.init--t--function--fsharp-_1.fs)]  
  
 **Array of squares: [&#124;0; 1; 4; 9; 16; 25; 36; 49; 64; 81&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4  
  
## See Also  
 [Collections.Array Module (F#)](../VS_csharp/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)