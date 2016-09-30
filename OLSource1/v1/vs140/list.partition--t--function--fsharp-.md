---
title: "List.partition&lt;&#39;T&gt; Function (F#)"
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
  - "List.partition<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Partition``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "partition function [F#]"
  - "List.partition function [F#]"
ms.assetid: aba8252d-ba85-4ec2-a2e2-930276e63a63
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.partition&lt;&#39;T&gt; Function (F#)
Splits the collection into two collections, containing the elements for which the given predicate returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> respectively.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 A list containing the elements for which the predicate evaluated to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and a list containing the elements for which the predicate evaluated to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#50](../vs140/codesnippet/FSharp/list.partition--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Evens: [2; 4; 6; 8; 10]**  
**Odds: [1; 3; 5; 7; 9]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)