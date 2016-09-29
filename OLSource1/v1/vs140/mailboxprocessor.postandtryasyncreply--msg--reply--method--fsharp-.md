---
title: "MailboxProcessor.PostAndTryAsyncReply&lt;&#39;Msg,&#39;Reply&gt; Method (F#)"
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
  - "MailboxProcessor.PostAndTryAsyncReply<'Msg,'Reply>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.PostAndTryAsyncReply``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MailboxProcessor.PostAndTryAsyncReply method [F#]"
  - "PostAndTryAsyncReply method [F#]"
ms.assetid: d1eba793-83b7-430c-ab83-81576ab670dd
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.PostAndTryAsyncReply&lt;&#39;Msg,&#39;Reply&gt; Method (F#)
Like [MailboxProcessor.AsyncPostAndReply](../vs140/mailboxprocessor.postandasyncreply--msg--reply--method--fsharp-.md), but returns `None` if no reply within the timeout period.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.PostAndTryAsyncReply : (AsyncReplyChannel<'Reply> -> 'Msg) * ?int -> Async<'Reply option>  
  
// Usage:  
mailboxProcessor.PostAndTryAsyncReply (buildMessage)  
mailboxProcessor.PostAndTryAsyncReply (buildMessage, timeout = timeout)  
```  
  
#### Parameters  
 `buildMessage`  
 Type: [AsyncReplyChannel](../vs140/control.asyncreplychannel--reply--class--fsharp-.md)`<'Reply> ->   'Msg`  
  
 The function to incorporate the [AsyncReplyChannel](../vs140/control.asyncreplychannel--reply--class--fsharp-.md) into the message to be sent.  
  
 `timeout`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional timeout parameter (in milliseconds) to wait for a reply message. The default is -1 which corresponds to <xref:System.Threading.Timeout.Infinite*>.  
  
## Return Value  
 An asynchronous computation ([Async](../vs140/control.async-class--fsharp-.md) object) that will return the reply or `None` if the timeout expires.  
  
## Remarks  
  
## Example  
 The following code shows how to use the `PostAndTryAsyncReply` method.  
  
 [!code[FsMailboxProcessor#19](../vs140/codesnippet/FSharp/mailboxprocessor.postandtryasyncreply--msg--reply--method--fsharp-_1.fs)]  
  
 A sample session follows.  
  
 **Mailbox Processor TestType some text and press Enter to submit a message.Type 'Stop' to close the program.> test1> Message number 0 was received. Message contents: test1test2> Message number 1 was received. Message contents: test2test3> Message number 2 was received. Message contents: test3test4> Message number 3 was received. Message contents: test4test5> Message number 4 was received. Message contents: test5test6> Reply timeout exceeded.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)