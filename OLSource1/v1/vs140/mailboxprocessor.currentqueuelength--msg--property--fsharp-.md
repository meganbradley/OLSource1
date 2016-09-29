---
title: "MailboxProcessor.CurrentQueueLength&lt;&#39;Msg&gt; Property (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.MailboxProcessor.CurrentQueueLength"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "CurrentQueueLength property [F#]"
ms.assetid: bed32e01-5c56-4bce-985c-35f3244f3580
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.CurrentQueueLength&lt;&#39;Msg&gt; Property (F#)
Returns the number of unprocessed messages in the message queue of the agent.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.CurrentQueueLength :  int  
  
// Usage:  
mailboxProcessor.CurrentQueueLength  
```  
  
## Return Value  
 The number of unprocessed messages in the queue.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)