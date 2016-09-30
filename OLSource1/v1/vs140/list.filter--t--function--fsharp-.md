---
title: "List.filter&lt;&#39;T&gt; Function (F#)"
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
  - "List.filter<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Filter``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "filter function [F#]"
  - "List.filter function [F#]"
ms.assetid: 11a8c926-547b-44dd-bbae-98d44f3dd248
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.filter&lt;&#39;T&gt; Function (F#)
Returns a new collection containing only the elements of the collection for which the given predicate returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections.List  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 A list containing only the elements that satisfy the predicate.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in compiled assembly. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#24](../vs140/codesnippet/FSharp/list.filter--t--function--fsharp-_1.fs)]  
  
 The resulting list is [2; 4; 6].  
  
## Example  
 The following example shows another typical use for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[FsSamples101#3007](../vs140/codesnippet/FSharp/list.filter--t--function--fsharp-_2.fs)]  
  
 **Animals with short names: [("Cats", 4); ("Dogs", 5); ("Mice", 3)]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)