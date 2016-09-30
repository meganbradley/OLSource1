---
title: "List.forall&lt;&#39;T&gt; Function (F#)"
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
  - "List.forall<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.ForAll``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.forall function [F#]"
  - "forall function [F#]"
ms.assetid: e11a5233-d612-40ac-833b-d5cf496900b7
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.forall&lt;&#39;T&gt; Function (F#)
Tests if all elements of the collection satisfy the given predicate.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if all of the elements satisfy the predicate. Otherwise, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The predicate is applied to the elements of the input list. If any application returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> then the overall result is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and no further elements are tested. Otherwise, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is returned.  
  
 This function is named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#3](../vs140/codesnippet/FSharp/list.forall--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **true**  
**false**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)