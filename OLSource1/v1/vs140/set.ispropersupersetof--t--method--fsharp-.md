---
title: "Set.IsProperSupersetOf&lt;&#39;T&gt; Method (F#)"
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
  - "Set.IsProperSupersetOf<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.FSharpSet`1.IsProperSupersetOf"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IsProperSupersetOf method [F#]"
  - "Set.IsProperSupersetOf method [F#]"
ms.assetid: 4c2a373c-8a5b-494b-94a7-004a5f1333be
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.IsProperSupersetOf&lt;&#39;T&gt; Method (F#)
Evaluates to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if all elements of the second set are in the first, and at least one element of the first is not in the second.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The set to test against.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if this set is a proper superset of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Otherwise, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
  
## Example  
 The following code illustrates the use of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method.  
  
 [!code[FsSets#8](../vs140/codesnippet/FSharp/set.ispropersupersetof--t--method--fsharp-_1.fs)]  
  
 **Output**  
  
 **set [1; 2; 3; 4; 5; 6; 7; 8; 9] is a proper superset of set [1; 2; 3; 4; 5; 6]: trueset [1; 2; 3; 4; 5; 6] is a proper superset of set [1; 2; 3; 4; 5; 6]: falseset [5; 6; 7; 8; 9; 10] is a proper superset of set [1; 2; 3; 4; 5; 6]: false**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set\<'T> Class (F#)](../vs140/collections.set--t--class--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)