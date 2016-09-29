---
title: "Control.AsyncReplyChannel&lt;&#39;Reply&gt; Class (F#)"
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
  - "Control.AsyncReplyChannel<'Reply>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpAsyncReplyChannel`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "AsyncReplyChannel class [F#]"
  - "FSharpAsyncReplyChannel class [F#]"
ms.assetid: e32fd8ec-37dd-4e63-94a5-67709962d1d0
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.AsyncReplyChannel&lt;&#39;Reply&gt; Class (F#)
A handle to a capability to reply to a PostAndReply message.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
[<Sealed>]  
type AsyncReplyChannel<'Reply> =  
 class  
  member this.Reply : 'Reply -> unit  
 end  
```  
  
## Remarks  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Reply](../vs140/asyncreplychannel.reply--reply--method--fsharp-.md)|Sends a reply to a PostAndReply message.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)