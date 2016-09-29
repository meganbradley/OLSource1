---
title: "MailboxProcessor.Start&lt;&#39;Msg&gt; Method (F#)"
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
  - "MailboxProcessor.Start<'Msg>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.Start"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Start method [F#]"
  - "MailboxProcessor.Start method [F#]"
ms.assetid: ebf18bf3-ba17-42b9-91ac-313a7eee6fa0
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.Start&lt;&#39;Msg&gt; Method (F#)
Creates and starts an agent.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
static member Start : (MailboxProcessor<'Msg> -> Async<unit>) * ?CancellationToken -> MailboxProcessor<'Msg>  
  
// Usage:  
MailboxProcessor.Start (body)  
MailboxProcessor.Start (body, cancellationToken = cancellationToken)  
```  
  
#### Parameters  
 `body`  
 Type: [MailboxProcessor](../VS_csharp/control.mailboxprocessor--msg--class--fsharp-.md)`<'Msg> ->` [Async](../VS_csharp/control.async--t--type--fsharp-.md)`<`[unit](../VS_csharp/core.unit-type-abbreviation--fsharp-.md)`>`  
  
 The function to produce an asynchronous computation that will be executed as the read loop for the [MailboxProcessor](../VS_csharp/control.mailboxprocessor--msg--class--fsharp-.md) when `Start` is called.  
  
 `cancellationToken`  
 Type: [CancellationToken](../VS_csharp/threading.cancellationtoken-structure--fsharp-.md)  
  
 An optional cancellation token for the `body`. The default is [Async.DefaultCancellationToken](../VS_csharp/async.defaultcancellationtoken-property--fsharp-.md).  
  
## Return Value  
 The created [MailboxProcessor](../VS_csharp/control.mailboxprocessor--msg--class--fsharp-.md).  
  
## Remarks  
 The `body` function is used to generate the asynchronous computation executed by the agent.  
  
## Example  
 The following code example shows how to start a mailbox processor agent. In this example, each line of input from the console is posted to a message queue. The program reads each message and replies by using a reply channel. When the special message "Stop" is received, the Stop reply is sent and the program exits.  
  
 [!code[FsMailboxProcessor#7](../VS_csharp/codesnippet/FSharp/mailboxprocessor.start--msg--method--fsharp-_1.fs)]  
  
 Following is an example session.  
  
 **Mailbox Processor TestType some text and press Enter to submit a message.Type 'Stop' to close the program.> hello1 : Console loop4 : mailboxProcessorReply: Message number 0 was received. Message contents: hello> testing1 : Console loop3 : mailboxProcessorReply: Message number 1 was received. Message contents: testing> hello?1 : Console loop4 : mailboxProcessorReply: Message number 2 was received. Message contents: hello?> testing 1 2 31 : Console loop3 : mailboxProcessorReply: Message number 3 was received. Message contents: testing 1 2 3> Stop1 : Console loop4 : mailboxProcessorPress Enter to continue.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor<'Msg> Class (F#)](../VS_csharp/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)