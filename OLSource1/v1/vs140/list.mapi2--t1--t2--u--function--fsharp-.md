---
title: "List.mapi2&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)"
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
  - "List.mapi2<'T1,'T2,'U>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.MapIndexed2``3"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.MapIndexed2 function [F#]"
  - "mapi2 function [F#]"
  - "List.mapi2 function [F#]"
  - "MapIndexed2 function [F#]"
ms.assetid: 680643af-233c-40a3-82f2-43d5af27ec49
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.mapi2&lt;&#39;T1,&#39;T2,&#39;U&gt; Function (F#)
Like [List.mapi](../vs140/list.mapi--t--u--function--fsharp-.md), but mapping corresponding elements from two lists of equal length.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function to transform pairs of elements from the two lists and their index.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The first input list.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The second input list.  
  
## Return Value  
 The list of transformed elements.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#37](../vs140/codesnippet/FSharp/list.mapi2--t1--t2--u--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[0; 7; 18]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)