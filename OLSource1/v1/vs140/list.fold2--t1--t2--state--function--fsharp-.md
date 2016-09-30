---
title: "List.fold2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)"
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
  - "List.fold2<'T1,'T2,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Fold2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.fold2 function [F#]"
  - "fold2 function [F#]"
ms.assetid: 6cfcd043-a65d-4423-805a-2ab234cb5343
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.fold2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)
Applies a function to corresponding elements of two collections, threading an accumulator argument through the computation. The collections must have identical sizes. If the input function is <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and the elements are <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> then computes <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The function to update the state given the input elements.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 The initial state.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
## Return Value  
 The final state value.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input lists differ in length.|  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#28](../vs140/codesnippet/FSharp/list.fold2--t1--t2--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **The sum of the greater of each pair of elements in the two lists is 8.**   
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to compute the ending balance in a bank account after a series of transactions. The two input lists represent the transaction type (deposit or withdrawal) and the transaction amount.  
  
 [!code[FsLists#29](../vs140/codesnippet/FSharp/list.fold2--t1--t2--state--function--fsharp-_2.fs)]  
  
 **Output**  
  
 **1205.000000**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)