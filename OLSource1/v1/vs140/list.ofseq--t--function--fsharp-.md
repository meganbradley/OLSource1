---
title: "List.ofSeq&lt;&#39;T&gt; Function (F#)"
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
  - "List.of_seq<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.OfSeq``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "List.ofSeq function [F#]"
  - "FromSequence function [F#]"
  - "ofSeq function [F#]"
  - "List.FromSequence function [F#]"
ms.assetid: 74ab9289-4a59-4433-92eb-3f662d7f7db0
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.ofSeq&lt;&#39;T&gt; Function (F#)
Creates a new list from the given enumerable object.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The input sequence.  
  
## Return Value  
 The list of elements from the sequence.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a .NET language other than F#, or through reflection, use this name.  
  
## Example  
 The following code shows how to use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#60](../vs140/codesnippet/FSharp/list.ofseq--t--function--fsharp-_1.fs)]  
  
 **F# Interactive Output**  
  
 **val list1 : int list = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)