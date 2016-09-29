---
title: "Event Handling"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "attributes [C++], event handling"
  - "intrinsic functions, event handling"
  - "event handling, Visual C++"
ms.assetid: 82de3f9a-2d88-470c-9527-8a5b54c8ced4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event Handling
Event handling is primarily supported for COM classes (C++ classes that implement COM objects, typically using ATL classes or the [coclass](../vs140/coclass.md) attribute).  For more information, see [Event Handling in COM](../vs140/event-handling-in-com.md).  
  
 Event handling is also supported for native C++ classes (C++ classes that do not implement COM objects), however, that support is deprecated and will be removed in a future release.  For more information, see [Event Handling in Native C++](../vs140/event-handling-in-native-c--.md).  
  
 Event handling supports single- and multithreaded usage and protects data from simultaneous multithread access. It also allows you to derive subclasses from event source or receiver classes and support extended event sourcing/receiving in the derived class.  
  
 Visual C++ includes attributes and keywords for declaring events and event handlers. The event attributes and keywords can be used in CLR programs and in native C++ programs.  
  
|Topic|Description|  
|-----------|-----------------|  
|[event_source](../vs140/event_source.md)|Creates an event source.|  
|[event_receiver](../vs140/event_receiver.md)|Creates an event receiver (sink).|  
|[__event](../vs140/__event.md)|Declares an event.|  
|[__raise](../vs140/__raise.md)|Emphasizes the call site of an event.|  
|[__hook](../vs140/__hook.md)|Associates a handler method with an event.|  
|[__unhook](../vs140/__unhook.md)|Dissociates a handler method from an event.|  
  
## See Also  
 [C++ Language Reference](../vs140/c---language-reference.md)   
 [Keywords](../vs140/keywords--c---.md)   
 [Event Handling Samples](assetId:///cc0287d4-f92b-4da5-85fc-a0f186e16424)