---
title: "MailboxProcessor.Post&lt;&#39;Msg&gt; Method (F#)"
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
  - "MailboxProcessor.Post<'Msg>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.Post"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Post method [F#]"
  - "MailboxProcessor.Post method [F#]"
ms.assetid: 70597a62-6aa9-4565-9b37-c0877cd3283b
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MailboxProcessor.Post&lt;&#39;Msg&gt; Method (F#)
Posts a message to the message queue of the [MailboxProcessor](../VS_csharp/control.mailboxprocessor--msg--class--fsharp-.md), asynchronously.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
member this.Post : 'Msg -> unit  
  
// Usage:  
mailboxProcessor.Post (message)  
```  
  
#### Parameters  
 `message`  
 Type: `'Msg`  
  
 The message to post.  
  
## Remarks  
  
## Example  
 The following code example shows how to start a mailbox processor agent and post messages to it.  
  
 [!code[FsMailboxProcessor#2](../VS_csharp/codesnippet/FSharp/mailboxprocessor.post--msg--method--fsharp-_1.fs)]  
  
 Following is an example session.  
  
 **Press any key...**  
**Message count = 0. Waiting for next message.**  
**Message received. ID: 1 Contents: ABC**  
**Message count = 1. Waiting for next message.**  
**Message received. ID: 2 Contents: XYZ**  
**Message count = 2. Waiting for next message.**   
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor<'Msg> Class (F#)](../VS_csharp/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)