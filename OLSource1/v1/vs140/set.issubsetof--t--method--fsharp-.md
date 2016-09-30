---
title: "Set.IsSubsetOf&lt;&#39;T&gt; Method (F#)"
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
  - "Set.IsSubsetOf<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpSet`1.IsSubsetOf"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Set.IsSubsetOf method [F#]"
  - "IsSubsetOf method [F#]"
ms.assetid: 2069807c-c9fe-403f-b51c-0edc043ed796
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.IsSubsetOf&lt;&#39;T&gt; Method (F#)
Evaluates to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if all elements of the first set are in the second.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Collections  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The set to test against.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this set is a subset of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Otherwise, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Example  
 The following code illustrates the use of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method.  
  
 [!code[FsSets#10](../vs140/codesnippet/FSharp/set.issubsetof--t--method--fsharp-_1.fs)]  
  
 **Output**  
  
 **set [1; 2; 3; 4; 5] is a subset of set [1; 2; 3; 4; 5; 6]: trueset [1; 2; 3; 4; 5; 6] is a subset of set [1; 2; 3; 4; 5; 6]: trueset [5; 6; 7; 8; 9; 10] is a subset of set [1; 2; 3; 4; 5; 6]: true**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set\<'T> Class (F#)](../vs140/collections.set--t--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)