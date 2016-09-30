---
title: "Async.FromBeginEnd&lt;&#39;Arg1,&#39;T&gt; Method (F#)"
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
  - "Async.FromBeginEnd<'Arg1,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.FromBeginEnd``2"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async.FromBeginEnd method [F#]"
  - "FromBeginEnd method [F#]"
ms.assetid: fd61e0e4-3d74-4c70-a55f-083ed4239563
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.FromBeginEnd&lt;&#39;Arg1,&#39;T&gt; Method (F#)
Creates an asynchronous computation in terms of a Begin/End pair of actions in the style used in CLI APIs.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 The argument for the operation.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> \<xref:System.AsyncCallback*> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> [obj](../vs140/core.obj-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> \<xref:System.IAsyncResult*>  
  
 The function initiating a traditional CLI asynchronous operation.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Type: \<xref:System.IAsyncResult*> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 The function completing a traditional CLI asynchronous operation.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>[unit](../vs140/core.unit-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 An optional function to be executed when a cancellation is requested.  
  
## Return Value  
 An asynchronous computation wrapping the given Begin/End functions.  
  
## Remarks  
 This overload should be used if the operation is qualified by one argument. For example, you can create an asynchronous computation for a web service call with the following code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When the computation is run, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is executed, with a callback which represents the continuation of the computation. When the callback is invoked, the overall result is fetched using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The computation will respond to cancellation while waiting for the completion of the operation. If a cancellation occurs, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is specified, then it is executed, and the computation continues to wait for the completion of the operation. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is not specified, then cancellation causes the computation to stop immediately, and subsequent invocations of the callback are ignored.  
  
 For an example, see [Async.FromBeginEnd\<'T> Method (F#)](../vs140/async.frombeginend--t--method--fsharp-.md).  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)