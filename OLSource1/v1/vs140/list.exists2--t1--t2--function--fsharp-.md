---
title: "List.exists2&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "List.exists2<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Exists2``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.exists2 function [F#]"
  - "exists2 function [F#]"
ms.assetid: 7532b39e-3f4f-4534-a60b-d7721dc6fa7e
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.exists2&lt;&#39;T1,&#39;T2&gt; Function (F#)
Tests if any pair of corresponding elements of the lists satisfies the given predicate.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[bool](../vs140/core.bool-type-abbreviation--fsharp-.md)  
  
 The function to test the input elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if any pair of elements satisfy the predicate. Otherwise, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 The predicate is applied to matching elements in the two collections up to the lesser of the two lengths of the collections. If any application returns true then the overall result is true and no further elements are tested.  
  
 This function is named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#2](../vs140/codesnippet/FSharp/list.exists2--t1--t2--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Lists [1; 2; 3; 4; 5] and [5; 4; 3; 2; 1] have at least one equal element at the same position.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)