---
title: "Supported Event Types"
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
  - "debugging [Debugging SDK], supported events"
ms.assetid: a3c0386d-551e-4734-9a0c-368d1c2e6671
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Supported Event Types
Visual Studio debugging currently supports the following event types:  
  
-   Asynchronous events  
  
     Notify the session debug manager (SDM) and IDE that the state of the application being debugged is changing. These events are processed at the leisure of the SDM and the IDE. No reply is sent to the debug engine (DE) once the event is processed. The [IDebugOutputStringEvent2](../VS_csharp/idebugoutputstringevent2.md) and [IDebugMessageEvent2](../VS_csharp/idebugmessageevent2.md) interfaces are examples of asynchronous events.  
  
-   Synchronous events  
  
     Notify the SDM and IDE that the state of the application being debugged is changing. The only difference between these events and asynchronous events is that a reply is sent by means of the [ContinueFromSynchronousEvent](../VS_csharp/idebugengine2--continuefromsynchronousevent.md) method.  
  
     Sending a synchronous event is useful if you need your DE to continue processing after the IDE receives and processes the event.  
  
-   Synchronous stopping events, or stopping events  
  
     Notify the SDM and the IDE that the application being debugged has stopped executing code. When you send a stopping event by means of the method [IDebugEventCallback2::Event](../VS_csharp/idebugeventcallback2--event.md), the [IDebugThread2](../VS_csharp/idebugthread2.md) parameter is required. Stopping events are continued by a call to the one of the following methods:  
  
    -   [Execute](../VS_csharp/idebugprogram2--execute.md)  
  
    -   [Step](../VS_csharp/idebugprogram2--step.md)  
  
    -   [Continue](../VS_csharp/idebugprogram2--continue.md)  
  
     The interfaces [IDebugBreakpointEvent2](../VS_csharp/idebugbreakpointevent2.md) and [IDebugExceptionEvent2](../VS_csharp/idebugexceptionevent2.md) are examples of stopping events.  
  
    > [!NOTE]
    >  Asynchronous stopping events are not supported. It is an error to send an asynchronous stopping event.  
  
## Discussion  
 The actual implementation of events depends on the design of your DE. The type of each event sent is determined by its attributes, which are set when you design the DE. For example, one DE may send an [IDebugProgramCreateEvent2](../VS_csharp/idebugprogramcreateevent2.md) as an asynchronous event, while another may send it as a stopping event.  
  
 The following table specifies which program and thread parameters are required for which events, as well as event types. Any event can be synchronous. No event needs to be synchronous.  
  
> [!NOTE]
>  The [IDebugEngine2](../VS_csharp/idebugengine2.md) interface is required for all events.  
  
|Event|IDebugProgram2|IDebugThread2|Stopping Events|  
|-----------|--------------------|-------------------|---------------------|  
|[IDebugActivateDocumentEvent2](../VS_csharp/idebugactivatedocumentevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugBreakEvent2](../VS_csharp/idebugbreakevent2.md)|Required|Required|Yes|  
|[IDebugBreakpointBoundEvent2](../VS_csharp/idebugbreakpointboundevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugBreakpointErrorEvent2](../VS_csharp/idebugbreakpointerrorevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugBreakpointUnboundEvent2](../VS_csharp/idebugbreakpointunboundevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugBreakpointEvent2](../VS_csharp/idebugbreakpointevent2.md)|Required|Required|Yes|  
|[IDebugCanStopEvent2](../VS_csharp/idebugcanstopevent2.md)|Required|Required|No|  
|[IDebugDocumentTextEvents2](../VS_csharp/idebugdocumenttextevents2.md)|Not allowed|Not allowed|No|  
|[IDebugEngineCreateEvent2](../VS_csharp/idebugenginecreateevent2.md)|Not allowed|Not allowed|No|  
|[IDebugEntryPointEvent2](../VS_csharp/idebugentrypointevent2.md)|Required|Required|Yes|  
|[IDebugErrorEvent2](../VS_csharp/idebugerrorevent2.md)|Allowed, but not required|Allowed, but not required|Can be|  
|[IDebugExceptionEvent2](../VS_csharp/idebugexceptionevent2.md)|Required|Required|Yes|  
|[IDebugExpressionEvaluationCompleteEvent2](../VS_csharp/idebugexpressionevaluationcompleteevent2.md)|Allowed, but not required|Allowed, but not required|Can be|  
|[IDebugInterceptExceptionCompleteEvent2](../VS_csharp/idebuginterceptexceptioncompleteevent2.md)|Required|Required|Yes|  
|[IDebugLoadCompleteEvent2](../VS_csharp/idebugloadcompleteevent2.md)|Required|Required|Yes|  
|[IDebugMessageEvent2](../VS_csharp/idebugmessageevent2.md)|Allowed, but not required|Allowed, but not required|Can be|  
|[IDebugModuleLoadEvent2](../VS_csharp/idebugmoduleloadevent2.md)|Required|Allowed, but not required|No|  
|[IDebugOutputStringEvent2](../VS_csharp/idebugoutputstringevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugProgramCreateEvent2](../VS_csharp/idebugprogramcreateevent2.md)|Required|Allowed, but not required|No|  
|[IDebugProgramDestroyEvent2](../VS_csharp/idebugprogramdestroyevent2.md)|Required|Allowed, but not required|No|  
|[IDebugPropertyCreateEvent2](../VS_csharp/idebugpropertycreateevent2.md)|Required|Allowed, but not required|No|  
|[IDebugPropertyDestroyEvent2](../VS_csharp/idebugpropertydestroyevent2.md)|Required|Allowed, but not required|No|  
|[IDebugReturnValueEvent2](../VS_csharp/idebugreturnvalueevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|IDebugStopCompleteEvent2|Required|Required|Yes|  
|[IDebugStepCompleteEvent2](../VS_csharp/idebugstepcompleteevent2.md)|Required|Required|Yes|  
|[IDebugSymbolSearchEvent2](../VS_csharp/idebugsymbolsearchevent2.md)|Allowed, but not required|Allowed, but not required|No|  
|[IDebugThreadCreateEvent2](../VS_csharp/idebugthreadcreateevent2.md)|Required|Required|No|  
|[IDebugThreadDestroyEvent2](../VS_csharp/idebugthreaddestroyevent2.md)|Required|Required|No|  
|[IDebugThreadNameChangedEvent2](../VS_csharp/idebugthreadnamechangedevent2.md)|Allowed, but not required|Allowed, but not required|No|  
  
## See Also  
 [Sending Events](../VS_csharp/sending-events.md)