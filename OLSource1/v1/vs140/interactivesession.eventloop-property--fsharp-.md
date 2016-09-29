---
title: "InteractiveSession.EventLoop Property (F#)"
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
  - "Microsoft.FSharp.Compiler.Interactive.InteractiveSession.EventLoop"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "InteractiveSession.EventLoop property [F#]"
  - "EventLoop property [F#]"
ms.assetid: 79671c60-f021-4a02-8082-a54acbd2addb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# InteractiveSession.EventLoop Property (F#)
Gets or sets the current event loop being used to process interactions.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Compiler.Interactive  
  
 **Assembly:** FSharp.Compiler.Interactive.Settings (in FSharp.Compiler.Interactive.Settings.dll)  
  
## Syntax  
  
```  
// Signatures:  
member this.EventLoop :  IEventLoop  
member this.EventLoop : IEventLoop with set :  IEventLoop  
  
// Usage:  
interactiveSession.EventLoop  
interactiveSession.EventLoop <- eventLoop  
```  
  
#### Parameters  
 eventLoop  
 Type: [IEventLoop](../vs140/interactive.ieventloop-interface--fsharp-.md)  
  
 An event loop for the interactive session.  
  
## Return Value  
  
## Remarks  
  
## Platforms  
 Windows 7, Windows Vista SP2, Windows XP SP3, Windows XP x64 SP2, Windows Server 2008 R2, Windows Server 2008 SP2, Windows Server 2003 SP2  
  
## Version Information  
 **F# Runtime**  
  
 Supported in: 2.0, 4  
  
 **Silverlight**  
  
 Supported in: 3  
  
## See Also  
 [Interactive.InteractiveSession Class (F#)](../vs140/interactive.interactivesession-class--fsharp-.md)   
 [Microsoft.FSharp.Compiler.Interactive Namespace (F#)](../vs140/microsoft.fsharp.compiler.interactive-namespace--fsharp-.md)