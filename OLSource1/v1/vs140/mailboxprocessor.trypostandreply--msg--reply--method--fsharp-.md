---
title: "MailboxProcessor.TryPostAndReply&lt;&#39;Msg,&#39;Reply&gt; Method (F#)"
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
  - "MailboxProcessor.TryPostAndReply<'Msg,'Reply>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.TryPostAndReply``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MailboxProcessor.TryPostAndReply method [F#]"
  - "TryPostAndReply method [F#]"
ms.assetid: 5c4a758b-aace-4cc1-950d-6105fd3652b9
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.TryPostAndReply&lt;&#39;Msg,&#39;Reply&gt; Method (F#)
Like [MailboxProcessor.PostAndReply](../vs140/mailboxprocessor.postandreply--msg--reply--method--fsharp-.md), but returns `None` if there is no reply within the timeout period.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.TryPostAndReply : (AsyncReplyChannel<'Reply> -> 'Msg) * ?int -> 'Reply option  
  
// Usage:  
mailboxProcessor.TryPostAndReply (buildMessage)  
mailboxProcessor.TryPostAndReply (buildMessage, timeout = timeout)  
```  
  
#### Parameters  
 `buildMessage`  
 Type: [AsyncReplyChannel](../vs140/control.asyncreplychannel--reply--class--fsharp-.md)`<'Reply> ->   'Msg`  
  
 The function to incorporate the [AsyncReplyChannel](../vs140/control.asyncreplychannel--reply--class--fsharp-.md) into the message to be sent.  
  
 `timeout`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional timeout parameter (in milliseconds) to wait for a reply message. Defaults to -1 which corresponds to \<xref:System.Threading.Timeout.Infinite*>.  
  
## Return Value  
 The reply from the agent or `None` if the timeout expires.  
  
## Remarks  
  
## Example  
 The following example shows how to use `TryPostAndReply`. In this example, the agent has a delay that eventually results in a timeout.  
  
 [!code[FsMailboxProcessor#16](../vs140/codesnippet/FSharp/mailboxprocessor.trypostandreply--msg--reply--method--fsharp-_1.fs)]  
  
 A sample session follows.  
  
 **Mailbox Processor TestType some text and press Enter to submit a message.Type 'Stop' to close the program.> test1Reply: Message number 0 was received. Message contents: test1> test2Reply: Message number 1 was received. Message contents: test2> test3Reply: Message number 2 was received. Message contents: test3> test4Reply: Message number 3 was received. Message contents: test4> test5Reply: Message number 4 was received. Message contents: test5> test6Timeout exceeded.Press Enter to continue.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor\<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)