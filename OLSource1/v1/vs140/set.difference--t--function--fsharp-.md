---
title: "Set.difference&lt;&#39;T&gt; Function (F#)"
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
  - "Set.difference<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.SetModule.Difference``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "difference function [F#]"
  - "Set.difference function [F#]"
ms.assetid: 75bf5d03-8825-4b21-8526-4da87ea419e6
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Set.difference&lt;&#39;T&gt; Function (F#)
Returns a new set with the elements of the second set removed from the first.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.Set  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The first input set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [Set](../vs140/collections.set--t--class--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The set whose elements will be removed from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 The set with the elements of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> removed from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code illustrates the use of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function.  
  
 [!code[FsSets#2](../vs140/codesnippet/FSharp/set.difference--t--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **Set.difference [2 .. 6] [1 .. 3] yields set [4; 5; 6]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.Set Module (F#)](../vs140/collections.set-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)