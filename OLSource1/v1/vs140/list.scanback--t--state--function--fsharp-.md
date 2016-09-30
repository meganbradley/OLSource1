---
title: "List.scanBack&lt;&#39;T,&#39;State&gt; Function (F#)"
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
  - "List.scanBack<'T,'State>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Collections.ListModule.ScanBack``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "scanBack function [F#]"
  - "List.scanBack function [F#]"
ms.assetid: 6c131a36-d152-46d4-80c6-d3ee3ac80925
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List.scanBack&lt;&#39;T,&#39;State&gt; Function (F#)
Like [List.foldBack](../vs140/list.foldback--t--state--function--fsharp-.md), but returns both the intermediate and final results.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Collections.List  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 The function to update the state given the input elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>[list](../vs140/collections.list--t--union--fsharp-.md)  
  
 The input list.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The initial state.  
  
## Return Value  
 The list of states.  
  
## Remarks  
 This function is named <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in compiled assemblies. If you are accessing the function from a language other than F#, or through reflection, use this name.  
  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and also contrasts its behavior with [List.scan](../vs140/list.scan--t--state--function--fsharp-.md).  
  
 [!code[FsLists#61](../vs140/codesnippet/FSharp/list.scanback--t--state--function--fsharp-_1.fs)]  
  
 Output  
  
 **Operations:**  
**add 1  add 2  subtract 5**   
**List.scan List.scanBack**  
 **10         10**  
 **11          5**  
 **13          7**  
 **8          8**  
**Operations:**  
**add 1  multiply by 5  square**   
**List.scan List.scanBack**  
 **10         10**  
 **11        100**  
 **55        500**  
 **3025        501**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Collections.List Module (F#)](../vs140/collections.list-module--fsharp-.md)   
 [Microsoft.FSharp.Collections Namespace (F#)](../vs140/microsoft.fsharp.collections-namespace--fsharp-.md)