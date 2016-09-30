---
title: "Async.FromBeginEnd&lt;&#39;T&gt; Method (F#)"
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
  - "Async.FromBeginEnd<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsync.FromBeginEnd``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Async.FromBeginEnd method [F#]"
  - "FromBeginEnd method [F#]"
ms.assetid: eb24fcb5-36fb-4c9b-8343-02148b327b56
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Async.FromBeginEnd&lt;&#39;T&gt; Method (F#)
Creates an asynchronous computation in terms of a Begin/End pair of actions in the style used in CLI APIs.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: \<xref:System.AsyncCallback*> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [obj](../vs140/core.obj-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> \<xref:System.IAsyncResult*>  
  
 The function initiating a traditional CLI asynchronous operation.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: \<xref:System.IAsyncResult*> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 The function completing a traditional CLI asynchronous operation.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>[unit](../vs140/core.unit-type-abbreviation--fsharp-.md) <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> [unit](../vs140/core.unit-type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 An optional function to be executed when a cancellation is requested.  
  
## Return Value  
 An asynchronous computation wrapping the given Begin/End functions.  
  
## Remarks  
 For example, the following code creates an asynchronous computation that wraps a web service call.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When the computation is run, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is executed, with a callback which represents the continuation of the computation. When the callback is invoked, the overall result is fetched using <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The computation will respond to cancellation while waiting for the completion of the operation. If a cancellation occurs, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is specified, then it is executed, and the computation continues to wait for the completion of the operation. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is not specified, cancellation causes the computation to stop immediately, and subsequent invocations of the callback are ignored.  
  
## Example  
 The following code example shows how to create an F# asynchronous computation from a .NET asynchronous API that uses the Begin/End pattern. The example uses the .NET socket API in <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. It is an implementation of a simple server application that accepts a connection, receives data from a client, and sends a response.  
  
 [!code[FsAsyncAPIs#200](../vs140/codesnippet/FSharp/async.frombeginend--t--method--fsharp-_1.fs)]  
  
 **Output**  
  
 **Listening...**  
**Accepting...**  
**Receiving...**  
**Received 256 bytes from client computer.**  
**Sending...**  
**Completed.**   
## Example  
 The following code example shows the client code that can be used together with the server code in the previous example.  
  
 [!code[FsAsyncAPIs#20](../vs140/codesnippet/FSharp/async.frombeginend--t--method--fsharp-_2.fs)]  
  
 **Sample Output**  
  
 **Server address: 10.80.57.8**  
**Connected to remote host.**  
**Sending data...**  
**Receiving data...**  
**Received data from remote host.**  
**255 254 253 252 251 250 249 248 247 246 ...**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Async Class (F#)](../vs140/control.async-class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)