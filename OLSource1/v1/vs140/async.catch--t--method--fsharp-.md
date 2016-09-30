---
title: "Async.Catch&lt;&#39;T&gt; Method (F#)"
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
  - "Async.Catch<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.Catch``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Catch method [F#]"
  - "Async.Catch method [F#]"
ms.assetid: c31e1ccb-c0f5-4da9-ba3d-c2454bcd0807
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.Catch&lt;&#39;T&gt; Method (F#)
Creates an asynchronous computation that executes a specified computation. If this computation completes successfully, then this method returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> with the returned value. If this computation raises an exception before it completes then return <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with the raised exception.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The input computation that returns the type 'T.  
  
## Return Value  
 A computation that returns a [Choice](../vs140/core.choice--t1--t2--union--fsharp-.md) of type 'T or an exception.  
  
## Remarks  
  
## Example  
 The following code example shows how to use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to run an asynchronous computation that might throw an exception.  
  
 [!code[FsAsyncAPIs#18](../vs140/codesnippet/FSharp/async.catch--t--method--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)