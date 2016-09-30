---
title: "MailboxProcessor.Receive&lt;&#39;Msg&gt; Method (F#)"
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
  - "MailboxProcessor.Receive<'Msg>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.Receive"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MailboxProcessor.Receive method [F#]"
  - "Receive method [F#]"
ms.assetid: 46a1d8e6-3906-45c2-9722-0ddab574cc6a
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.Receive&lt;&#39;Msg&gt; Method (F#)
Waits for a message. This will consume the first message in arrival order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Receive : ?int -> Async<'Msg>  
  
// Usage:  
mailboxProcessor.Receive ()  
mailboxProcessor.Receive (timeout = timeout)  
```  
  
#### Parameters  
 `timeout`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional timeout in milliseconds. Defaults to -1 which corresponds to \<xref:System.Threading.Timeout.Infinite*>.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|\<xref:System.TimeoutException*>|Thrown when the timeout is exceeded.|  
  
## Return Value  
 An asynchronous computation ([Async](../vs140/control.async-class--fsharp-.md) object) that returns the received message.  
  
## Remarks  
 This method is for use within the body of the agent. For each agent, at most one concurrent reader may be active, so no more than one concurrent call to `Receive`, [TryReceive](../vs140/mailboxprocessor.tryreceive--msg--method--fsharp-.md), [Scan](../vs140/mailboxprocessor.scan--msg--t--method--fsharp-.md) or [TryScan](../vs140/mailboxprocessor.tryscan--msg--t--method--fsharp-.md) may be active.  
  
## Example  
 The following example shows how to use the `Receive` method. In this case, a timeout of 10 seconds is specified. In general, the message processing function runs on a different thread from the [Post](../vs140/mailboxprocessor.post--msg--method--fsharp-.md) function, so you must catch the timeout exception in the message processor function. In this example, the timeout exception just causes the loop to continue, and increases the message number by 1.  
  
 [!code[FsMailboxProcessor#10](../vs140/codesnippet/FSharp/mailboxprocessor.receive--msg--method--fsharp-_1.fs)]  
  
 A typical session follows. Notice that message 2 is skipped, due to the timeout.  
  
 **> helloReply: Message number 0 was received. Message contents: hello> hello?Reply: Message number 1 was received. Message contents: hello?> The mailbox processor timed out.anyone there?Reply: Message number 3 was received. Message contents: anyone there?>**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor\<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)