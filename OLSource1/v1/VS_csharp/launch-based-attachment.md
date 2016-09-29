---
title: "Launch-based Attachment"
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
  - "debug engines, launching"
  - "debug engines, attaching to programs"
ms.assetid: 362f00ac-1909-4a3a-bacb-c0ceb5549816
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Launch-based Attachment
Launch-based attachment to a program is automatic. When the process hosting the program is launched by the SDM, launch-based attachment follows a path similar to that of the manual attachment method. For information, see [Attaching to the Program](../VS_csharp/attaching-to-the-program.md).  
  
## The Attaching Process  
 The main difference is the sequence of events following the **Attach** call, as follows:  
  
1.  Send an **IDebugEngineCreateEvent2** event object to the SDM. For details, see [Sending Events](../VS_csharp/sending-events.md).  
  
2.  Call the `IDebugProgram2::GetProgramId` method on the **IDebugProgram2** interface passed to the **Attach** method.  
  
3.  Send an **IDebugProgramCreateEvent2** event object to notify the SDM that the local **IDebugProgram2** object was created to represent the program to the DE.  
  
4.  Send an [IDebugThreadCreateEvent2](../VS_csharp/idebugthreadcreateevent2.md) event object to notify the SDM that a new thread is created for the process that launched.  
  
## See Also  
 [Sending the Required Events](../VS_csharp/sending-the-required-events.md)   
 [Enabling a Program to Be Debugged](../VS_csharp/enabling-a-program-to-be-debugged.md)