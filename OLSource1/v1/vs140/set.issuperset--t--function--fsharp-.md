---
title: "Set.isSuperset&lt;&#39;T&gt; Function (F#)"
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
  - "Set.isSuperset<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.IsSuperset``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Set.isSuperset function [F#]"
  - "isSuperset function [F#]"
ms.assetid: f09b4a5f-e03b-435e-82a3-927e576635f3
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.isSuperset&lt;&#39;T&gt; Function (F#)
Evaluates to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if all elements of the second set are in the first.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The potential superset.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 The set to test against.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a superset of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Otherwise, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method.  
  
 [!code[FsSets#13](../vs140/codesnippet/FSharp/set.issuperset--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **set [1; 2; 3; 4; 5; 6; 7; 8; 9] is a superset of set [1; 2; 3; 4; 5; 6]: true**  
**set [1; 2; 3; 4; 5; 6] is a superset of set [1; 2; 3; 4; 5; 6]: true**  
**set [5; 6; 7; 8; 9; 10] is a superset of set [1; 2; 3; 4; 5; 6]: false**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)