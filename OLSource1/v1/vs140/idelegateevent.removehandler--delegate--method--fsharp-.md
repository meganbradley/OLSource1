---
title: "IDelegateEvent.RemoveHandler&lt;&#39;Delegate&gt; Method (F#)"
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
  - "IDelegateEvent.RemoveHandler<'Delegate>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.IDelegateEvent`1.RemoveHandler"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "RemoveHandler method [F#]"
  - "IDelegateEvent.RemoveHandler method [F#]"
ms.assetid: a5fd2289-29ef-4c8e-bf67-14d6fbed38b2
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDelegateEvent.RemoveHandler&lt;&#39;Delegate&gt; Method (F#)
Remove a listener delegate from an event listener store.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.RemoveHandler : 'Delegate -> unit  
  
// Usage:  
iDelegateEvent.RemoveHandler (handler)  
```  
  
#### Parameters  
 `handler`  
 Type: `'Delegate`  
  
 The delegate to be removed from the event listener store.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.IDelegateEvent\<'Delegate> Interface (F#)](../vs140/control.idelegateevent--delegate--interface--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)