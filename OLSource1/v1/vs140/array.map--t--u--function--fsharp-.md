---
title: "Array.map&lt;&#39;T,&#39;U&gt; Function (F#)"
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
  - "Array.map<'T,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.Map``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "map function [F#]"
  - "Array.map function [F#]"
ms.assetid: 38cbe824-0480-47be-85fd-df3afdd97a45
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.map&lt;&#39;T,&#39;U&gt; Function (F#)
Builds a new array whose elements are the results of applying the given function to each of the elements of the array.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function to transform elements of the array.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The input array.  
  
## Return Value  
 The array of transformed elements.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [!code[FsArrays#510](../vs140/codesnippet/FSharp/array.map--t--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Adding '1' using map = [&#124;2; 3; 4; 5&#124;]**  
**Converting to strings by using map = [&#124;"1"; "2"; "3"; "4"&#124;]**  
**Converting to tuples by using map = [&#124;(1, 1); (2, 2); (3, 3); (4, 4)&#124;]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)