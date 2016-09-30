---
title: "Async.StartChild&lt;&#39;T&gt; Method (F#)"
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
  - "Async.StartChild<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.StartChild``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "StartChild method [F#]"
  - "Async.StartChild method [F#]"
ms.assetid: dee323cf-015b-447f-8ffe-1a04443a7aa7
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.StartChild&lt;&#39;T&gt; Method (F#)
Starts a child computation within an asynchronous workflow. This allows multiple asynchronous computations to be executed simultaneously.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The child computation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The timeout value in milliseconds. If one is not provided then the default value is -1, which corresponds to \<xref:System.Threading.Timeout.Infinite*>.  
  
## Return Value  
 A new computation that waits for the input computation to finish.  
  
## Remarks  
 This method should normally be used as the immediate right-hand-side of a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> binding in an F# asynchronous workflow, that is:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When used in this way, each use of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> starts an instance of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and returns a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object representing a computation to wait for the completion of the operation. When executed, the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> awaits the completion of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Example  
 The following code example illustrates the use of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [!code[FsAsyncAPIs#4](../vs140/codesnippet/FSharp/async.startchild--t--method--fsharp-_1.fs)]  
  
 **Sample Output**  
  
 The output is interleaved because the jobs are running simultaneously.  
  
  **ComplParent job start.**  
**eted execution.**  
**Child job start: Child job slongoutput1.dat**  
**tart: longoutput2.dat**  
**Child job end: longoutput2.dat**  
**Child job end: longoutput1.dat**  
**Parent job end.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)