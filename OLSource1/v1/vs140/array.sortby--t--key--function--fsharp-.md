---
title: "Array.sortBy&lt;&#39;T,&#39;Key&gt; Function (F#)"
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
  - "Array.sortBy<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.SortBy``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "sortBy function [F#]"
  - "Array.sortBy function [F#]"
ms.assetid: 144498dc-091d-4575-a229-c0bcbd61426b
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.sortBy&lt;&#39;T,&#39;Key&gt; Function (F#)
Sorts the elements of an array, using the given projection for the keys and returning a new array. Elements are compared using [Operators.compare](../vs140/operators.compare--t--function--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function to transform array elements into the type that is compared.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The sorted array.  
  
## Remarks  
 This is not a stable sort, that is, the original order of equal elements is not necessarily preserved. For a stable sort, consider using [Seq.sort](../vs140/seq.sort--t--function--fsharp-.md).  
  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [!code[FsArrays#38](../vs140/codesnippet/FSharp/array.sortby--t--key--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[&#124;1; -2; 4; 5; 8&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)