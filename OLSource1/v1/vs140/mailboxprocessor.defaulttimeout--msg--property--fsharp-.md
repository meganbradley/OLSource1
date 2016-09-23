---
title: "MailboxProcessor.DefaultTimeout&lt;&#39;Msg&gt; Property (F#)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-fsharp
ms.tgt_pltfrm: na
ms.topic: reference
apiname: 
  - MailboxProcessor.DefaultTimeout<'Msg>
apilocation: 
  - FSharp.Core.dll
apitype: Assembly
f1_keywords: 
  - Microsoft.FSharp.Control.FSharpMailboxProcessor`1.DefaultTimeout
dev_langs: 
  - FSharp
helpviewer_keywords: 
  - DefaultTimeout property [F#]
  - MailboxProcessor.DefaultTimeout property [F#]
ms.assetid: 9f54edae-6167-4a68-acc5-fd444817fb1b
caps.latest.revision: 22
translation.priority.ht: 
  - de-de
  - ja-jp
---
# MailboxProcessor.DefaultTimeout&lt;&#39;Msg&gt; Property (F#)
Gets or sets the current default timeout.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signatures:  
member this.DefaultTimeout :  int with get, set  
  
// Usage:  
mailboxProcessor.DefaultTimeout  
mailboxProcessor.DefaultTimeout <- defaultTimeout  
```  
  
#### Parameters  
 `value`  
 Type: [int](../vs140/core.int-type-abbreviation--fsharp-.md)  
  
 The timeout, in milliseconds.  
  
## Return Value  
  
## Remarks  
 The [MailboxProcessor](../vs140/control.mailboxprocessor--msg--class--fsharp-.md) raises a timeout exception if a message is not received in this amount of time. If this property is not set, no timeout is used.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)