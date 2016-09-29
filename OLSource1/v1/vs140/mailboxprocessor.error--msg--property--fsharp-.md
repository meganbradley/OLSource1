---
title: "MailboxProcessor.Error&lt;&#39;Msg&gt; Property (F#)"
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
  - "MailboxProcessor.Error<'Msg>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.Error"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MailboxProcessor.Error property [F#]"
  - "Error property [F#]"
ms.assetid: f9bf8e54-a0bc-4cfa-9b2d-abdedde9b74e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.Error&lt;&#39;Msg&gt; Property (F#)
Occurs when the execution of the agent results in an exception.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Error :  IEvent<Exception>  
  
// Usage:  
mailboxProcessor.Error  
```  
  
## Return Value  
 The error event as an object that implements [IEvent](../vs140/control.ievent--t--type-abbreviation--fsharp-.md)  
  
## Remarks  
  
## Example  
 The following code shows how to use the `Error` event to handle an exception that occurs in the body of the agent.  
  
 [!code[FsMailboxProcessor#23](../vs140/codesnippet/FSharp/mailboxprocessor.error--msg--property--fsharp-_1.fs)]  
  
 An example session follows.  
  
 **Mailbox Processor TestType some text and press Enter to submit a message.helloMessage number 0. Message contents: hellotestingMessage number 1. Message contents: testingThe agent timed out.Press Enter to close the program.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)