---
title: "List.concat&lt;&#39;T&gt; Function (F#)"
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
  - "List.concat<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Concat``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.concat function [F#]"
  - "concat function [F#]"
ms.assetid: c5afd433-8764-4ea8-a6a8-937fb4d77c4c
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.concat&lt;&#39;T&gt; Function (F#)
Returns a new list that contains the elements of each list in order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The input sequence of lists.  
  
## Return Value  
 The resulting concatenated list.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates that [List.append](../vs140/list.append--t--function--fsharp-.md) is used to join two lists together; and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used to join any number of lists.  
  
 [!code[FsLists#26](../vs140/codesnippet/FSharp/list.concat--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **1 2 3 4 5 6 7 8 9 10**   
**1 2 3 4 5 6 7 8 9**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)