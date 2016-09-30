---
title: "Interactive.IEventLoop Interface (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "Microsoft.FSharp.Compiler.Interactive.IEventLoop"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "IEventLoop interface [F#]"
ms.assetid: 8d33b06b-8d6e-44d2-9de5-f3c5d54b9f0e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Interactive.IEventLoop Interface (F#)
An event loop used by the currently executing F# Interactive session to execute code in the context of a GUI or another event-based system.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Compiler.Interactive  
  
 **Assembly:** FSharp.Compiler.Interactive.Settings (in FSharp.Compiler.Interactive.Settings.dll)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
## Instance Members  
  
|Member|Description|  
|------------|-----------------|  
|[Invoke](../vs140/ieventloop.invoke--t--method--fsharp-.md)|Requests that the given operation be run synchronously on the event loop.|  
|[Run](../vs140/ieventloop.run-method--fsharp-.md)|Runs the event loop. A return of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> indicates that the event loop was restarted.|  
|[ScheduleRestart](../vs140/ieventloop.schedulerestart-method--fsharp-.md)|Schedule a restart for the event loop.|  
  
## Platforms  
 Windows 7, Windows Vista SP2, Windows XP SP3, Windows XP x64 SP2, Windows Server 2008 R2, Windows Server 2008 SP2, Windows Server 2003 SP2  
  
## Version Information  
 **F# Runtime**  
  
 Supported in: 2.0, 4  
  
 **Silverlight**  
  
 Supported in: 3  
  
## See Also  
 [Microsoft.FSharp.Compiler.Interactive Namespace (F#)](../vs140/microsoft.fsharp.compiler.interactive-namespace--fsharp-.md)