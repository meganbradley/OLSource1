---
title: "Handler.Invoke&lt;&#39;T&gt; Method (F#)"
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
  - "Handler.Invoke<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpHandler`1.Invoke"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Handler.Invoke method [F#]"
  - "Invoke method [F#]"
ms.assetid: 0f42e201-6463-4d42-a659-44f29138b4cd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Handler.Invoke&lt;&#39;T&gt; Method (F#)
Calls the function or functions associated with the event handler.  
  
 **Namespace/Module Path**: Microsoft.FSharp.Control  
  
 **Assembly**: FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
// Signature:  
abstract this.Invoke : obj * 'T -> unit  
  
// Usage:  
handler.Invoke (sender, args)  
```  
  
#### Parameters  
 `sender`  
 Type: [obj](../VS_csharp/core.obj-type-abbreviation--fsharp-.md)  
  
 The object that fired the event.  
  
 `args`  
 Type: `'T`  
  
 The event arguments.  
  
## Remarks  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Control.Handler<'T> Class (F#)](../VS_csharp/control.handler--t--class--fsharp-.md)   
 [Microsoft.FSharp.Control Namespace (F#)](../VS_csharp/microsoft.fsharp.control-namespace--fsharp-.md)