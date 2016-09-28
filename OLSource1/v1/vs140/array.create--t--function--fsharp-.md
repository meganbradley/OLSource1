---
title: "Array.create&lt;&#39;T&gt; Function (F#)"
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
  - "Array.create<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Create``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.create function [F#]"
  - "create function [F#]"
ms.assetid: e848c8d6-1142-4080-9727-8dacc26066be
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.create&lt;&#39;T&gt; Function (F#)
Creates an array whose elements are all initially the given value.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.create : int -> 'T -> 'T []  
  
// Usage:  
Array.create count value  
```  
  
#### Parameters  
 `count`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The length of the array to create.  
  
 `value`  
 Type: `'T`  
  
 The value for the elements.  
  
## Return Value  
 The created array.  
  
## Remarks  
 This function is named `Create` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of `Array.create` as well as setting and getting array values.  
  
 [!code[FsArrays#9](../vs140/codesnippet/FSharp/array.create--t--function--fsharp-_1.fs)]  
  
 **0 1 2 3 4 5 6 7 8 9**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)