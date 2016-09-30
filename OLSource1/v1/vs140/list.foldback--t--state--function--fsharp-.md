---
title: "List.foldBack&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - "List.foldBack<'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.FoldBack``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.foldBack function [F#]"
  - "foldBack function [F#]"
ms.assetid: b9a58e66-efe1-445f-a90c-ac9ffb9d40c7
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.foldBack&lt;&#39;T,&#39;State&gt; Function (F#)
Applies a function to each element of the collection, threading an accumulator argument through the computation. If the input function is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and the elements are <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, then this function computes <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The function to update the state given the input elements.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> [list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 The initial state.  
  
## Return Value  
 The final state value.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#41](../vs140/codesnippet/FSharp/list.foldback--t--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **6**  
**[1; 2; 3; 4; 5; 6; 7; 8; 9; 10]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)