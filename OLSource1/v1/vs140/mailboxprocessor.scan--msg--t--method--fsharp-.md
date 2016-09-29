---
title: "MailboxProcessor.Scan&lt;&#39;Msg,&#39;T&gt; Method (F#)"
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
  - "MailboxProcessor.Scan<'Msg,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.Scan``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MailboxProcessor.Scan method [F#]"
  - "Scan method [F#]"
ms.assetid: e86368a3-4f97-4b51-a487-4c6b5456fcbe
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.Scan&lt;&#39;Msg,&#39;T&gt; Method (F#)
Scans for a message by looking through messages in arrival order until a provided function returns a `Some` value. Other messages remain in the queue.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Scan : ('Msg -> Async<'T> option) * ?int -> Async<'T>  
  
// Usage:  
mailboxProcessor.Scan (scanner)  
mailboxProcessor.Scan (scanner, timeout = timeout)  
```  
  
#### Parameters  
 `scanner`  
 Type: `'Msg ->` [Async](../vs140/control.async--t--type--fsharp-.md)`<'T>` [option](../vs140/core.option--t--union--fsharp-.md)  
  
 A function that returns `None` if the message is to be skipped, or `Some` if the message is to be processed and removed from the queue.  
  
 `timeout`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional timeout in milliseconds. Defaults to -1 which corresponds to <xref:System.Threading.Timeout.Infinite*>.  
  
## Exceptions  
  
|Exception|Condition|  
|---------------|---------------|  
|<xref:System.TimeoutException*>|Thrown when the timeout is exceeded.|  
  
## Return Value  
 An asynchronous computation ([Async](../vs140/control.async-class--fsharp-.md) object) that `scanner` built off the read message.  
  
## Remarks  
 This method is for use within the body of the agent. For each agent, at most one concurrent reader may be active, so no more than one concurrent call to [Receive](../vs140/mailboxprocessor.receive--msg--method--fsharp-.md), [TryReceive](../vs140/mailboxprocessor.tryreceive--msg--method--fsharp-.md), `Scan` or [TryScan](../vs140/mailboxprocessor.tryscan--msg--t--method--fsharp-.md) may be active. The body of the `scanner` function is locked during its execution, but the lock is released before the execution of the asynchronous workflow.  
  
## Example  
 The following example shows how to use the `Scan` method. In this code, mailbox processor agents manage a series of simulated jobs that run and compute a result.  
  
 [!code[FsMailboxProcessor#21](../vs140/codesnippet/FSharp/mailboxprocessor.scan--msg--t--method--fsharp-_1.fs)]  
  
 A sample session follows.  
  
 **Number Of Logical Processors: 2Requesting job #1Job #1 submitted.Job #1 started on procId 0.Requesting job #2Job #2 submitted.Job #2 started on procId 1.Requesting job #3Requesting job #4Requesting job #5Requesting job #6Requesting job #7Requesting job #8Requesting job #9Requesting job #10Job #1 completed.Nth Prime for N = 5000 is 48611.Job #3 submitted.Job #3 started on procId 0.Done submitting jobs. Press Enter to exit when ready.Job #2 completed.Nth Prime for N = 10000 is 104729.Job #4 submitted.Job #4 started on procId 1.Job #3 completed.Nth Prime for N = 15000 is 163841.Job #5 submitted.Job #5 started on procId 0.Job #4 completed.Nth Prime for N = 20000 is 224737.Job #6 submitted.Job #6 started on procId 1.Job #5 completed.Nth Prime for N = 25000 is 287117.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)