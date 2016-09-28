---
title: "MailboxProcessor.TryReceive&lt;&#39;Msg&gt; Method (F#)"
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
  - "MailboxProcessor.TryReceive<'Msg>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.TryReceive"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TryReceive method [F#]"
  - "MailboxProcessor.TryReceive method [F#]"
ms.assetid: edcb3930-cefd-4d88-935d-7dd6297355ee
caps.latest.revision: 26
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.TryReceive&lt;&#39;Msg&gt; Method (F#)
Waits for a message. This will consume the first message in arrival order.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.TryReceive : ?int -> Async<'Msg option>  
  
// Usage:  
mailboxProcessor.TryReceive ()  
mailboxProcessor.TryReceive (timeout = timeout)  
```  
  
#### Parameters  
 `timeout`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional timeout in milliseconds. Defaults to -1 which corresponds to <xref:System.Threading.Timeout.Infinite*>.  
  
## Return Value  
 An asynchronous computation ([Async](../vs140/control.async-class--fsharp-.md) object) that returns the received message or `None` if the timeout is exceeded.  
  
## Remarks  
 This method is for use within the body of the agent. Returns `None` if a timeout is given and the timeout is exceeded. This method is for use within the body of the agent. For each agent, at most one concurrent reader may be active, so no more than one concurrent call to [Receive](../vs140/mailboxprocessor.receive--msg--method--fsharp-.md), `TryReceive`, [Scan](../vs140/mailboxprocessor.scan--msg--t--method--fsharp-.md) or [TryScan](../vs140/mailboxprocessor.tryscan--msg--t--method--fsharp-.md) may be active.  
  
## Example  
 The following example shows how to use `TryReceive`. If a message is not received within 10 seconds, a timeout occurs and the message ID increments by 1.  
  
 [!code[FsMailboxProcessor#18](../vs140/codesnippet/FSharp/mailboxprocessor.tryreceive--msg--method--fsharp-_1.fs)]  
  
 A sample session follows. Notice that the message number 2 is skipped due to the timeout.  
  
 **Mailbox Processor TestType some text and press Enter to submit a message.Type 'Stop' to close the program.> test1Reply: Message number 0 was received. Message contents: test1> test2Reply: Message number 1 was received. Message contents: test2> test3Reply: Message number 3 was received. Message contents: test3> StopPress Enter to continue.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)