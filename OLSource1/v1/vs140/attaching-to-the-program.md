---
title: "Attaching to the Program"
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
  - "debug engines, attaching to programs"
ms.assetid: 9a3f5b83-60b5-4ef0-91fe-a432105bd066
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Attaching to the Program
After you have registered your programs with the appropriate port, you must attach the debugger to the program you want to debug.  
  
## Choosing How to Attach  
 There are three ways in which the session debug manager (SDM) attempts to attach to the program being debugged.  
  
1.  For programs that are launched by the debug engine through the [IDebugEngineLaunch2::LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md) method (typical of interpreted languages, for example), the SDM obtains the [IDebugProgramNodeAttach2](../vs140/idebugprogramnodeattach2.md) interface from the [IDebugProgramNode2](../vs140/idebugprogramnode2.md) object associated with the program being attached to. If the SDM can obtain the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> interface, the SDM then calls the [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md) method. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to indicate that it did not attach to the program and that other attempts can be made to attach to the program.  
  
2.  If the SDM can obtain the [IDebugProgramEx2](../vs140/idebugprogramex2.md) interface from the program being attached to, the SDM calls the [IDebugProgramEx2::Attach](../vs140/idebugprogramex2--attach.md) method. This approach is typical for programs that were launched remotely by the port supplier.  
  
3.  If the program cannot be attached through the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> methods, the SDM loads the debug engine (if not already loaded) by calling the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function and then calls the [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md) method. This approach is typical for programs launched locally by a port supplier.  
  
     It is also possible for a custom port supplier to call the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method in the custom port supplier's implementation of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method. Typically in this case, the custom port supplier launches the debug engine on the remote machine.  
  
 Attachment is achieved when the session debug manager (SDM) calls the [Attach](../vs140/idebugengine2--attach.md) method.  
  
 If you run your DE in the same process as the application to be debugged, then you must implement the following methods of [IDebugProgramNode2](../vs140/idebugprogramnode2.md):  
  
-   [GetHostName](../vs140/idebugprogramnode2--gethostname.md),  
  
-   [GetHostPid](../vs140/idebugprogramnode2--gethostpid.md)  
  
-   [GetProgramName](../vs140/idebugprogramnode2--getprogramname.md)  
  
 After the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method is called, follow these steps in your implementation of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method:  
  
1.  Send an [IDebugEngineCreateEvent2](../vs140/idebugenginecreateevent2.md) event object to the SDM. For more information, see [Sending Events](../vs140/sending-events.md).  
  
2.  Call the [GetProgramId](../vs140/idebugprogram2--getprogramid.md) method on the [IDebugProgram2](../vs140/idebugprogram2.md) object that was passed to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method.  
  
     This returns a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that is used to identify the program. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> must be stored in the object that represents the local program to the DE, and it must be returned when the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method is called on the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface.  
  
    > [!NOTE]
    >  If you implement the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> interface, the program's <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is passed to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method. This <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is used for the program's <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> returned by the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method.  
  
3.  Send an [IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md) event object to notify the SDM that the local <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object was created to represent the program to the DE. For details, see [Sending Events](../vs140/sending-events.md).  
  
    > [!NOTE]
    >  This is not the same <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object that was passed into the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method. The previously passed <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object is recognized by the port only and is a separate object.  
  
## See Also  
 [Launch-based Attachment](../vs140/launch-based-attachment.md)   
 [Sending Events](../vs140/sending-events.md)   
 [IDebugEngineLaunch2::LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md)   
 [IDebugProgramNodeAttach2](../vs140/idebugprogramnodeattach2.md)   
 [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [GetProgramId](../vs140/idebugprogram2--getprogramid.md)   
 [IDebugProgramEx2](../vs140/idebugprogramex2.md)   
 [IDebugProgramEx2::Attach](../vs140/idebugprogramex2--attach.md)   
 [IDebugEngine2::Attach](../vs140/idebugengine2--attach.md)