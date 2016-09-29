---
title: "Array.ofList&lt;&#39;T&gt; Function (F#)"
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
  - "Array.of_list<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.OfList``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ofList function [F#]"
  - "Array.FromList function [F#]"
  - "Array.ofList function [F#]"
  - "FromList function [F#]"
ms.assetid: e7225239-f561-45a4-b0b5-69a1cdcae78b
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.ofList&lt;&#39;T&gt; Function (F#)
Builds an array from the given list.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
Array.ofList : 'T list -> 'T []  
  
// Usage:  
Array.ofList list  
```  
  
#### Parameters  
 `list`  
 Type: `'T`[list](../VS_csharp/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The array of elements from the list.  
  
## Remarks  
 This function is named `OfList` in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example demonstrates the use of `Array.ofList`.  
  
 [!code[FsArrays#59](../VS_csharp/codesnippet/FSharp/array.oflist--t--function--fsharp-_1.fs)]  
  
 **FSI Output**  
  
 **val array1 : int [] = [&#124;1; 2; 3; 4; 5; 6; 7; 8; 9; 10&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../VS_csharp/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../VS_csharp/microsoft.fsharp.collections-namespace--fsharp-.md)