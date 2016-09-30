---
title: "List.fold&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - "List.fold<'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Fold``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.fold function [F#]"
  - "fold function [F#]"
ms.assetid: c272779e-bae7-4983-8d7f-16b345bb33a0
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.fold&lt;&#39;T,&#39;State&gt; Function (F#)
Applies a function <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to each element of the collection, threading an accumulator argument through the computation. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function takes the second argument, and applies the function <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to it and the first element of the list. Then, it feeds this result into the function <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> along with the second element, and so on. It returns the final result. If the input function is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and the elements are <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then this function computes <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 The function to update the state given the input elements.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 The initial state.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The final state value.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 [!code[FsSamples101#3006](../vs140/codesnippet/FSharp/list.fold--t--state--function--fsharp-_1.fs)]  
  
 **Total number of animals: 14**   
## Example  
 The following code example illustrates additional uses of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Note that library functions exist that already encapsulate the functionality implemented below. For example, [List.sum](../vs140/list.sum-^t--function--fsharp-.md) is available to add up all the elements of a list.  
  
 [!code[FsLists#27](../vs140/codesnippet/FSharp/list.fold--t--state--function--fsharp-_2.fs)]  
  
 **Output**  
  
 **Sum of the elements of list [1; 2; 3] is 6.**  
**List [1; 1; 1] average: 1.000000 stddev: 0.000000**  
**List [1; 2; 1] average: 1.333333 stddev: 0.471405**  
**List [1; 2; 3] average: 2.000000 stddev: 0.816497**  
**0.0**  
**1.0**  
**2.5**  
**5.1**  
**[10; 9; 8; 7; 6; 5; 4; 3; 2; 1]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)