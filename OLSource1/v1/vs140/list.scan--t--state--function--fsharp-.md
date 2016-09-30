---
title: "List.scan&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - "List.scan<'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Scan``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "scan function [F#]"
  - "List.scan function [F#]"
ms.assetid: 21f636db-885c-4a72-970e-e3841f33a1b8
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.scan&lt;&#39;T,&#39;State&gt; Function (F#)
Applies a function to each element of the collection, threading an accumulator argument through the computation. This function takes the second argument, and applies the function to it and the first element of the list. Then, it passes this result into the function along with the second element, and so on. Finally, it returns the list of intermediate results and the final result.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function to update the state given the input elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The initial state.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 The list of states.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#54](../vs140/codesnippet/FSharp/list.scan--t--state--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Initial balance:**  
 **$   1122.73**  
**Transaction   Balance**  
**$   -100.00 $   1122.73**  
**$    450.34 $   1022.73**  
**$    -62.34 $   1473.07**  
**$   -127.00 $   1410.73**  
**$    -13.50 $   1283.73**  
**$    -12.92 $   1270.23**  
**Final balance:**  
 **$   1257.31**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)