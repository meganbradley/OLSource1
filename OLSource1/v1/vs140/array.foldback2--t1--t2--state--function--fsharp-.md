---
title: "Array.foldBack2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)"
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
  - "Array.foldBack2<'T1,'T2,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ArrayModule.FoldBack2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Array.foldBack2 function [F#]"
  - "foldBack2 function [F#]"
ms.assetid: aa51b405-df20-4c51-9998-a6530f7db862
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Array.foldBack2&lt;&#39;T1,&#39;T2,&#39;State&gt; Function (F#)
Apply a function to pairs of elements drawn from the two collections, right-to-left, threading an accumulator argument through the computation. The two input arrays must have the same lengths, otherwise an \<xref:System.ArgumentException*> is raised.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Array  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function to update the state given the input elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The first input array.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> [&#91;&#93;](../vs140/core.--t--type--fsharp-2.md)  
  
 The second input array.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 The initial state.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.ArgumentException*>|Thrown when the input arrays differ in length.|  
  
## Return Value  
 The final state.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in the .NET assembly. If accessing the member from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 [!code[FsArrays#47](../vs140/codesnippet/FSharp/array.foldback2--t1--t2--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Ending balance: $1205.00**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Array Module (F#)](../vs140/collections.array-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)