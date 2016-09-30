---
title: "Array.sortWith&lt;&#39;T&gt; Function (F#)"
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
  - "Array.sortWith<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.SortWith``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.sortWith function [F#]"
  - "sortWith function [F#]"
ms.assetid: 699d3638-4244-4f42-8496-45f53d43ce95
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.sortWith&lt;&#39;T&gt; Function (F#)
Sorts the elements of an array, using the given comparison function as the order, returning a new array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The function to compare pairs of array elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The sorted array.  
  
## Remarks  
 This is not a stable sort, that is, the original order of equal elements might not be preserved. For a stable sort, consider using [Seq.sort](../vs140/seq.sort--t--function--fsharp-.md).  
  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows the use of **Array.sortWith**.  
  
 [!code[FsArrays#65](../vs140/codesnippet/FSharp/array.sortwith--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Before sorting:**   
**[&#124;"<>"; "&"; "&&"; "&&&"; "\<"; ">"; "&#124;"; "&#124;&#124;"; "&#124;&#124;&#124;"&#124;]**  
**After sorting:**   
**[&#124;"&"; "&#124;"; "\<"; ">"; "&&"; "&#124;&#124;"; "<>"; "&&&"; "&#124;&#124;&#124;"&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)