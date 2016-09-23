---
title: "EventSource Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - event/Microsoft::WRL::EventSource
dev_langs: 
  - C++
helpviewer_keywords: 
  - EventSource class
ms.assetid: 91f1c072-6af4-44e6-b6d8-ac6d0c688dde
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# EventSource Class
Represents an event. EventSource member functions add, remove, and invoke event handlers.  
  
## Syntax  
  
```  
template<  
   typename TDelegateInterface  
>  
class EventSource;  
```  
  
#### Parameters  
 `TDelegateInterface`  
 The interface to a delegate that represents an event handler.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[EventSource::EventSource Constructor](../vs140/eventsource--eventsource-constructor.md)|Initializes a new instance of the EventSource class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[EventSource::Add Method](../vs140/eventsource--add-method.md)|Appends the event handler represented by the specified delegate interface to the set of event handlers for the current EventSource object.|  
|[EventSource::GetSize Method](../vs140/eventsource--getsize-method.md)|Retrieves the number of event handlers associated with the current EventSource object|  
|[EventSource::InvokeAll Method](../vs140/eventsource--invokeall-method.md)|Calls each event handler associated with the current EventSource object using the specified argument types and arguments.|  
|[EventSource::Remove Method](../vs140/eventsource--remove-method.md)|Deletes the event handler represented by the specified event registration token from the set of event handlers associated with the current EventSource object.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[EventSource::addRemoveLock_ Data Member](../vs140/eventsource--addremovelock_-data-member.md)|Synchronizes access to the [targets_](../vs140/eventsource--targets_-data-member.md) array when adding, removing, or invoking event handlers.|  
|[EventSource::targets_ Data Member](../vs140/eventsource--targets_-data-member.md)|An array of one or more event handlers.|  
|[EventSource::targetsPointerLock_ Data Member](../vs140/eventsource--targetspointerlock_-data-member.md)|Synchronizes access to internal data members even while event handlers for this EventSource are being added, removed, or invoked.|  
  
## Inheritance Hierarchy  
 `EventSource`  
  
## Requirements  
 **Header:** event.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [WRL Namespace](../vs140/microsoft--wrl-namespace.md)