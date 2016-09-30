---
title: "MailboxProcessor.TryScan&lt;&#39;Msg,&#39;T&gt; Method (F#)"
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
  - "MailboxProcessor.TryScan<'Msg,'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.TryScan``1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "TryScan method [F#]"
  - "MailboxProcessor.TryScan method [F#]"
ms.assetid: 05aa6c91-fe9f-4830-a2d7-6dfa5a2ab376
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.TryScan&lt;&#39;Msg,&#39;T&gt; Method (F#)
Scans for a message by looking through messages in arrival order until a provided function returns a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> value. Other messages remain in the queue.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Type: <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> [option](../vs140/core.option--t--union--fsharp-.md)  
  
 A function that returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the message is to be skipped, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the message is to be processed and removed from the queue.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 An optional timeout in milliseconds. Defaults to -1 which corresponds to \<xref:System.Threading.Timeout.Infinite*>.  
  
## Return Value  
 An asynchronous computation ([Async](../vs140/control.async-class--fsharp-.md) object) that <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> built off the read message.  
  
## Remarks  
 If a timeout period is exceeded, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is returned. This method is for use within the body of the agent. For each agent, at most one concurrent reader can be active, so no more than one concurrent call to [Receive](../vs140/mailboxprocessor.receive--msg--method--fsharp-.md), [TryReceive](../vs140/mailboxprocessor.tryreceive--msg--method--fsharp-.md), [Scan](../vs140/mailboxprocessor.scan--msg--t--method--fsharp-.md) or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can be active. The body of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function is locked during its execution, but the lock is released before the execution of the asynchronous workflow.  
  
## Example  
 The following code example shows how to use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method. This example is a job submission agent. There are three agents: one called <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that starts each job, another called <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that represents all running jobs, and one called <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> that represents notification that a job is completed. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is used in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> function to find a job to cancel, or fail if there is no matching job.  
  
 [!code[FsMailboxProcessor#22](../vs140/codesnippet/FSharp/mailboxprocessor.tryscan--msg--t--method--fsharp-_1.fs)]  
  
 Following is an example session.  
  
 **Mailbox Processor TestType some text and press Enter to submit a message.Type 'Stop' to close the program.> hello1 : Console loop4 : mailboxProcessorReply: Message number 0 was received. Message contents: hello> testing1 : Console loop3 : mailboxProcessorReply: Message number 1 was received. Message contents: testing> hello?1 : Console loop4 : mailboxProcessorReply: Message number 2 was received. Message contents: hello?> testing 1 2 31 : Console loop3 : mailboxProcessorReply: Message number 3 was received. Message contents: testing 1 2 3> Stop1 : Console loop4 : mailboxProcessorPress Enter to continue.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor\<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)