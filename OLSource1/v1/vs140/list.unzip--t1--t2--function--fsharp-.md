---
title: "List.unzip&lt;&#39;T1,&#39;T2&gt; Function (F#)"
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
  - "List.unzip<'T1,'T2>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.Unzip``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "unzip function [F#]"
  - "List.unzip function [F#]"
ms.assetid: 639db80c-41b5-45bb-a6b4-1eaa04d61d21
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.unzip&lt;&#39;T1,&#39;T2&gt; Function (F#)
Splits a list of pairs into two lists.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
## Return Value  
 Two lists of split elements.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [!code[FsLists#38](../vs140/codesnippet/FSharp/list.unzip--t1--t2--function--fsharp-_1.fs)]  
  
 **Output**  
  
 **[1; 3][2; 4]**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)