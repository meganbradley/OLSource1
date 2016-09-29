---
title: "Control.Handler&lt;&#39;T&gt; Class (F#)"
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
  - "Control.Handler<'T>"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.FSharpHandler`1"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "Handler class [F#]"
  - "FSharpHandler class [F#]"
ms.assetid: 53830512-6518-40da-a2e6-27c7957edccd
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.Handler&lt;&#39;T&gt; Class (F#)
A delegate type associated with the F# event type [IEvent](../vs140/control.ievent--t--type-abbreviation--fsharp-.md).  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
type Handler<'T> =  
 class  
  abstract this.Invoke : obj * 'T -> unit  
 end  
```  
  
## Remarks  
 This type is named `FSharpHandler` in compiled assemblies. If you are accessing the type from a language other than F#, or through reflection, use this name.  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Invoke](../vs140/handler.invoke--t--method--fsharp-.md)|Calls the function or functions associated with the event handler.|  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)