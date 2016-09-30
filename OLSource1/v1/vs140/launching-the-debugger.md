---
title: "Launching the Debugger"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], launching the debugger"
  - "debugger [Debugging SDK], launching"
ms.assetid: f24da1a1-f923-48b4-989f-18a22b581d1b
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Launching the Debugger
Launching the debugger requires sending the correct sequence of methods and events with their proper attributes.  
  
## Sequences of Methods and Events  
  
1.  The session debug manager (SDM) is called by choosing the **Debug** menu, and then choosing **Start**. See [Launching a Program](../vs140/launching-a-program.md) for more information.  
  
2.  The SDM calls [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md) method .  
  
3.  Based on the debug engine (DE) process model, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method returns one of the following methods, which determines what happens next.  
  
     If <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is returned, the debug engine (DE) is to be loaded in process of the virtual machine.  
  
     -or-  
  
     If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is returned, the DE is to be loaded in-process of the SDM. The SDM then performs the following tasks:  
  
    1.  Calls [GetEngineInfo](../vs140/idebugprogramnode2--getengineinfo.md) to get the engine information of the DE.  
  
    2.  Co-creates the DE.  
  
    3.  Calls [Attach](../vs140/idebugengine2--attach.md).  
  
4.  The DE sends an [IDebugEngineCreateEvent2](../vs140/idebugenginecreateevent2.md) to the SDM with an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> attribute.  
  
5.  The DE sends an [IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md) to the SDM with an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute.  
  
6.  The DE sends an [IDebugThreadCreateEvent2](../vs140/idebugthreadcreateevent2.md) to the SDM with an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute.  
  
7.  The DE sends an [IDebugLoadCompleteEvent2](../vs140/idebugloadcompleteevent2.md) to the SDM with an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute.  
  
8.  The DE sends an [IDebugEntryPointEvent2](../vs140/idebugentrypointevent2.md) to the SDM with an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> attribute.  
  
## See Also  
 [Calling Debugger Events](../vs140/calling-debugger-events.md)   
 [Launching a Program](../vs140/launching-a-program.md)