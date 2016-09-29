---
title: "Sending Events"
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
  - "debugging [Debugging SDK], sending events"
ms.assetid: 064231e7-59b5-4437-8240-a23c0a7ec2a9
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Sending Events
The mechanism for communication between the debugger and the debug engine (DE) is an event model based on DCOM. Events are sent as COM objects, and each event has parameters that specify the following:  
  
-   The DE that called the event.  
  
-   A description of what happened.  
  
-   The process, program, and thread information that identifies the context of where the event occurred. The process is not sent for events sent from a DE.  
  
-   The event type that indicates whether the event is synchronous or asynchronous.  
  
 All debug events are sent using the method [IDebugEventCallback2::Event](../VS_csharp/idebugeventcallback2--event.md).  
  
## In This Section  
 [Event Sources](../VS_csharp/event-sources--visual-studio-sdk-.md)  
 Explains the two sources of events: the debug engine (DE) and the session debug manager (SDM).  
  
 [Supported Event Types](../VS_csharp/supported-event-types.md)  
 Discusses the currently supported event types: asynchronous and synchronous.  
  
 [Event Descriptions](../VS_csharp/event-descriptions.md)  
 Defines events and the reasons for their use.  
  
## Related Sections  
 [Creating a Custom Debug Engine](../VS_csharp/creating-a-custom-debug-engine.md)  
 Describes how a DE works with the interpreter or operating system to provide debugging services.