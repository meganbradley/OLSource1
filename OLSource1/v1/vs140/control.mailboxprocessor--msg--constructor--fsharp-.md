---
title: "Control.MailboxProcessor&lt;&#39;Msg&gt; Constructor (F#)"
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
  - "MailboxProcessor.MailboxProcessor<'Msg>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpMailboxProcessor`1.#ctor"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "MailboxProcessor constructor [F#]"
ms.assetid: f13a40de-09c2-4446-9465-c1c476c57d1e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.MailboxProcessor&lt;&#39;Msg&gt; Constructor (F#)
Creates an agent.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Type: [MailboxProcessor](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> [Async](../vs140/control.async--t--type--fsharp-.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>[unit](../vs140/core.unit-type-abbreviation--fsharp-.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 The function to produce an asynchronous computation that will be executed as the read loop for the [MailboxProcessor](../vs140/control.mailboxprocessor--msg--class--fsharp-.md) when [Start](../vs140/mailboxprocessor.start--msg--method--fsharp-.md) is called.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Type: [CancellationToken](../vs140/threading.cancellationtoken-structure--fsharp-.md)  
  
 An optional cancellation token for the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Defaults to [Async.DefaultCancellationToken](../vs140/async.defaultcancellationtoken-property--fsharp-.md).  
  
## Return Value  
 The created MailboxProcessor.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function is used to generate the asynchronous computation executed by the agent. This function is not executed until [Start](../vs140/mailboxprocessor.start--msg--method--fsharp-.md) is called.  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.MailboxProcessor\<'Msg> Class (F#)](../vs140/control.mailboxprocessor--msg--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)